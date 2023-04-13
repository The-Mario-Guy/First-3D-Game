 using UnityEngine;
 using System.Collections;
 
 public class Player : MonoBehaviour {
     
     public float movementSpeed = 10;
     
     public GameObject DirectionObject;
     
     // Use this for initialization
     void Start () { 
     }
     
     // Update is called once per frame
     void Update () {
         if (Input.GetKey(KeyCode.A)) {
             Move(Vector3.left);            
         }
         if (Input.GetKey(KeyCode.D)) {
             Move(Vector3.right);
         }
         if (Input.GetKey(KeyCode.W)) {
             Move(Vector3.forward);
         }
         if (Input.GetKey(KeyCode.S)) {
             Move(Vector3.back);
         }
     }
     
     void Move(Vector3 direction)
     {
         var newDirection = Quaternion.LookRotation(transform.position - transform.position).eulerAngles;
         newDirection.x = 0;
         newDirection.z = 0;
         DirectionObject.transform.rotation = Quaternion.Euler(newDirection);
         transform.Translate(-direction * Time.deltaTime * movementSpeed, DirectionObject.transform);
 
         Quaternion newRotation = Quaternion.LookRotation(-direction);
         transform.rotation = Quaternion.Slerp(transform.rotation, newRotation * DirectionObject.transform.rotation, Time.deltaTime * 8);
     }
 }
