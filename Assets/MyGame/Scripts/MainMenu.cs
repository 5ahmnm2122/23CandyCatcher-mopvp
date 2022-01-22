using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI inputText;
    public string playerName;
    public gameVariables data;

    // Start is called before the first frame update
    void Start()
    {
        data.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            data.playerName = inputText.text;
            SceneManager.LoadScene("Game");
        }
    }
}
