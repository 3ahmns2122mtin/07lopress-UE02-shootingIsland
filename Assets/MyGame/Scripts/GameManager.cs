using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const int maxHit = 10;
    public GameObject target;
    public GameObject parentOfTargets;
    public GameObject objCounter;
    public GameObject wonObj;
    public GameObject shootSound;

    public GameObject loseSound;
    public GameObject earTarget;
    public GameObject parentOfEarTarget;


    private Text textCounter;
    private bool won;
    private int score;



    // Start is called before the first frame update
    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        won = false;
        InvokeRepeating("Spawn", 1f, 2f);
        InvokeRepeating("EarSpawn", 2f, 4f);
        wonObj.SetActive(false);
    }


    //Spawn a target at a random position within a specified x and y range.
    //Intantiate (make a concrete GameObject, i.e., a clone from the given prefab target) the target as child of the ParenOfTargets. 
    //In this case transform.localPosition instead of transform.position is important!!

    private void Spawn()
    {
        float randomX = Random.Range(-480, 480);
        float randomY = Random.Range(-300, 300);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;
    }

    private void EarSpawn()
    {
        float randomX = Random.Range(-480, 480);
        float randomY = Random.Range(-300, 300);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myEarTarget = Instantiate(earTarget, parentOfEarTarget.transform);
        myEarTarget.transform.localPosition = random2DPosition;
    }


    // Update is called once per frame
    void Update()
    {
        if (won == true)
        {
            CancelInvoke("Spawn");
            CancelInvoke("EarSpawn");
            wonObj.SetActive(true);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("increment ... " + score);
        textCounter.text = score.ToString();
      

        if (score == maxHit)
        {
            won = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            shootSound.GetComponent<AudioSource>().Play();
        }
    }

    public void DecrementScore()
    {
        score--;
        Debug.Log("decrement ... " + score);
        textCounter.text = score.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            loseSound.GetComponent<AudioSource>().Play();
        }
    }
}