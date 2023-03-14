using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // This component will handle player action and state
    [Header("Attributes")]
    [SerializeField]
    private int health;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float laserSpawnOffset;


    [Header("Player UI")]
    [SerializeField]
    private GameObject healthText;


    public GameObject laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
        healthText.GetComponent<Text>().text = health.ToString();
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
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(9, transform.position.y, 0f);
        }
        else if (transform.position.x < -9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0f);
        }

        if (Input.GetButtonDown("Fire2"))//change this to the right click
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }

        UpdateUI();

        if (health <= 0)
        {
            Destroy(gameObject);
            SessionHandler.gameOver = true;
        }

        //add the ui score update
    }

    private void UpdateUI()
    {
        healthText.GetComponent<Text>().text = health.ToString();
        //hitText.GetComponent<Text>().text = score.ToString();

    }
    public void EnemyDamage()
    {
        if (health >= 1)
        {
            health -= 1;
        }

    }

    public int GetHealth()
    {
        return health;
    }



}
