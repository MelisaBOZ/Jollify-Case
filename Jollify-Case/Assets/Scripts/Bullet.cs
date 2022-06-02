using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public int sayac=0;
    public float bulletspeed=10;
    public float endtime=3;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity=transform.forward*bulletspeed;
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject,endtime);
            sayac++;
        }
        
    }
}
