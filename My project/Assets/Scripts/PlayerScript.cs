using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rgbd;
    private float xdir, zdir;


    void Awake()
    {
        rgbd = this.gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xdir = Input.GetAxis("Horizontal");
        zdir = Input.GetAxis("Vertical");

        rgbd.velocity = new Vector3(xdir, 0f, zdir) * speed;
    }
}
