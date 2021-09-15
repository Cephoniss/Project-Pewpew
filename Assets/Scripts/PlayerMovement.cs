using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] GameObject[] lasers;

    void Start()
    {
        
    }

    
    void Update()
    {
        MovePlayer();
        FireCon();
    }

    void MovePlayer()
{
     if (Input.GetKey(KeyCode.A))
        {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
         else if (Input.GetKey(KeyCode.D))
        {
        transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
    //float horizontalInput = Input.GetAxis("Horizontal");
    //float verticalInput = Input.GetAxis("Vertical");
    //transform.position = transform.position + (horizontalInput * moveSpeed * Time.deltaTime); //verticalInput * moveSpeed * Time.deltaTime, 0);
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
        //Debug.Log("firing my laser");
        }
        else
        {
        FireLasers(false);
        //Debug.Log("Not shooting");
        }
    }
    
}