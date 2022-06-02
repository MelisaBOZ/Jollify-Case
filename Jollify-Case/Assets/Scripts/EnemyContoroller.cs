using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoroller : MonoBehaviour
{
   private Transform target;
 //  public float speed= FindObjectOfType<PlayerController>().speed;
   public float speed=7.5f;

    void Start()
    {
        target= GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
         transform.Translate (Vector3.forward * (speed/2) * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-20.20f,18.2f),transform.position.y,Mathf.Clamp(transform.position.z,-20.2f,18.2f));
    }
    
}
