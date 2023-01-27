using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MovingFigure
{
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    public override void Update()
    {
        move();
        //hago lo que sea particular a la clase PipeScript
    }


    // Update is called once per frame
}
