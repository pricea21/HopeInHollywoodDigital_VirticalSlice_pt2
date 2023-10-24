using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static GameManager;
using UnityEngine.SceneManagement;

public class ReprintList : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        PrintList();
        CheckForWin();
    }

    void PrintList()
    {
        string gameName = "";
        foreach (MiniGameStruct s in GameManager.instance.miniGameStructs)
        {
            gameName = gameName + s.ToString() + "\n";
        }
        text.text = gameName;
    }

    public void CheckForWin()
    {
        int completGames = 0;
        foreach (MiniGameStruct s in GameManager.instance.miniGameStructs)
        {
            if (s.complete)
            {
                completGames++;
            }
        }

        if (completGames == GameManager.instance.miniGameStructs.Length)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
