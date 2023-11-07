using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;
    [SerializeField]
    private float jumpForce = 1.5f;

    //Sað - Sol sýnýrý almak için.
    public float border;

    private GameManager gameManager;

    //Animasyon iþlemleri
    public Animator animators; //Animasyonlarý yönetmek için.

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
            if (Input.GetKey(KeyCode.D) && transform.position.x < border) //Sað
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
                IsGrounded = false; //Havada zýplamaya devam etmemeli.
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
