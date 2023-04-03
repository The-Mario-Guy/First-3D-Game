using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float _moveSpeed = 20;
     public int forceConst = 500;
     
      private bool canJump;
    private Rigidbody selfRigidbody;
     public GameObject player;
    public float sensitivity;
    float star = 0;
    public TextMeshProUGUI StarText;

    // Start is called before the first frame update
    void Start()
    {
         selfRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(canJump)
        {
         canJump = false;
         selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
        }

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
        if(Input.GetKeyUp(KeyCode.Space)){
         canJump = true;
     }
    }
    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed*Time.deltaTime;

        transform.Translate(xValue, 0f, zValue);
    }
     private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Star")
        {
            star++;
            StarText.text = star.ToString("0");
        }  
        if(other.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene(4);
        }  
    }
}
