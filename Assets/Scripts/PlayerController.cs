using Cinemachine;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UIManager iuManager;
    public int eatenFishes = 0;
    public int fishesToEat = 0;

    // the speed of the character
    private float speed = 6f;

    // referencing Joystick UI
    public Joystick joystick;

    public float size = 1;

    public CinemachineVirtualCamera virtualCamera;
    public float OrthoSize = 5;

    private void Update()
    {
        // initialize a new Vector2
        Vector2 movement = Vector2.zero;

        // set the x component to horizontal input
        movement.x = joystick.Horizontal;

        // set the y component to vertical input
        movement.y = joystick.Vertical;

        // multiply vector with speed and Time.deltaTime
        movement *= speed * Time.deltaTime;

        // translate the character using the vector
        transform.Translate(movement);

        // adjust the x scale based on movement direction
        if (movement.x > 0)
        {
            transform.localScale = new Vector3(size, size, size);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(-size, size, size);
        }
    }

    public void FishEaten(float upgradeSize)
    {
        eatenFishes++;

        size += upgradeSize;

        OrthoSize += upgradeSize * 3f;
        virtualCamera.m_Lens.OrthographicSize = OrthoSize;

        if(eatenFishes == fishesToEat)
        {
            Debug.Log("Fishes Eaten");
            iuManager.Won();
        }
    }
}
