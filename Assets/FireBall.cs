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
            Character character = collision.gameObject.GetComponent<Character>();
            Apples apple = collision.GetComponent<Apples>();

            if (character != null)
            {
                character.GetDamage(damage);
            }
            else if (apple != null)
            {
                Destroy(apple.gameObject);
            }

            Destroy(this.gameObject);
        }
    }
    
}
