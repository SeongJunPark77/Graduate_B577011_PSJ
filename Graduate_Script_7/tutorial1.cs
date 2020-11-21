using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tutorial1 : MonoBehaviour
{

    public GameObject bigbro;



    // Start is called before the first frame update
    void Awake()
    {
        SceneManager.LoadScene("Tuto_sto1", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == bigbro)
        {

            SceneManager.LoadScene("Tuto_sto2", LoadSceneMode.Additive);

            Destroy(bigbro);
        }

    }

}