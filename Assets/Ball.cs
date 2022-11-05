using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changePosition();
    }

     public void changePosition() {
        if(Input.GetMouseButtonDown(1)) {
            transform.Translate(Vector3.left * Time.deltaTime * speed); 
        }
    }
}
