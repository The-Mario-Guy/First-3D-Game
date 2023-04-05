using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRun : MonoBehaviour
{
    // Start is called before the first frame update
    public float _autoSpeed = 20;
    private Rigidbody luigiRigidbody;
    public GameObject luigi;
    void Start()
    {
        luigiRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float zValue = Input.GetAxis("Vertical") * 10 *Time.deltaTime;
        float xValue = Input.GetAxis("Horizontal") * 10 *Time.deltaTime;
        transform.Translate(xValue, 0f, zValue);
    }
}
