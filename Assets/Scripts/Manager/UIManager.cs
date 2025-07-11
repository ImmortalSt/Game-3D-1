using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button cliclBtn;
    [SerializeField] private AudioClip music1; 

    void Start()
    {
        cliclBtn.onClick.AddListener(() => Managers.AudioManager.PlayMusic(music1));
    }
}
