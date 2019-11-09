using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text coinText;
    public Canvas winCanvas;
    public Canvas loseCanvas;

    public int coins = 0;
    public int coinsToWin = 12;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetCoinText();
    }

    void Update()
    {
        if (coins == coinsToWin)
        {
            winCanvas.gameObject.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SetCoinText()
    {
        coinText.text = "Score: " + coins;
    }

    public void SetLoseCanvas()
    {
        loseCanvas.gameObject.SetActive(true);
    }
}
