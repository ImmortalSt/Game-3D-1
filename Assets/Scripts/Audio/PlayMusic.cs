using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    [SerializeField] private AudioClip music1;

    private void Start()
    {
        Managers.AudioManager.PlayMusic(music1);
    }

}
