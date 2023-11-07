using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateObstacle : MonoBehaviour
{
    public List<GameObject> obstacles; //Spawn Olacak nesnelerin listesi.
    private float border = 6.53f; //Nesnelerin olu�abilece�i alanlan

    //�ki nesne olarak s�rekli farkl� konumlarda ��kacaklar ve bu iki nesne de�i�erek ��kacak. Unutma.
    private GameObject obstacle1;
    private GameObject obstacle2;

    private Vector2 obstacle1Pos;
    private Vector2 obstacle2Pos;

    private float timer = 0;

    private void Start()
    {
        SpawnNewObstacle(0, 1, 5, 6); //Listedeki 0. ve 1. eleman� alacak.
    }

    void SpawnNewObstacle(int numberobstacle1, int numberobstacle2, int min, int max)
    {
        //X ekseninde random bir noktada olu�mas� i�in.
        float rndX1 = Random.Range(border, -1 * border);
        float rndX2 = Random.Range(border, -1 * border);

        //Z ekseninin belirlenmesi i�in.
        float rndZ1 = Random.Range(-10, -30);

        if (rndX1 == rndX2) //Ayn� noktada birden fazla obje olu�mamas� i�in.
        {
            rndX2 = Random.Range(border, -1 * border);
        }
        obstacle1Pos = new Vector3(rndX1, 0, rndZ1);
        obstacle2Pos = new Vector3(rndX2, 0, rndZ1 * 2); //Farkl� olmas� i�in 2 ile �arpt�m. Z ekseni �nemli de�il karaktere yakla�aca�� i�in.

        obstacle1 = obstacles[numberobstacle1]; //Listeden al�yor
        obstacle2 = obstacles[numberobstacle2];

        Instantiate(obstacle1, obstacle1Pos, Quaternion.identity);
        Instantiate(obstacle2, obstacle2Pos, Quaternion.identity);

        ChangeObstacle(min, max); //Daha sonras hep ayn� objeler ��kmamas� i�in listedeki eleman say�s� aral�g�nda de�er vererek random iki nesne daha olu�mas�n�� sa�layaca��m.
    }
    void ChangeObstacle(int min, int max)
    {
        //Engelleri de�i�tir.
    }
}
