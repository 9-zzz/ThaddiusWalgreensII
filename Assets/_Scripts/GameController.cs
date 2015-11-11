using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{

    public static GameController S;
    public float score;
    public Transform[] spawnPoints;
    public float waitTime;
    public GameObject samFaller;
    public GameObject sam;
    public Text scoreText;

    void Awake()
    {
        S = this;
    }

    // Use this for initialization
    void Start()
    {
        StartCoroutine(waitAndSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (sam.gameObject != null)
        {
            if (sam.transform.position.y < -5.25f)
            {
                Destroy(sam.gameObject);
                scoreText.text = "GAME OVER";
            }
        }
    }

    IEnumerator waitAndSpawn()
    {
        while (true)
        {
            Instantiate(samFaller, spawnPoints[Random.Range(0, 3)].transform.position, transform.rotation);
            yield return new WaitForSeconds(waitTime);
        }
    }

}
