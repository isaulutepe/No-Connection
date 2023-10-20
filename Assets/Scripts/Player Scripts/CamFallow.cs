using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CamFallow : MonoBehaviour
{
    private Transform target; //Player
    private Vector3 offSet = new Vector3(0, 3.09f, -10);
    public float moveSpeed = 3f;
    private Move playerMove;
    private void Awake()
    {
        target = GameObject.Find("Player").transform;
    }
    void Start()
    {
        playerMove = target.GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 targetPosition = target.transform.position + offSet;
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (transform.position.x > 0)
        {
            transform.DORotate(new Vector3(7, -18, 0), 1f).SetEase(Ease.InExpo);
            transform.position = Vector3.Lerp(transform.position, new Vector3(4.43f, 5.40f, -55), Time.deltaTime);

        }
        if (transform.position.x < 0)
        {
            
            transform.DORotate(new Vector3(0, 22, 0), 1f).SetEase(Ease.InExpo);
            transform.position = Vector3.Lerp(transform.position, new Vector3(-4.43f, 5.40f, -55), Time.deltaTime);
        }
    }
    void Shake()
    {
        //Bazý nenslere çaptýðýnda sallanma efecti oluþturuacak.
        //DoTween ile 
    }
}


