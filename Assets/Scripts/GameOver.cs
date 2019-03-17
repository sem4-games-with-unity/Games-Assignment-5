using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Your final score is: " + PlayerStats.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
