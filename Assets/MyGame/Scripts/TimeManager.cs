using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float remainingTime = 10;
    public bool timerIsRunning = false;
    private string timerString;
    public TextMeshProUGUI timerText;
    private int remainingTimeInt;


    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else
            {
                remainingTime = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("EndScreen");
            }
        }

        remainingTimeInt = (int)remainingTime;
        timerString = remainingTimeInt.ToString();
        timerText.text = "Time: " + timerString;

    }
}