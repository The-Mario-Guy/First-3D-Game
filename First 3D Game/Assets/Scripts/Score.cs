using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scorer : MonoBehaviour
{
    [SerializeField] private int _star = 0;
    public TextMeshProUGUI StarText;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            _star++;
            StarText.text = GameManager.Instance.GetStarCount().ToString();
        }    
    }
}