using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //chomper is the enemy
    private float speed = 2f;

    private Vector3 baseLocation = new Vector3 (0f, 7.50f, 0f);//coords from where enemy starts
    //randomy spawn from different spawn locations, make a list from them, like the hang man one
    //choose from different speeds

    // Start is called before the first frame update
    void Start()
    {
        transform.position = baseLocation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(4.0f * Time.deltaTime * Vector3.down); 

        if(transform.position.y < -5f) //see if theis coord is correct
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
        }
    }
}
