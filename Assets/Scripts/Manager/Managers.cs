using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioManager))]
[RequireComponent(typeof(InventoryManager))]

public class Managers : MonoBehaviour
{
    public static AudioManager AudioManager { get; set; }
    public static InventoryManager InventoryManager { get; set; }
    
    void Awake()
    {
        AudioManager = GetComponent<AudioManager>();
        InventoryManager = GetComponent<InventoryManager>();
    }
}
