using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float HP = 100f;
    private bool isDead = false;

    void Update()
    {
        GetDamage(10 * Time.deltaTime);
    }

    public void GetDamage(float damage)
    {
        if (isDead) return;
        HP -= damage;
        if (HP <= 0)
        {
            isDead = true;
            HP = 0;
            Debug.Log("Character is dead");
            Destroy(gameObject);
            Invoke("DestroyCharacter", 0.1f);
        }
    }
}
