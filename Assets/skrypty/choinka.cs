using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choinka : MonoBehaviour
{

    //zmienne:
    int health = 20;
    [SerializeField]int force = 20;
    private Vector3 hitDir;
    
    // Update is called once per frame
    void Update()
    {
        if (health <=0 )
        {
            breakJoint();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("axe"))
        {
            var demage = collision.gameObject.GetComponent<Demage>();
            health -= demage.demage;


            Vector3 hitDir = (collision.transform.position - transform.position).normalized;
        }
    }
    void breakJoint()
    {
        Joint joint  = this.GetComponent<Joint>();
        Destroy(joint);
        this.gameObject.GetComponent<Rigidbody>().AddForce(-hitDir * force, ForceMode.Impulse);
        
    }
}
