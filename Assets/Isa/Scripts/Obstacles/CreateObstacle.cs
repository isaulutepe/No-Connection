using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public List<GameObject> obstacles; //Spawn Olacak nesnelerin listesi.
    private float border = 6.53f; //Nesnelerin oluþabileceði alanlan

    //Ýki nesne olarak sürekli farklý konumlarda çýkacaklar ve bu iki nesne deðiþerek çýkacak. Unutma.
    private GameObject obstacle1;
    private GameObject obstacle2;

    private Vector2 obstacle1Pos;
    private Vector2 obstacle2Pos;

    private void Start()
    {

    }

    void SpawnNewObstacle(int numberobstacle1, int numberobstacle2, int min, int max)
    {

        obstacle1Pos = new Vector2(2.4f, -1);
        obstacle2Pos = new Vector2(2.4f, -6f);

        obstacle1 = obstacles[numberobstacle1];
        obstacle2 = obstacles[numberobstacle2];

        Instantiate(obstacle1, obstacle1Pos, Quaternion.identity);
        Instantiate(obstacle2, obstacle2Pos, Quaternion.identity);

        ChangeObstacle(min, max);
    }
    void ChangeObstacle(int min, int max)
    {
         //Engelleri deðiþtir.
    }
}
