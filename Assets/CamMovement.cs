using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    [SerializeField] Camera cam;
    public float scrollSpeed = 10f;
    private Vector3 dragOrigin;


    private void LateUpdate() 
    {
        PanCamera();
    }

    private void PanCamera()
    {
        cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;

        if(Input.GetMouseButton(0))
        {
            cam.transform.position += new Vector3(-0.1f,0,0);
        }
        else if (Input.GetMouseButton(1))
        {
            cam.transform.position += new Vector3(0.1f,0,0);
        }
        
            
            
            //dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        //}

        /*if (Input.GetMouseButton(0))
        {
            Debug.Log("that one ya floppy poo");
            Vector3 difference = dragOrigin - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position += difference;
        }*/
    }


}
