using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class jednostka_move : MonoBehaviour
{
    Ray ray;
    
    GameObject zaznaczony_obiekt;
    public UIManager uiManager;
   
   
    
   

    NavMeshAgent agent ;

    private void Update()
    {
        if (uiManager.timer)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if (hit.collider.CompareTag("wojsko"))
                    {
                        zaznaczony_obiekt = hit.collider.gameObject;
                        agent = zaznaczony_obiekt.GetComponent<NavMeshAgent>();
                        Debug.Log("Zaznaczono: " + zaznaczony_obiekt.name);

                    }

                    else if (hit.collider.CompareTag("punkt_pod³ogi") && agent != null)
                    {
                        Vector3 punktdocelowy = hit.collider.gameObject.transform.position;
                        agent.SetDestination(punktdocelowy);


                        Debug.Log("Cel ustawiony na: " + punktdocelowy);
                    }
                }
            }
        }
    }
    
   
}
