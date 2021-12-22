using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIAim : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public static UIAim instance;
    public bool canMouseLook;

    public void OnBeginDrag(PointerEventData eventData)
    {
        canMouseLook = true;
        Debug.Log("Can MOuse Look TRue");
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canMouseLook = false;
        Debug.Log("Can MOuse Look False");
    }






    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
