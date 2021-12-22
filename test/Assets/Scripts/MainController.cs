using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public GameObject[] Models;

    public static bool Rotate = false; // static to get it everywhere



    public void AllModels(int index)
    {
        for (int i = 0; i < Models.Length; i++)
        {
            if (i==index)
            {
                Models[index].SetActive(true);
            }

            else
            {
                Models[i].SetActive(false);

            }
        }

    }



    public void ButtonRotationDown()
    {
        Rotate = true;
    }

    public void ButtonRotationUp()
    {
        Rotate = false;
    }

    
    
    
    //public void Rotate1()
    //{

    //    transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime);
    //}
}
