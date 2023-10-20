using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float moveSpeed = 2f;
    public float border;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Start()
    {
        border = 6.53f;
    }
    void Update()
    {
        if (gameManager.isDead == false)
        {
            if (Input.GetKey(KeyCode.A) && transform.position.x > -border)
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < border)
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
        }
    }
}
