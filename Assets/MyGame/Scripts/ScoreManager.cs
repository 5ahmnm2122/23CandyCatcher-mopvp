using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public gameVariables data;
    private string scoreStr;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        data.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreStr = data.score.ToString();
        scoreText.text = "Score: " + scoreStr;

    }
}
