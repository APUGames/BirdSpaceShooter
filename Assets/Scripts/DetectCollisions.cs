using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    [SerializeField] Camera cineCam;
    public static bool stopCam = false;
    private void OnTriggerEnter(Collider other)
    {

       // Destroy(gameObject);
      //  Destroy(other.gameObject);

    }

    void Update()
    {

        if (stopCam)
        {
            cineCam.enabled = false;
        }
        else
        {
            cineCam.enabled = true;
        }
    }
}
