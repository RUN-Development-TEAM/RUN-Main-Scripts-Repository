using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Object_Interactions : MonoBehaviour
{
RaycastHit hitinfo;

public LayerMask ObjectLayer;
public LayerMask DoorLayer;
private string Door_Name;
private string Object_Name;
public Animator Bedroom_Door_Animator;
public Animator Office_Door_Animator;
public Animator Bathroom_Door_Animator;
public Animator Kitchen_Door_Animator;
public Animator Livingroom_Door_Animator;
public Animator Toilet_Animator;
public Animator Fridge_Animator;
public Animator Microwave_Animator;
public Animator Bedroom_Drawer_Animator;
public Animator Attic_Ladder_Animator;

private bool Bedroom_Door_State = false;
private bool Office_Door_State = false;
private bool Bathroom_Door_State = false;
private bool Kitchen_Door_State = false;
private bool Livingroom_Door_State = false;

private bool Fridge_State = false;
private bool Microwave_State = false;
private bool Bedroom_Drawer_State = false;
private bool Computer_State = false;

public GameObject Computer_System;


void Update()
{
 if (Input.GetKeyDown(KeyCode.E))
 {
    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 6f, ObjectLayer))
    {
    Object_Name = hitinfo.collider.GameObject.name;
    } 
 }
 if (Input.GetKeyDown(KeyCode.E))
 {
    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 6f, DoorLayer))
    {
    Door_Name = hitinfo.collider.GameObject.name;   
    } 
 }
 switch(Door_Name)
 {
    case "Bedroom_Door":
        if (Bedroom_Door_State == false)
        {
            Bedroom_Door_Animator.Play("Open_Bedroom_Door", 0, 0.0f);
            Bedroom_Door_State = true;
        }
        else
        {
            Bedroom_Door_Animator.Play("Close_Bedroom_Door", 0, 0.0f);
            Bedroom_Door_State = false;
        }
        break;
        case "Office_Door":
        if (Office_Door_State == false)
        {
            Office_Door_Animator.Play("Open_Office_Door", 0, 0.0f);
            Office_Door_State = true;
        }
        else
        {
            Office_Door_Animator.Play("Close_Office_Door", 0, 0.0f);
            Office_Door_State = false;

        }
        break;
        case "Bathroom_Door":
        if (Bathroom_Door_State == false)
        {
            Bathroom_Door_Animator.Play("Open_Bathroom_Door", 0, 0.0f);
            Bathroom_Door_State = true;
        }
        else
        {
            Bathroom_Door_Animator.Play("Close_Bathroom_Door", 0, 0.0f);
            Bathroom_Door_State = false;
        }
        break;
        case "Kitchen_Door":
        if (Kitchen_Door_State == false)
        {
            Kitchen_Door_Animator.Play("Open_Kitchen_Door", 0, 0.0f);
            Kitchen_Door_State = true;
        }
        else
        {
            Kitchen_Door_Animator.Play("Close_Kitchen_Door", 0, 0.0f);
            Kitchen_Door_State = false;
        }
        break;
        case "Livingroom_Door":
        if (Livingroom_Door_State == false)
        {
            Livingroom_Door_Animator.Play("Open_Livingroom_Door", 0, 0.0f);
            Livingroom_Door_State = true;
        }
        else
        {
            Livingroom_Door_Animator.Play("Close_Livingroom_Door", 0, 0.0f);
            Livingroom_Door_State = false;
        }
        break;
        }
switch(Object_Name)
{
    case "Fridge":
        if (Fridge_State == false)
        {
            Fridge_Animator.Play("Open_Fridge", 0, 0.0f);
            Fridge_State = true;
        }
        else
        {
            Fridge_Animator.Play("Close_Fridge", 0, 0.0f);
            Fridge_State = false;
        }
        break;
        case "Microwave":
        if (Microwave_State == false)
        {
            Microwave_Animator.Play("Open_Microwave", 0, 0.0f);
            Microwave_State = true;
        }
        else
        {
            Microwave_Animator.Play("Close_Microwave", 0, 0.0f);
            Microwave_State = false;
        }
        break;
        case "Bedroom_Drawer":
        if (Bedroom_Drawer_State == false)
        {
            Bedroom_Drawer_Animator.Play("Open_Bedroom_Drawer", 0, 0.0f);
            Bedroom_Drawer_State = true;
        }
        else
        {
            Bedroom_Drawer_Animator.Play("Close_Bedroom_Drawer", 0, 0.0f);
            Bedroom_Drawer_State = false;
        }
        break;
        case "Computer":
        if(Computer_State)
        {
        Computer_System.SetActive(true);
        }
        else
        {
        Computer_System.SetActive(false);     
        }
        break;
}
}
}