using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 3.0f;
    public int damage = 1;
    
    void Update() 
    { 
        transform.Translate(0, 0, speed * Time.deltaTime); 
    }
    
    void OnTriggerEnter(Collider other)
    {
        Character player = other.GetComponent <Character>();
        if (player != null)
        { 
            player.GetDamage(damage);
            Debug.Log("Player hit"); 
        }
        Destroy(this.gameObject);
    }
}
