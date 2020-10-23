using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject spherego, cubego;
    VirtualButtonBehaviour vrb;
   
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        cubego.SetActive(true);
        spherego.SetActive(false);
    }

    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubego.SetActive(true);
        spherego.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubego.SetActive(false);
        spherego.SetActive(true);
    }
}