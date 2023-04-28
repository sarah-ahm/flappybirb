using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < -100)
        {
            isAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}
