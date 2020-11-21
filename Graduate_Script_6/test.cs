using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{   
    // Start is called before the first frame update
    public float xMin;
    public float zMin;
    public float xMax;
    public float zMax;

    static float randX;
    static float randZ;
    static Vector3 target;

    void Start()
    {
        InvokeRepeating("move_rand", 1, 3);
    }

    void move_rand()
    {
        randX = Random.Range(xMin, xMax);
        randZ = Random.Range(zMin, zMax);
        target = new Vector3(randX, 0, randZ);
    }

    void Update()
    {
        this.transform.Translate(target);
        transform.LookAt(target);
    }
}
