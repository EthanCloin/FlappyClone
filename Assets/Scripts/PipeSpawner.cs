using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    public GameManager gm;
    public bool spawningPipes;
    public float positionVariance = 1.0f;
    [SerializeField] private float spawnDelay = 1.5f;
    private float timer = 0;



    // Start is called before the first frame update
    void Start()
    {
        spawningPipes = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Keep running timer
        timer += Time.deltaTime;

        // Check with GM if pipes should be spawning
        if (gm.GetFirstJump() && gm.GetPipeMotion())
        {
            spawningPipes = true;
        }
        else
        {
            spawningPipes = false;
        }

        // Behavior to spawn pipes
        if (spawningPipes)
        {
            if (timer >= spawnDelay)
            {
                // spawn a pipe
                GameObject newPipe = Instantiate(pipePrefab);
                newPipe.GetComponent<Pipe>().gm = gm;
                newPipe.transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y + Random.Range(-positionVariance, positionVariance),
                    transform.position.z
                    );
                Destroy(newPipe, 5.0f);

                // reset timer
                timer = 0;

            }

        }
        
    }
}
