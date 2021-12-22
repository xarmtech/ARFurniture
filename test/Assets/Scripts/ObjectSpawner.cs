using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    #region Objects
    public GameObject[] prefabs;
    #endregion

    public int ObjectId;

    public GameObject objectToSpawn;
    [SerializeField] PlacementIndicator placementIndicator;

    public void CreateGameobjects(int index)
    {
        ObjectId = index;

        if(objectToSpawn)
        {
            Destroy(objectToSpawn);
        }
        objectToSpawn = Instantiate(prefabs[index],
        placementIndicator.transform.position, placementIndicator.transform.rotation);

    }

    public void RotateSpawnedObject()
    {
        if (objectToSpawn && !objectToSpawn.GetComponent<RotateObj>().rotateStatus)
        {
            objectToSpawn.GetComponent<RotateObj>().rotateStatus = true;
        }
        else if(objectToSpawn && objectToSpawn.GetComponent<RotateObj>().rotateStatus)
        {
            objectToSpawn.GetComponent<RotateObj>().rotateStatus = false;
        }
        
    }
}
