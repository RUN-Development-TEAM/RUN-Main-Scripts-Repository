using System.Collections.Generic;
using System.Collections;
using UnityEngine;
public class Pickup_Interactions : MonoBehaviour
{
// item mask
public LayerMask Itemlayer;
public float raycastlen = 6f;
private string ItemSelected;
public GameObject Key;
public GameObject Pizza;
public GameObject Flashlight;

    void Update()
    {   
        if(Input.GetMouseButtonDown(0))
        {
        Debug.Log("testing");
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, raycastlen, Itemlayer))
            {
            Debug.Log("testing");
            ItemSelected = hit.collider.gameObject.name;
            }
            switch(ItemSelected)
            {
                case "Key":
                Debug.Log("testing");
                break;
                case "Pizza":
                break;
                case "Flashlight":
                break;

            }
        }
    }























































































}