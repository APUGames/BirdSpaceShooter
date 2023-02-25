using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This component will handle player action and state
    public int health = 100;
    public float speed = 1.0f;
    public GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.up);

        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, 5, 0f);
        }
        else if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, -5, 0f);
        }
        if (transform.position.x > 12)
        {
            transform.position = new Vector3(12, transform.position.y, 0f);
        }
        else if (transform.position.x < -12)
        {
            transform.position = new Vector3(-12, transform.position.y, 0f);
        }

        if (Input.GetButtonDown("Fire1"))
        {
           Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }

    }
}
