using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mprespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mpboxx;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnitem", 5,4); //1초에 1번씩 Spawnitem()를 호출한다.
    }

    void Spawnitem()
    {
        float randomX = Random.Range(-21f, 30f);
        float randomZ = Random.Range(-25f, 17f);
        if (true)
        {
            GameObject mpboxa = (GameObject)Instantiate(mpboxx, new Vector3(randomX, 0f, randomZ), Quaternion.identity);

            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
