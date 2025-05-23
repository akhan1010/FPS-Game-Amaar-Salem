using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
   public float mouseSensitivity = 400f;
   float xRotation = 0f;
   float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;

   void Start()
   {
    //Locking cursor to the middle of the screen and turns it invisible
     Cursor.lockState = CursorLockMode.Locked;
   } 

   void Update(){
    //Getting mouse inputs constantly
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    //Looking up and down (rotation around x axis)
    //Moving mouse forward goes up, backwards goes down
    xRotation -= mouseY;

    //Clamp rotation
    xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

    //Looking left and right (rotation around y axis)
    yRotation += mouseX;

    transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

   }
   }

