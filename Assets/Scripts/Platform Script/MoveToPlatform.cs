using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class MoveToPlatform : MonoBehaviour
{
    private float distance;

    private float moveSpeed = 5f;
    private bool isDead = false; //GameManager içinden kontrol edilecek þimdiilk eklendi.

    private void Start()
    {
        if (gameObject.CompareTag("Ground"))
        {
          distance= transform.localScale.z;
        }
    }
    private void Update()
    {

        if (isDead == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - moveSpeed *Time.deltaTime);
        }

        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.z <= -distance)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2 * distance);
            }
        }
    }

}
