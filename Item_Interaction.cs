using System.Collections.Generic;
using System.Collections;
using UnityEngine;
public class Item_Interactions : MonoBehaviour
{
// item mask
public LayerMask Itemlayer;
public LayerMask Placelayer;
public float raycastlen = 30f;
private string ItemSelected;
private string PlaceSelected;
public GameObject Key;
public GameObject Pizza;
public GameObject Pizza2;
private bool Key_collected = false;
private bool Pizza_collected = false;
    void Update()
    {   
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, raycastlen, Placelayer))
            {
            Debug.Log("testing");
            ItemSelected = hit.collider.gameObject.name;
            Debug.Log(ItemSelected);
            }
        }
        switch(ItemSelected)
            {
                case "Key":
                Debug.Log(ItemSelected);
                Key.SetActive(false);
                break;
                case "Pizza":
                Debug.Log(ItemSelected);
                Pizza.SetActive(false);
                Pizza_collected = true;                
                break;
            }
        if(Input.GetMouseButtonDown(0) && Key_collected || Input.GetMouseButtonDown(0) && Pizza_collected)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, raycastlen, Placelayer))
            {
            Debug.Log("testing");
            PlaceSelected= hit.collider.gameObject.name;
            Debug.Log(PlaceSelected);
            }
        }
        switch(PlaceSelected)
            {
                case "KeyArea":
                Debug.Log(PlaceSelected);
                Key.SetActive(false);
                break;
                case "PizzaArea":
                Debug.Log(PlaceSelected);
                Pizza2.SetActive(true);                
                break;
            }
    }
    }