using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 3.0f;
    public float damage = 20f;
    
    void Update() 
    { 
        transform.Translate(0, 0, speed * Time.deltaTime); 
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision != null)
        {
            //проверить, что столкнулись с игроком и нанести ему урон
            Character charater = collision.gameObject.GetComponent<Character>();
            if (charater != null)
            {
                charater.GetDamage(damage);
            }
            Destroy(this.gameObject);
        }
    }
    
}
