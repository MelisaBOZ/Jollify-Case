using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]

    public float speed=15f;
    
   
   
   
	
	void Start ()
     {
       
     
       
	}
	
	
	void Update ()
    {
        PlayerMove();
 
       
	}
   
    
    public void PlayerMove()
    {
    if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) )
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) )
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-20.20f,18.2f),transform.position.y,Mathf.Clamp(transform.position.z,-20.2f,18.2f));
        

    }
}
