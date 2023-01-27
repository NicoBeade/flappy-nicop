using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFigureController : MonoBehaviour
{
    public GameObject figure;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawn();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate)
        {
            spawn();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    void spawn() {

        Instantiate(figure, transform.position, transform.rotation);

    }
}
