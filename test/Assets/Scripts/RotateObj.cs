using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj: MonoBehaviour
{
    public float rotateSpeed = 100f;
    public bool rotateStatus;
   
    void Update()
    {
        if (rotateStatus == true)
        {
            Debug.Log("Button Update");
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }

        //LeanTween.scale(this.gameObject, new Vector3(1.5f,1.5f,1.5f), 0.7f);
        }
}