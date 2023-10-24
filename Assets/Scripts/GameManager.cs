//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Serialization;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public MiniGameStruct[] miniGameStructs;
    public static bool firstTime = true;
    private float overallTimer = 600f;
    private float timeRemaining;
    [SerializeField] private TMPro.TextMeshProUGUI timeText;
    //public TextMeshProUGUI text;
    public enum miniGameCheck
    {
        platformJumper, paparazziFlash, 
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

        timeRemaining = overallTimer;
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        /*if (timeRemaining <= 0 && ReprintList.CheckForWin(completGames != miniGameStructs.Length))
        {
            timeRemaining = 0;
            //SceneManager.LoadScene("EndScene");
        }*/
        timeText.text = $"{(int)timeRemaining / 60}:{(int)timeRemaining % 60:D2}";
    }

    void Start()
    {
        
    }


    public void SetMinigameComplete (string name)
    {
        MiniGameStruct game = miniGameStructs.First(q => q.gameTitle == name);
        game.complete = true;
    }

    [Serializable] public class MiniGameStruct
    {
        [SerializeField] public string gameTitle;
        [SerializeField] public bool complete;

        public override string ToString()
        {
            string newGame = gameTitle;
            if (complete)
                newGame = "<s>" + gameTitle + "</s>";
            return newGame;
        }
    }
}
