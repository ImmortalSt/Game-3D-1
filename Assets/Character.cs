using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public float HP = 100f;
    private bool isDead = false;
    public GameObject gameOverPanel;
    public GameObject Camera;
        
    private IEnumerator Die()
    {
        if (GetComponent<WanderingAI>() is WanderingAI ai)
            ai.enabled = false;
                
        this.transform.Rotate(-75, 0, 0); 
        yield return new WaitForSeconds(1.5f);
        if (Camera != null)
        {
            Camera.transform.parent = null;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        // ����������� ������� ������������ ������
        if (Managers.InventoryManager != null)
        {
            Managers.InventoryManager.DestroyOpponent();
        }

        Destroy(this.gameObject);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;


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
            if(gameOverPanel != null)
                gameOverPanel.SetActive(true);

            StartCoroutine(Die());
        }
    }

    public void RestoreHP(float amount)
    {
        if (HP < 100)
        {
            HP += amount;
            Debug.Log("HP restored. Current HP: " + HP);
        }
        else if (HP == 100) 
        {
            Debug.Log("HP not restored. Current HP: " + HP);
        }
    }
}
