using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldowns : MonoBehaviour
{
   public float cooldownTime = 5;
   private float gunReadyTime = 0;
   private float shieldReadyTime = 0;
   private GameObject laser1;
   private GameObject laser2;
   private GameObject shield;


   void Start()
   {
      laser1 = GameObject.FindGameObjectWithTag("laser1");
      laser2 = GameObject.FindGameObjectWithTag("laser2");
      shield = GameObject.FindGameObjectWithTag("shield");
      laser2.SetActive(false);
      shield.SetActive(false);
   }
   
   private void Update()
   {
       if (Time.time > gunReadyTime)
       {
            if (Input.GetButton("Fire2"))
            {
             altFire();
             Debug.Log("Fire 2 used");
             gunReadyTime = Time.time + cooldownTime;
            }
       }
       if (Time.time > shieldReadyTime)  
       {
          if (Input.GetButton("Fire3"))
          {
            shield.SetActive(true);
            Debug.Log("Shields online");
            shieldReadyTime = Time.time + cooldownTime;
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
