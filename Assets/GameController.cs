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
