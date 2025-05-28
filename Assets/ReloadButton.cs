using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(UnityEngine.UI.Button))]

public class ReloadButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if (Input.GetKeyDown(KeyCode.H))
        //{
        //    ReloadGame();
        //}
        //else
        //{
            Button button = GetComponent<Button>();
            button.onClick.AddListener(ReloadGame);
        //}
    }

    private void ReloadGame()
        => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    
}
