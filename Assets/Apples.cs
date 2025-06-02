using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apples : MonoBehaviour
{
    private void OnTriggerEnter(Collider apple)
    {
        Character character = apple.GetComponent<Character>();
        if (character != null)
        {
            character.RestoreHP(10f); 
            Destroy(this.gameObject); 
        }
        
    }  
}
