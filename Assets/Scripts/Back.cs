using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GoBackToMap()
    {
        SceneManager.LoadScene("Map");
    }
}
