using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBaner : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // ������ �� ��������� ������� 

    private int score;

    void Start()
    {
        scoreText.text = "Score: ";
        
    }   

    

}
