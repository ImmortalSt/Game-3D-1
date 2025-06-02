using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mina : MonoBehaviour
{
    public float damage = 100f; 

    private void OnTriggerEnter(Collider collision)
    {
        if (collision != null)
        {
            Character character = collision.gameObject.GetComponent<Character>();
            if (character != null)
            {
                character.GetDamage(damage);
                Destroy(this.gameObject); 
            }
        }
    }
}
