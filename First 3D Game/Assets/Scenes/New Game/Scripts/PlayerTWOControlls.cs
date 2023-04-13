using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTWOControlls : MonoBehaviour
{
    public float _moveSpeed = 5;
     public int forceConst = 500;
     
    private Rigidbody selfRigidbody;
     public GameObject player;
    public float sensitivity;
    float star = 0;

    // Start is called before the first frame update
    void Start()
    {
         selfRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         {
         float rotateHorizontal = Input.GetAxis ("Mouse X");
         float rotateVertical = Input.GetAxis ("Mouse Y");
         transform.RotateAround (player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
        transform.RotateAround (Vector3.zero, transform.right, rotateVertical * sensitivity);
        }
    }
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed*Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
        
        if (Input.GetKey(KeyCode.LeftShift))
    {
        _moveSpeed = 20;
    }
    else
    {
        _moveSpeed = 5;
    }
    }
    
}

