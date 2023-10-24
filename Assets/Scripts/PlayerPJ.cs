using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPJ : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 5;
    public bool onGroud;
    public Text youWin;
    public GameObject instructionsUI;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.firstTime)
        {
            instructionsUI.SetActive(true);
            Time.timeScale = 0f;
            GameManager.firstTime = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && onGroud)
        {
            rb.velocity = rb.velocity + Vector2.up * 4;
            onGroud = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Platform"))
        {
            onGroud = true;
        }

        if (collision.gameObject.tag == ("Enemy") || collision.gameObject.tag == ("Edge"))
        {
            instructionsUI.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.tag == ("BackDoor"))
        {
            youWin.text = "YOU WIN!!!";
            GameManager.instance.SetMinigameComplete("Platform Jumper");
            SceneManager.LoadScene("Map");
        }
    }
}
