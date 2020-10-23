using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARFriendsScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject parthitgo, aditigo, riago;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "AditiVB")
        {
            aditigo.SetActive(true);
            parthitgo.SetActive(false);
            riago.SetActive(false);

        }
        else if(vb.VirtualButtonName == "ParthitVB")
        {
            aditigo.SetActive(false);
            parthitgo.SetActive(true);
            riago.SetActive(false);
        }
        else if(vb.VirtualButtonName == "RiaVB")
        {
            aditigo.SetActive(false);
            parthitgo.SetActive(false);
            riago.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not supported");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button released");
    }

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        };

        parthitgo.SetActive(false);
        aditigo.SetActive(false);
        riago.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
