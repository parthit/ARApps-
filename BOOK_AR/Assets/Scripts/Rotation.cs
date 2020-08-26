using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Vector3 movement;
    public float xi, yi, zi;
    
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(xi,yi,zi);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement);
    }
    
}
