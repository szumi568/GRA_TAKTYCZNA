using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using static UnityEditor.PlayerSettings;

public class generacja_kwiatów : MonoBehaviour
{
    [SerializeField ]TEREN teren;
    Kwiaty kwiaty;
    [SerializeField] int szansa;
    public GameObject [] ilość_kwiatów;
    public int kwiaty_ilość;
    [SerializeField] GameObject kwiat1;
    [SerializeField] GameObject kwiat2;
    [SerializeField] GameObject kwiat3;
    [SerializeField] GameObject kwiat4;
    [SerializeField] GameObject kwiat5;
    public void Generracja_Kwiatów()
    {
        Debug.Log("w funkcji generacja" );
        kwiaty_ilość = ilość_kwiatów.Length;
        foreach (GameObject p in teren.płyty)
        {
            
            Debug.Log("w foreach");
            
            
                Debug.Log("1. if pokonany");
                Vector3 przesunięcie = new Vector3(UnityEngine.Random.Range(-szansa, szansa), 0, UnityEngine.Random.Range(-szansa, szansa));
                Vector3 pozycja = p.transform.position + przesunięcie;

                Debug.Log("funkcja tworzenie sie odpaliła");
                tworzenie_kwiatów( pozycja);
            
        } 
    }
    void tworzenie_kwiatów(Vector3 pozycja)
    {
        int los = UnityEngine.Random.Range(0, 3);
        if  (los == 0)
        {
            int kolor = UnityEngine.Random.Range(0, 5);
            Quaternion losowa_rotacja = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);
            if (pozycja.y< teren.gridY*10)
            {
                if (kolor == 0)
                {

                    if (pozycja.x < teren.gridX * 10)
                    {
                        Instantiate(kwiat1, pozycja, losowa_rotacja);
                        Debug.Log("stworzony");


                    }
                }
                else if (kolor == 1)
                {
                    if (pozycja.x < teren.gridX * 10)
                    {
                        Instantiate(kwiat2, pozycja, losowa_rotacja);
                        Debug.Log("stworzony");


                    }
                }
                else if (kolor == 2)
                {
                    if (pozycja.x < teren.gridX * 10)
                    {
                        Instantiate(kwiat3, pozycja, losowa_rotacja);
                        Debug.Log("stworzony");


                    }
                }
                else if (kolor == 3)
                {
                    if (pozycja.x < teren.gridX * 10)
                    {
                        Instantiate(kwiat4, pozycja, losowa_rotacja);
                        Debug.Log("stworzony");


                    }
                    else if (kolor == 4)
                    {
                        if (pozycja.x < teren.gridX * 10)
                        {
                            Instantiate(kwiat5, pozycja, losowa_rotacja);
                            Debug.Log("stworzony");



                        }
                    }
                }
            }



        }
       
        
            

    }
   
}
