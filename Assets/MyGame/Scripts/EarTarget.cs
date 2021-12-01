using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarTarget : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.DecrementScore();
        Destroy(gameObject);
    }
}
