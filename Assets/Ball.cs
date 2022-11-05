using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] // exposes private variables in the inspector
    public int speed;
    public int speedValue
{
    get { return speed; } // getter returns backing field
    set { speed = value; } // setter uses backing field
}
    // Start is called before the first frame update
    void Start()
    {
        speedValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        changePositionLeft();
    }

     public void changePositionLeft() {
        if(Input.GetMouseButtonDown(1)) {
            transform.Translate(Vector3.left * Time.deltaTime * speed); 
        }
        jump();
    }

    public virtual void jump () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.Translate(Vector3.up * 10 * Time.deltaTime * speed);
        }
    }
}
