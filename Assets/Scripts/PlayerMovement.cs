using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] GameObject[] lasers;
    [SerializeField] float xClamp =1;
    [SerializeField] AudioClip pewpewClip;
    [SerializeField] AudioClip pewpewClip2;
    AudioSource pewpew;
    
    void Start()
    {
        pewpew = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        MovePlayer();
        FireCon();
    }

    void MovePlayer()
{
    float xMove = Input.GetAxis("Horizontal");
    float xOffset = xMove * Time.deltaTime * moveSpeed;
    float updateX = transform.localPosition.x + xOffset;
    float xClampUpdate = Mathf.Clamp(updateX, -xClamp, xClamp);
    transform.localPosition = new Vector3(xClampUpdate,transform.localPosition.y,transform.localPosition.z);

        //if (Input.GetKey(KeyCode.A))
        //{
        //transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        //}
        // else if (Input.GetKey(KeyCode.D))
        //{
        //transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        //}

}

public void FireLasers(bool fireActive)
    {
        foreach (GameObject laser in lasers)
        {
            var emissionMod = laser.GetComponent<ParticleSystem>().emission;
            emissionMod.enabled = fireActive;
            
        }
    
    }

public void FireCon()
    {
        
        if (Input.GetButton("Fire1"))
        {
            FireLasers(true);
            pewpewAudio();
            Debug.Log("firing my laser");
        }
        else
        {
            FireLasers(false);
            Debug.Log("Not shooting");
        }
    }
public void pewpewAudio()
{
   
    if (!pewpew.isPlaying)
    {
        pewpew.PlayOneShot(pewpewClip);
    } 

   
   
}
}
