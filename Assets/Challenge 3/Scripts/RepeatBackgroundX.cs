using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth = 56.4f;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


