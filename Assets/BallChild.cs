using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChild : Ball
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up arrow from child");
        }

        changePosition();
    }
    
}
