using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public TextMeshProUGUI winingText;
    public TextMeshProUGUI losingText;
    public TextMeshProUGUI endScoreText;
    public GameObject winingScreen;
    public GameObject losingScreen;
    private string scoreString;
    public gameVariables data;
    public int winingCondition = 20;

    // Start is called before the first frame update
    void Start()
    {
        winingText.text = "Herzlichen Glückwunsch " + data.playerName + " du hast es geschafft!";
        losingText.text = "Schade " + data.playerName + " versuch es noch einmal!";

        if (data.score > winingCondition)
        {
            winingScreen.SetActive(true);
        }
        else
        {
            losingScreen.SetActive(true);
        }
        scoreString = data.score.ToString();
        endScoreText.text = "Punktestand: " + scoreString;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
