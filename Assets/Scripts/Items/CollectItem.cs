using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private Coroutine destroyCoroutine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Увеличить счет
            //Managers.InventoryManager.Increase();
            Messenger.Broadcast(GameEvents.ColletableItem);

            if (destroyCoroutine == null)
                destroyCoroutine = StartCoroutine(Destroy());
        }
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        destroyCoroutine = null;
    }
}

