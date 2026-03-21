using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drzewo_skrypt : MonoBehaviour
{
    //zmienne:
    int health = 30;
    [SerializeField] int force = 2;
    private Vector3 hitDir;
    bool IsBroken= false;


    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("axe"))
        {
            var demage = collision.gameObject.GetComponent<Demage>();
            health -= demage.demage;

            hitDir = (collision.transform.position - transform.position).normalized;
            if (health <= 0 && !IsBroken )
            {
             BreakAllJoints();
             this.gameObject.GetComponent<Rigidbody>().AddForce(-hitDir * force, ForceMode.Impulse);
            }
        }
    }
    void BreakAllJoints()
    {
        foreach(Joint j in GetComponents<Joint>())
        {
            
            Destroy(j);
          
        }
    }
}
