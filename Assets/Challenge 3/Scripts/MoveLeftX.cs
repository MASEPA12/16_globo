using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float leftBound = -10;

    void Start()
    {
        playerControllerScript = FindObjectOfType<PlayerControllerX>();
    }

    void Update()
    {
        // If game is not over, move to the left
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background (is the bomb or the money), destroy it
        if (transform.position.x < leftBound && (gameObject.CompareTag("Money") || gameObject.CompareTag("Bomb")))
        {
            Destroy(gameObject);
        }

    }
}
