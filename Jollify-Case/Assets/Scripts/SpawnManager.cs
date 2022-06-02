using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  [SerializeField] private GameObject enemy;
  public bool x=true;
  //Bullet sayac= FindObjectOfType<Bullet>();
    void Start()
    {
         
    }

    void Update()
    {
      if(Time.time>=1 && x)
        {
            Instantiate(enemy,transform.position,transform.rotation);
            x=false;
        }
     // if(sayac.sayac==3)
      //{
          //Instantiate(enemy,transform.position,transform.rotation);
      //}
    }
}
