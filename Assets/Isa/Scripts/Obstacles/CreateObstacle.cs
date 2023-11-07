using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreateObstacle : MonoBehaviour
{
    public List<GameObject> obstacles; //Spawn Olacak nesnelerin listesi.
    private float border = 6.53f; //Nesnelerin oluþabileceði alanlan

    //Ýki nesne olarak sürekli farklý konumlarda çýkacaklar ve bu iki nesne deðiþerek çýkacak. Unutma.
    private GameObject obstacle1;
    private GameObject obstacle2;

    private Vector2 obstacle1Pos;
    private Vector2 obstacle2Pos;

    private float timer = 0;

    private void Start()
    {
        SpawnNewObstacle(0, 1, 5, 6); //Listedeki 0. ve 1. elemaný alacak.
    }

    void SpawnNewObstacle(int numberobstacle1, int numberobstacle2, int min, int max)
    {
        //X ekseninde random bir noktada oluþmasý için.
        float rndX1 = Random.Range(border, -1 * border);
        float rndX2 = Random.Range(border, -1 * border);

        //Z ekseninin belirlenmesi için.
        float rndZ1 = Random.Range(-10, -30);

        if (rndX1 == rndX2) //Ayný noktada birden fazla obje oluþmamasý için.
        {
            rndX2 = Random.Range(border, -1 * border);
        }
        obstacle1Pos = new Vector3(rndX1, 0, rndZ1);
        obstacle2Pos = new Vector3(rndX2, 0, rndZ1 * 2); //Farklý olmasý için 2 ile çarptým. Z ekseni önemli deðil karaktere yaklaþacaðý için.

        obstacle1 = obstacles[numberobstacle1]; //Listeden alýyor
        obstacle2 = obstacles[numberobstacle2];

        Instantiate(obstacle1, obstacle1Pos, Quaternion.identity);
        Instantiate(obstacle2, obstacle2Pos, Quaternion.identity);

        ChangeObstacle(min, max); //Daha sonras hep ayný objeler çýkmamasý için listedeki eleman sayýsý aralýgýnda deðer vererek random iki nesne daha oluþmasýnýý saðlayacaðým.
    }
    void ChangeObstacle(int min, int max)
    {
        //Engelleri deðiþtir.
    }
}
