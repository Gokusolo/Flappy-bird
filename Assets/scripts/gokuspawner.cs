using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gokuspawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject goku;
    public float height;
    void Start()
    {
        GameObject newgoku = Instantiate(goku);
        newgoku.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newgoku = Instantiate(goku);
            newgoku.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newgoku, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
