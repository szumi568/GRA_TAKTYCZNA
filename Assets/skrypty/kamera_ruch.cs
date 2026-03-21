using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_ruch : MonoBehaviour
{
    
    private void Update()
    {
        Vector3 imputmove = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            imputmove.z += 1;
        
        }
        if (Input.GetKey(KeyCode.S))
        {
            imputmove.z -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            imputmove.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            imputmove.x += 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            imputmove.y += 1;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            imputmove.y -= 1;
        }
        Vector3 move = transform.forward * imputmove.z + transform.right * imputmove.x+transform.up* imputmove.y;
        int movespeed =50;
        Vector3 pozycja_kamery = transform.position + move * movespeed*Time.deltaTime;
        if (pozycja_kamery.y >= 0 && pozycja_kamery.x <= 950 && pozycja_kamery.x >= 50 && pozycja_kamery.y < 250 && pozycja_kamery.z > 50 && pozycja_kamery.z < 950)
        {
            transform.position+=move*movespeed*Time.deltaTime;
        }
        
        int rotate = 0;
        if (Input.GetKey(KeyCode.Q))
        {
            rotate-= 1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotate += 1;
        }
        transform.Rotate(0,rotate*movespeed*Time.deltaTime,0);
    }
}
