using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textureChange : MonoBehaviour
{
    public Material mainMat;
    //public Renderer rend;
    Renderer[] rend;


    public void Textu()
    {

        rend = GetComponentsInChildren<Renderer>();
        foreach (Renderer rend in rend)
        {
            var mats = new Material[rend.materials.Length];
            for (var j = 0; j < rend.materials.Length; j++)
            {
                mats[j] = mainMat;
            }
            rend.materials = mats;

            //rend.sharedMaterial = mainMat;
            //Debug.Log("Textu");
        }

    }

        


}