using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject MenuUI;
    [SerializeField] GameObject BackgroundUI;
    [SerializeField] GameObject ButtonShowMenuUi;
    [SerializeField] GameObject ekwipumek;
    [SerializeField] GameObject EQ;
    [SerializeField] GameObject Czas;
    [SerializeField] GameObject Hajs;
    [SerializeField] GameObject EQ_show;
    public bool timer;
    bool timer_work;
    public void OnBackPress()
    {
        MenuUI.SetActive(false);
        BackgroundUI.SetActive(false);
        ButtonShowMenuUi.SetActive(true);
        ekwipumek.SetActive(true);
        Hajs.SetActive(true);
        Czas.SetActive(true);
        EQ_show.SetActive(true);
    }

    public void OnExitPress()
    {
        Application.Quit();
    }
    public void OnStopTimePress()
    {
        if (timer_work)
        {
            timer=false;
            timer_work=false;
        }
        else if (!timer_work)
        {
            timer = true;
            timer_work = true;
        }
    }
    public void OnBuildPress()
    {

    }
    public void OnShowMenuPress()
        
    {
        Debug.Log("ButtonShowMenuUi wciœniêty!");
        MenuUI.SetActive(true);
        BackgroundUI.SetActive(true);
        ekwipumek .SetActive(false);
        ButtonShowMenuUi.SetActive(false);
        Hajs.SetActive(false);
        Czas.SetActive(false);
        EQ_show .SetActive(false);
    }
    public void OnShowEQPress()
    {
        Debug.Log("wciœniety");
        if (!EQ.activeSelf)
        { 
            EQ.SetActive(true); 
        }
        else if (EQ.activeSelf)
        {
            EQ.SetActive(false);
        }
    }
}

