using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamienie : MonoBehaviour
{
    [SerializeField] GameObject kamieñ;
    private void Start()
    {
        tworzenie();
    }
    void tworzenie()
    {
        Vector3 pozycja= new Vector3(0,8,0);
        Quaternion rotacja = Quaternion.Euler(0, 0, 0);
        for (int i = 0; i < 4; i++)
        {
            if (i == 1 || i == 3)
            {
                rotacja = Quaternion.Euler(0,  90, 0);
            }
            else if (i == 0 || i == 2) 
            {
                rotacja = Quaternion.Euler(0, 0, 0);
                
            }
            for (int j = 0; j < 66; j++)
            {

                Instantiate(kamieñ, pozycja, rotacja);
                if (i == 0)
                {
                    pozycja.z += 15;

                }

                if (i == 1)
                {
                    pozycja.x += 15;

                }

                if (i == 2)
                {
                    pozycja.z -= 15;

                }

                if (i == 3)
                {
                    pozycja.x -= 15;

                }
            }
    }   }

    
}



