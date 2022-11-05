using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChild : Ball
{
  
    void Start()
    {
          speedValue = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up arrow from child");
        }

        changePositionLeft();
        jump();
    }

    public override void jump() {
if (Input.GetKeyDown(KeyCode.Space)) {
            transform.Translate(Vector3.up * 20 * Time.deltaTime * speed);
        }
    }
    
}
