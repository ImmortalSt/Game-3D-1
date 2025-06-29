using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBaner : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // —сылка на текстовый элемент 

    private int score;

    void Start()
    {
        scoreText.text = "Score: ";
        
    }   

    

}
