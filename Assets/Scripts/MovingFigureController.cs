using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFigureController : MonoBehaviour
{
    public GameObject figure;
    public float spawnRate = 2;
    private float timer = 0;
    public float offset = 1;
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
        float highOffset = transform.position.y + offset;
        float lowOffset = transform.position.y - offset;

        Instantiate(figure, new Vector3(transform.position.x, Random.Range(highOffset, lowOffset), 0), transform.rotation);

    }
}
 