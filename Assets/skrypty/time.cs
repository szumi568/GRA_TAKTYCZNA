using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    [SerializeField] UIManager UIManager;
    float time_time = 0f;
    public TextMeshProUGUI text_time;
    private void Update()
    {
        if (UIManager.timer)
        {
            time_time += Time.deltaTime;
           
            text_time.text = time_time.ToString("F2");
        }
        if (!UIManager.timer)
        {
            
            text_time.text = time_time.ToString("F2");
        }
    }
}
