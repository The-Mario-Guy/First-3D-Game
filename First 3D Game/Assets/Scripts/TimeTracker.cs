using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeTracker : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 0;
    [SerializeField] TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        /*if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }*/

    }
}
