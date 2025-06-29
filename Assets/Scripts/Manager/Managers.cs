using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioManager))]

public class Managers : MonoBehaviour
{
    public static AudioManager AudioManager { get; set; }

    void Awake()
    {
        AudioManager = GetComponent<AudioManager>();

    }


}
