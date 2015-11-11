using UnityEngine;
using System.Collections;

public class SamBullet : MonoBehaviour
{

    public Vector2 sForce;

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Rigidbody2D>().AddForce(sForce, ForceMode2D.Impulse);

        Destroy(gameObject, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
