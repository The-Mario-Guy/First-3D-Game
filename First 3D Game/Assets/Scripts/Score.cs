using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    float star = 0;
    public TextMeshProUGUI StarText;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            star++;
            StarText.text = star.ToString("0");
        }    
    }
}