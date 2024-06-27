using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // the speed of the character
    private float speed = 6f;

    // referencing Joystick UI
    public Joystick joystick;

    public float size = 1;

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
}
