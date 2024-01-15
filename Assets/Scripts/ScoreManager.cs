using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int ScoreValue = 0;
    public string text = "Score : 0";
    public void UpdateScore(int value)
    {
        ScoreValue = ScoreValue + value;
    }

    // Update is called once per frame    
    void Update()
    {
        GameObject.Find("ScoreText").GetComponent<ScoreManager>().text = "Score : " + ScoreValue;
        // Update the attached text component with the current score
        gameObject.GetComponent<Text>().text = "Score: " + ScoreValue;
    }
}
