using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float actualSpeed = 5.0f;
    float rotY = 0;
    public float rotationRange = 60.0f;
    float verticalVelocity = 0.0f;
    public float jumpSpeed = 7.0f;
    //bool doubleJump = false;
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {


        //Rotation
        float rotX = Input.GetAxis("Mouse X");
        transform.Rotate(0, rotX, 0);
        rotY -= Input.GetAxis("Mouse Y");
        rotY = Mathf.Clamp(rotY, -rotationRange, rotationRange);
        Camera.main.transform.localRotation = Quaternion.Euler(rotY, 0, 0);


        //Movemnet
        float forwardSpeed = Input.GetAxis("Vertical") * actualSpeed;
        
        float sideSpeed = Input.GetAxis("Horizontal")*actualSpeed;
        verticalVelocity += Physics.gravity.y * Time.deltaTime;
        if(Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            verticalVelocity = jumpSpeed;
            //doubleJump = true;
        }
        
        Vector3 speed = new Vector3(sideSpeed , verticalVelocity, forwardSpeed);
        speed = transform.rotation*speed;
        
        cc.Move(speed * Time.deltaTime);    
    }
}
