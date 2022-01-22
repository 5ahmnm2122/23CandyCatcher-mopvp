using UnityEngine;

[CreateAssetMenu(fileName = "gameVariables", menuName = "MyGame/Scripts/GameData", order = 1)]
public class gameVariables : ScriptableObject
{
    public string playerName;
    public int score;
}

