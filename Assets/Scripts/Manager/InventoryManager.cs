using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    private int money = 0;      //money
    private int countOpp = 0;   //opponent
    private float damage = 30f;
    public Character character;

    public TMP_Text moneyText;
    public TMP_Text countOpponentText;

    private void Start()
    {
        Messenger.AddListener(GameEvents.ColletableItem, Increase);

    }

    //noney
    public void Increase()
    {
        money++;
        UpdateUI();
        Debug.Log($"Count: {money}");
    }

    //count opponent
    public void DestroyOpponent()
    {
        countOpp++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: " + money;
        }
        else
        {
            Debug.LogError("moneyText is not assigned in the inspector!");
        }

        if (countOpponentText != null)
        {
            countOpponentText.text = "Count: " + countOpp;
        }
        else
        {
            Debug.LogError("countOpponentText is not assigned in the inspector!");
        }
    }
}
