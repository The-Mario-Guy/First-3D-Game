using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.tag = "Hit";
            //GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
