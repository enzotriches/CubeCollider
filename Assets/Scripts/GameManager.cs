using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool isEnded = false;
    public float time = 1f;
    public GameObject gameComplete;

    public void GameWon()
    {
        gameComplete.SetActive(true);
    }

	public void GameOver()
    {
        if (!isEnded)
        {
            isEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", time);


        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
