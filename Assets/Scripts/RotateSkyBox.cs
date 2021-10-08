using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkyBox : MonoBehaviour
{
   [SerializeField]public float RotateSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
