using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float num;
    public LogicScript script;
    public bool birdIsAlive = true;
    bool isNodding = false;
    

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidbody.angularDrag = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isNodding && (myRigidbody.rotation >= 30.0f))
        {
            myRigidbody.angularVelocity = 3.0f * -num;
            isNodding = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * num;
            myRigidbody.angularVelocity = 5.0f * num;
            isNodding = true;

        }
        if (transform.position.y < -30 || transform.position.y > 30)
        {
            Destroy(gameObject);
            script.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        script.gameOver();
        birdIsAlive = false;
    }
}
