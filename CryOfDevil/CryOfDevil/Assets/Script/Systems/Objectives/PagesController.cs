using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagesController : MonoBehaviour
{
    public PlayerConfig playerConfig;
    public GameObject[] pages;
    
    void Start()
    {
        playerConfig = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerConfig>();
        pages = GameObject.FindGameObjectsWithTag("Pages");
    }

    
    void Update()
    {
        
    }
}
