using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Objects : MonoBehaviour
{
     float hiddenhealth = 3f;
    public TextMeshProUGUI healthText;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.tag = "Hit";
            //GetComponent<MeshRenderer>().material.color = Color.red;
            hiddenhealth--;
            healthText.text = hiddenhealth.ToString();
        }
        if (hiddenhealth <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

}
