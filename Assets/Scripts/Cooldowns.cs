using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldowns : MonoBehaviour
{
   public float cooldownTime = 5;
   public float shieldCDTime = 10;
   private float gunReadyTime = 0;
   private float shieldReadyTime = 0;
   public GameObject laser1;
   public GameObject laser2;
   private GameObject shield;
   public Rigidbody rb;


   void Start()
   {
      laser1 = GameObject.FindGameObjectWithTag("laser1");
      laser2 = GameObject.FindGameObjectWithTag("laser2");
      shield = GameObject.FindGameObjectWithTag("shield");
      laser2.SetActive(false);
      shield.SetActive(false);
      rb = GetComponent<Rigidbody>();
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
            shieldsActive();
            StartCoroutine(shieldsDeactive()); 
            shieldReadyTime = Time.time + shieldCDTime;
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
   private void shieldsActive()
    {
      if (shield.activeInHierarchy == true)
      {
         rb.isKinematic = true;
         rb.detectCollisions = false;
         Debug.Log("Shields online");    
      }
      else
      {
         rb.isKinematic = false;
         rb.detectCollisions = true;
      }
   }
   IEnumerator shieldsDeactive()
   {
      yield return new WaitForSeconds(5);
      shield.SetActive(false);
      Debug.Log("Shields offline");
      rb.isKinematic = false;
      rb.detectCollisions = true;
   }
}
