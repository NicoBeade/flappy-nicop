using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingFigure: MonoBehaviour {
    

    public float moveSpeed = 5;

    public void move() {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    public virtual void Update()
    {
        move();
    }
    
}

