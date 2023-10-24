using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPJ : MonoBehaviour
{
    public float timer;
    public GameObject enemy;
    public GameObject enemyClone;
    // Start is called before the first frame update
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.0)
        {
            enemyClone = Instantiate(enemy, new Vector3(UnityEngine.Random.Range(-5.0f, 0.0f), 3.5f, 0), transform.rotation) as GameObject;
            timer = 0;
        }
    }
}
