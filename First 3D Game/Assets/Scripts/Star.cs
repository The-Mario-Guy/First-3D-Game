using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    float star = 0;
    private Rigidbody RB;
    public TextMeshProUGUI StarText;
    public GameObject Player;
    private MeshRenderer _renderer;
    
    void Start()
    {
       RB = GetComponent<Rigidbody>();
       Player = GetComponent<GameObject>();
       _renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Star")
        {
            star++;
            StarText.text = star.ToString("0");
        }    
    }
}
