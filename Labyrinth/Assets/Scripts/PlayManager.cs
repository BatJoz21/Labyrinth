using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] TMP_Text scoreText;

    int coinValue = 0;

    private void Update()
    {
        scoreText.text = coinValue.ToString();
    }

    public int CoinValue { get => coinValue; set => coinValue = value; }

    public void GameOver()
    {
        finishedText.text = "You Failed!!!";
        finishedCanvas.SetActive(true);
    }

    public void PlayerWin()
    {
        finishedText.text = "You Win!!!\n Score = " + coinValue;
        finishedCanvas.SetActive(true);
    }
}
