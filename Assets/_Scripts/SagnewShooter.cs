using UnityEngine;
using System.Collections;

public class SagnewShooter : MonoBehaviour
{
    public static SagnewShooter S;
    public float speed;
    public GameObject samBullet;

    void Awake()
    {
        S = this;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inp = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        GetComponent<Rigidbody2D>().MovePosition(transform.position + inp * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.X))
            Instantiate(samBullet, transform.position, transform.rotation);

    }

}
