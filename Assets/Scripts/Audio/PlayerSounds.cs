using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField] private AudioClip hitAudioClip;

    private void Start()
    {
        Messenger.AddListener(GameEvents.PlayerAttacking, PlaySound);
    }

    private void PlaySound()
    {
        Managers.AudioManager.PlaySound(hitAudioClip);
    }
}
