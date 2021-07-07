using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPrediction : MonoBehaviour
{
    int max = 1501;
    int min = 1;
    int tahmin = 750;
    // Start is called before the first frame update
    void Start()
    {
        

        Debug.Log("sayı tahmin oyunu baslıyor....");
        Debug.Log("bir sayı tut");
        Debug.Log("tuttuğun sayı"+ max + "ü gecmesin");
        Debug.Log("tuttuğun sayı"+ min + "den asagı olmasın");
        Debug.Log("tuttuğun sayı"+ tahmin + "mi?");
        Debug.Log("yukarı bas = yükselt, asagı bas = azalt, enter a bas = dogru");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow));
        {
            min = tahmin;
            tahmin= (min+max) / 2;
            Debug.Log("Tahminim:"+ tahmin +"yükseltiyim mi alcaltıyım mı?");
        }
        else if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            max = tahmin;
            tahmin= (min+max) / 2;

            Debug.Log("Tahminim:"+ tahmin +"yükseltiyim mi alcaltıyım mı?");
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ben kazandım");
        }
    }
}
