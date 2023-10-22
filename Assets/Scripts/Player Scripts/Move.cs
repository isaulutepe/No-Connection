using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;
    
    //Sað - Sol sýnýrý almak için.
    public float border;

    private GameManager gameManager;

    //Animasyon iþlemleri
    public Animator animators; //Animasyonlarý yönetmek için.
    private bool leftMove;
    private bool rightMove;
    private bool topMove;
    private bool bottomMove;
    private bool idle;




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
                rightMove= true;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < border) //Sað
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                leftMove= true;
            }
        }
        //CheackAnimations();
    }
    void CheackAnimations()
    {
        if (rightMove == false || leftMove == false)
        {
            idle = true;
        }
        if (idle== true)
        {
            animators.SetBool("run", false);
            animators.SetBool("goIdle", true);
        }
        if (rightMove == true || leftMove == true)
        {
            animators.SetBool("run", true);
        }

    }
}
