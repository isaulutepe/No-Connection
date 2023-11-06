using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isDead = false;
    private float waitTime = 3.0f;
    //Oyun ba�lamadan �nce 3 saniye geri say�m olacak ve buradan y�netilecek.

    //Aktifliklerini kapataca��m scriplere eri�mek i�in bu scriplerin kullan�ld�g� objeleri bulunmal�.
    private GameObject playerObject; //Move Scripti i�in..

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
            Debug.Log("Geri say�m: " + i); //Bu Canvasta yaz�lacak �imdilik b�yle kontrol i�in.
            yield return new WaitForSeconds(1.0f); // Her saniye bir azalt.
        }

        Debug.Log("Geri say�m tamamland�. Kontroller a��l�yor.");
        EnableControls(true); // Kontrolleri a�
    }

    private void EnableControls(bool isEnabled)
    {
        // Move ve CamFallow komponentlerinin etkinli�ini ayarla
        playerObject.GetComponent<Move>().enabled = isEnabled;
    }
}
