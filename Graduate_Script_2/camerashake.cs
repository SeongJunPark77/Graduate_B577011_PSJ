using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    public float shakes = 0f;

    public float shakeAmount = 0.06f;

    public float decreaseFactor = 3f;

    public Vector3 originalPos;

    public static bool CameraShaking;



    void Start()

    {


        CameraShaking = false;

    }

    public void ShakeCamera(float shaking)

    {

        shakes = shaking;
        

        CameraShaking = true;

    }



    void Update()

    {

        originalPos = this.transform.position;

        if (CameraShaking)
        {
            if (shakes > 0)

            {
                this.transform.position = originalPos + Random.insideUnitSphere * shakeAmount;

                //gameObject.transform.position += new Vector3(0f, 0f, -50f);


                shakes -= Time.deltaTime * decreaseFactor;

            }

            else

            {

                shakes = 0f;

                CameraShaking = false;

            }





        }



    }
}
