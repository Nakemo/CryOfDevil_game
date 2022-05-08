using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    
    public GameObject WhiteLight;
    private bool lightActive = true;
        
    void Start() 
    {
        WhiteLight.gameObject.SetActive(true);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            if (lightActive == true)
            {
                WhiteLight.gameObject.SetActive(false);
                lightActive = false;
            }
            else {
                WhiteLight.gameObject.SetActive(true);
                lightActive = true;
            }
        }
    }
}
