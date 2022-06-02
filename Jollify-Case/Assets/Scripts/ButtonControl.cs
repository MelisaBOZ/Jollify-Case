using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
   public GameObject play;
   public float time;
   public Text timetext;
   public bool x=true;
    void Start()
    {
        time=0;
        timetext.text="Time : "+ time;
    }

  
    void Update()
    {
      
       if(x==false)
        time+=Time.deltaTime;
        timetext.text="Time : "+ time;
    }
    public void playbutton ()
    { 
        Time.timeScale=1;
        play.SetActive(false);
        x=false;
    }
}
