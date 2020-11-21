using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godrespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject godboxx;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnitem", 5, 2); //14초에 1번씩 Spawnitem()를 호출한다.
    }

    void Spawnitem()
    {
        float randomX = Random.Range(-21f, 30f);
        float randomZ = Random.Range(-25f, 17f);
        if (true)
        {
            GameObject godboxa = (GameObject)Instantiate(godboxx, new Vector3(randomX, 0f, randomZ), Quaternion.identity);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
