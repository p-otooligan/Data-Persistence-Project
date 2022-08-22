using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string player;
    public int score;
    public TextMeshProUGUI BestScoreText;

    public void Start()
    {
        MainManager.LoadTopScore();
        player = MainManager.playerName;
        Debug.Log(player);
        score = MainManager.bestScore;
        Debug.Log(score);
        BestScoreText.text = "Best Score: " + player + " - " + MainManager.bestScore;

    }

    //[SerializeField] TextMeshProUGUI PlayerNameInput;
    // Start is called before the first frame update

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        

    }

    public void Exit()
    {
    
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
