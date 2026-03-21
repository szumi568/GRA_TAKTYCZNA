using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using static UnityEditor.PlayerSettings;

public class generacjaskał : MonoBehaviour
{
    [SerializeField]TEREN teren;
    [SerializeField] panel_data panel_Data;
    [SerializeField] GameObject skała;
    [SerializeField] int ilośćmax=50;
    
    public void create_skała()
    {
        for (int i = 0; i < ilośćmax; i++)
        {
            int index = UnityEngine.Random.Range(0, teren.płyty.Count);




            if (!teren.płyty[index].GetComponent<panel_data>().tree_Isplaced)
            {
                if (!teren.płyty[index].GetComponent<skały_data>().skała_Isplaced)
                {
                    Debug.Log("skała stworzona");
                    Vector3 pozycja = teren.płyty[index].transform.position;
                    Instantiate(skała, pozycja, Quaternion.identity);

                    teren.płyty[index].GetComponent<skały_data>().skała_Isplaced = true;

                }
            }

        }
    }
}
