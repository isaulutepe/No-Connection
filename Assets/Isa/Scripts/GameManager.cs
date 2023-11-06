using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isDead = false;
    private float waitTime = 3.0f;
    //Oyun baþlamadan önce 3 saniye geri sayým olacak ve buradan yönetilecek.

    //Aktifliklerini kapatacaðým scriplere eriþmek için bu scriplerin kullanýldýgý objeleri bulunmalý.
    private GameObject playerObject; //Move Scripti için..

    private void Start()
    {
        playerObject = GameObject.Find("Player");
        StartCoroutine(StartGameCountdown());
    }
    private void Update()
    {

    }
    IEnumerator StartGameCountdown()
    {
        EnableControls(false); // Kontrolleri kapat
        for (int i = 3; i > 0; i--)
        {
            Debug.Log("Geri sayým: " + i); //Bu Canvasta yazýlacak þimdilik böyle kontrol için.
            yield return new WaitForSeconds(1.0f); // Her saniye bir azalt.
        }

        Debug.Log("Geri sayým tamamlandý. Kontroller açýlýyor.");
        EnableControls(true); // Kontrolleri aç
    }

    private void EnableControls(bool isEnabled)
    {
        // Move ve CamFallow komponentlerinin etkinliðini ayarla
        playerObject.GetComponent<Move>().enabled = isEnabled;
    }
}
