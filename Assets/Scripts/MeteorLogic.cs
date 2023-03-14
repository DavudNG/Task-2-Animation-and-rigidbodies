using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public bool bIsLive = true;
    public Vector3 vDirectVelocity;
    public GameObject myExplosion;


    void Start()
    {
        vDirectVelocity = new Vector3(0, -9.8f, -9);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(bIsLive)
        {
            this.GetComponent<Rigidbody>().velocity += vDirectVelocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("a collision occurred");
        bIsLive = false;
        this.transform.DetachChildren();
        //this.GetComponent<Rigidbody>().velocity = Vector3.zero;
        myExplosion.SetActive(true);
        //this.GetComponent<MeshRenderer>().enabled = false;
    }
}
