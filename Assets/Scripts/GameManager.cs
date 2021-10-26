using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool gameActive;
    [SerializeField] private bool pipeMotionActive;
    [SerializeField] private bool firstJump;
    public int scoreCounter;
    [SerializeField] private GameObject startingCanvas;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject scoreCounterCanvas;


    // Start is called before the first frame update
    void Start()
    {
        gameActive = false;
        pipeMotionActive = false;
        firstJump = false;
        startingCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        scoreCounterCanvas.SetActive(false);
        scoreCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // change value of UI text
        scoreCounterCanvas.GetComponent<UnityEngine.UI.Text>().text = scoreCounter.ToString();
    }

    public void GameOver()
    {
        gameActive = false;
        pipeMotionActive = false;
        firstJump = false;

        // show canvas for game over
        gameOverCanvas.SetActive(true);
    }

    public void GameStart()
    {
        scoreCounter = 0;
        gameActive = true;
        gameOverCanvas.SetActive(false);
        startingCanvas.SetActive(false);
        scoreCounterCanvas.SetActive(true);
    }

    public void SetPipeMotion(bool state)
    {
        pipeMotionActive = state;
    }

    public void SetFirstJump(bool state)
    {
        firstJump = state;
    }

    public bool GetFirstJump()
    {
        return firstJump;
    }

    public bool GetGameActive()
    {
        return gameActive;
    }

    public bool GetPipeMotion()
    {
        return pipeMotionActive;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        GameStart();
    }
}
