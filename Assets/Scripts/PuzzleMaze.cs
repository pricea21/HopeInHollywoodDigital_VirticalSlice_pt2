using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleMaze : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("PuzzleMaze");
    }

    public void PlatformJumper()
    {
        SceneManager.LoadScene("PlatformJumper");
    }

    public void PaparazziFlash()
    {
        SceneManager.LoadScene("PaparazziFlash");
    }

    public void Jeopardy()
    {
        SceneManager.LoadScene("Jeopardy");
    }

    public void SlidingPuzzle()
    {
        SceneManager.LoadScene("SlidingPuzzle");
    }
}
