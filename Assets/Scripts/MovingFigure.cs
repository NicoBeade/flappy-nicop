using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingFigure: MonoBehaviour {
    

    public float moveSpeed = 5;
    private float deadZone = -12;

    public void move() {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    public void cleanScreen() {
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
    public virtual void Update() { 
        move();
        cleanScreen();
    }
    
}

