using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    private int shot;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(12.0f * Time.deltaTime * Vector3.up); //this shoots upwards
    }

  
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Chomper")
        {
            //Debug.Log("HI THIT HIT");
            shot= shot+1;
            Debug.Log(shot);

        }

    }

    public int GetShot()
    {
        return shot;
    }

}
