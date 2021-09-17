using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldowns : MonoBehaviour
{
   public float cooldownTime = 5;
   private float readyTime = 0;
   private GameObject laser1;
   private GameObject laser2;

   void Start()
   {
      laser1 = GameObject.FindGameObjectWithTag("laser1");
      laser2 = GameObject.FindGameObjectWithTag("laser2");
      laser2.SetActive(false);
   }
   
   private void Update()
   {
       if (Time.time > readyTime)
       {
            if (Input.GetButton("Fire2"))
            {
             altFire();
             Debug.Log("Fire 2 used");
             readyTime = Time.time + cooldownTime;
            }
       }    
   }
   private void altFire()
   {
      if (laser2.activeInHierarchy == false)
      {
         laser1.SetActive(false);
         laser2.SetActive(true);
      }
      else if (laser2.activeInHierarchy == true)
      {
         laser1.SetActive(true);
         laser2.SetActive(false);
      }
   }
    
}
