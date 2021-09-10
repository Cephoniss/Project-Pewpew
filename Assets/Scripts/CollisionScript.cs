using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
  [SerializeField] ParticleSystem deathAnimation;
   private void OnCollisionEnter(Collision other) 
   {
       Debug.Log($"{this.name} **Triggered By** {other.gameObject.name}");
       StartDeath();
   }
   
   void OnTriggerEnter(Collider other) 
   {
       Debug.Log($"{this.name} **Triggered By** {other.gameObject.name}");
       StartDeath();
   }
    
    void StartDeath()
    {
        
        deathAnimation.Play();
        GetComponent<PlayerMovement>().enabled = false;
        Invoke("ReloadLevel", 1f);
        //foreach (MeshRenderer meshInChild in GetComponentsInChildren<MeshRenderer>())
       // meshInChild.enabled = false;

        //foreach (Collider colliderInChild in GetComponentsInChildren<Collider>())
        //colliderInChild.enabled = false;
    }
        void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
