using UnityEngine;
using System.Collections;

public class SamFaller : MonoBehaviour
{

    public GameObject samDeathPSFX;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "sambullet")
        {
            GameController.S.score++;
            GameController.S.scoreText.text = "SCORE: " + GameController.S.score;

            Instantiate(samDeathPSFX, transform.position, transform.rotation);
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }

}
