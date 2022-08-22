using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class DataHandler : MonoBehaviour
{
    public static DataHandler textName;
    public TMP_InputField inputField;
    //public MainManager mainManager;

    public string playerName;
    

    private void Awake()
    {
        MainManager.LoadTopScore();
        if (textName != null)
        {
            Destroy(gameObject);

        }
        else
        {
            textName = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetPlayerName()
    {
        playerName = inputField.text;
    }

   
}
