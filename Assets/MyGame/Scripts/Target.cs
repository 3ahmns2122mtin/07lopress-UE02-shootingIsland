using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private int secToDestroy;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        secToDestroy = 3;
        Destroy(gameObject, secToDestroy);
    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
}