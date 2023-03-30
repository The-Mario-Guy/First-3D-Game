using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _star = 0;
    
    public static GameManager Instance;
    public TextMeshProUGUI StarText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetStars(int amount)
    {
        _star += amount;
    }
    public int GetStarCount()
    {
        return _star;
    }
}
