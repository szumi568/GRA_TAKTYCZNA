using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getwood : MonoBehaviour
{
    int tymczasowa_zmienna_iloœæ_drewna;
    public int tymczasowa_iloœæ_dodania_drewna;
    [SerializeField] float czas_dodania;
    bool dodano_drewno=false;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("odpalony triger ");
        if (dodano_drewno == false)
        {
            Debug.Log("odpalony trigerpo 1. if  ");
            if (other.CompareTag("wood"))
            {

                InvokeRepeating("Get_wood", czas_dodania,czas_dodania);
                Debug.Log("dodano drewno");
                dodano_drewno = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (dodano_drewno == true)
        {
            if (other.CompareTag("wood"))
            {

                CancelInvoke("Get_wood");
                Debug.Log("zatrzymano");
                dodano_drewno = false;
            }
        }
    }
    void Get_wood()
    {
        tymczasowa_zmienna_iloœæ_drewna += tymczasowa_iloœæ_dodania_drewna;
    }
    private void Start()
    {
        Debug.Log("klasa odpalona");
    }
}