using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject scoreCounter;
    public GameObject finalScore;
    public AudioClip lostSFX;

    bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null && !gameOver)
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
            scoreCounter.SetActive(false);
            finalScore.SetActive(true);
            AudioSource.PlayClipAtPoint(lostSFX, Camera.main.transform.position);
            Camera.main.GetComponent<AudioSource>().pitch = .9f;
        }
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
