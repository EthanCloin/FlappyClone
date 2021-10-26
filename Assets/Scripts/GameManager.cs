using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool gameActive;
    [SerializeField] private bool pipeMotionActive;
    [SerializeField] private bool firstJump;
    // Start is called before the first frame update
    void Start()
    {
        gameActive = false;
        pipeMotionActive = false;
        firstJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameActive = false;
        pipeMotionActive = false;
        firstJump = false;

        // show canvas for game over
    }

    public void GameStart()
    {
        gameActive = true;
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
}
