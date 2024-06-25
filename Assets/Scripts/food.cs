using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class food : MonoBehaviour
{
    public Vector3 scaleUpgrade;

    public UIManager uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().size += scaleUpgrade.x;
            collision.gameObject.transform.localScale += scaleUpgrade;

            uiManager.UpdateScore();
        }

        Destroy(gameObject);
    }
}
