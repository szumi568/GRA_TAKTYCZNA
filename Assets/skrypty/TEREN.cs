using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using static UnityEditor.PlayerSettings;
using Unity.AI.Navigation;

public class TEREN : MonoBehaviour
{
    public  int gridY = 25;
    public  int gridX = 25;
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject drzewo_liœciaste;
    [SerializeField] GameObject drzewo_iglaste;
    public List<GameObject> p³yty = new List<GameObject>();
    public List<GameObject> centrum = new List<GameObject>();
    [SerializeField] int tree_center_count;
    [SerializeField] int Max_zasiêg;
    public GameObject wybranap³yta;
    [SerializeField] int tree_in_forest_count;
    Vector3 pos;
    Vector3 zasiêg;
    public NavMeshSurface surface;



    private void Start()
    {
        generacja_paneli(gridX, gridY);
        generacja_center_drzew(gridX, gridY);
        generacja_kwiatów skryptKwiatów=GetComponent<generacja_kwiatów>();
        if (skryptKwiatów != null)
        {
            skryptKwiatów.Generracja_Kwiatów();
        }
        generacjaska³ ska³a = GetComponent<generacjaska³>();
        if (ska³a != null)
        {
            ska³a.create_ska³a();
        }
        surface.BuildNavMesh();

    }
    void generacja_paneli(int gridX, int gridY)
    {
        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {
                Vector3 position = new Vector3(x * 10, 0, y * 10);
                GameObject nowaP³yta = Instantiate(prefab, position, Quaternion.identity);
                int id = y * gridX + x;
                nowaP³yta.name = id.ToString();
               
                p³yty.Add(nowaP³yta);

            }
        }

    }
    void generacja_center_drzew(int gridX, int gridY)
    {
        for (int y = 0; y < tree_center_count; y++)
        {
            int posY = UnityEngine.Random.Range(0, gridY);
            int posX = UnityEngine.Random.Range(0, gridX);
            var index = posY * gridX + posX;
            wybranap³yta = p³yty[index];
            GameObject punkt = p³yty[index];
            if (!wybranap³yta.GetComponent<panel_data>().tree_Isplaced)
            {
                panel_data data = wybranap³yta.GetComponent<panel_data>();
                wybierz_drzewo(punkt.transform.position,data);
                generacja_lasów(punkt);
            }
        }
    }

    
    
        void generacja_lasów(GameObject punktStartowy) 
        {
            if (punktStartowy == null) return;

            for (int x = 0; x < tree_in_forest_count; x++)
            {
                int offX = UnityEngine.Random.Range(-Max_zasiêg, Max_zasiêg + 1) * 10;
                int offZ = UnityEngine.Random.Range(-Max_zasiêg, Max_zasiêg + 1) * 10;
                Vector3 wybranaPozycja = punktStartowy.transform.position + new Vector3(offX, 0, offZ);

                
                foreach (GameObject p in p³yty)
                {
                    if (p.transform.position == wybranaPozycja)
                    {
                        panel_data data = p.GetComponent<panel_data>();
                        if (!data.tree_Isplaced)
                        {
                            
                            wybierz_drzewo(wybranaPozycja, data);
                        }
                        break; 
                    }
                }
            }
        }

    

    public void wybierz_drzewo(Vector3 pos,panel_data data)
    {
        int drzewo = UnityEngine.Random.Range(0, 2);


        if (drzewo == 0)
        {
            Instantiate(drzewo_liœciaste, pos + zasiêg, Quaternion.identity);
            
        }
        if (drzewo == 1)
        {
            Quaternion rotacja = Quaternion.Euler(-90, 0, 0);
            Instantiate(drzewo_iglaste, pos + zasiêg, rotacja);
            
        }





        data.tree_Isplaced = true;
    }
}   




