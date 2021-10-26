using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameManager gm;
    public float pipeSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.GetPipeMotion() == true)
        {
            transform.position += Vector3.left * pipeSpeed;
        }

    }
}
