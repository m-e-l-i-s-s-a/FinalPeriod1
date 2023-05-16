using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleToGame : MonoBehaviour
{
    private Button startButton;

    void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(startGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startGame()
    {
        Debug.Log(gameObject.name + "was clicked");
        SceneManager.LoadScene("StarterHouse", LoadSceneMode.Additive);
        startButton.gameObject.SetActive(false);
    }
}
