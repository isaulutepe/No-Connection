using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;
    [SerializeField]
    private float jumpForce = 1.5f;

    //Sa� - Sol s�n�r� almak i�in.
    public float border;

    private GameManager gameManager;

    //Animasyon i�lemleri
    public Animator animators; //Animasyonlar� y�netmek i�in.

    private bool IsGrounded = true; //Karekter yerde



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
            if (Input.GetKey(KeyCode.A) && transform.position.x > -border) //Sol
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < border) //Sa�
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
        }
        if (gameManager.isDead == false && IsGrounded == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                animators.SetBool("IsJump", true);
                IsGrounded = false; //Havada z�plamaya devam etmemeli.
            }
        }
  
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Karakter Zeminde mi ?
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
            animators.SetBool("IsJump", false);
        }
    }
}
