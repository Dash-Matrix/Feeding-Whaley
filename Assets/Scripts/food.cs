using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class food : MonoBehaviour
{
    public float scaleUpgrade;

    public UIManager uiManager;


    private void Start()
    {
        // Generate random position within the specified ranges
        float randomX = Random.Range(-(10 + transform.position.x), 10 + transform.position.x);
        float randomY = Random.Range(-(4 + transform.position.y), 4 + transform.position.y);

        transform.DOMove(new Vector2(randomX, randomY), Random.Range(15, 40)).SetLoops(-1, LoopType.Yoyo);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().size += scaleUpgrade;

            uiManager.UpdateScore();
        }

        Destroy(gameObject);
    }
}
