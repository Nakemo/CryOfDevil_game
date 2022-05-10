using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private PlayerMovement player;
    public float radiusToSpawn = 30;
    public Renderer meshEnemy;
    private bool spawned;

    void Start() 
    { 
        player = FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
        meshEnemy.enabled = false;
    }

    void Update() 
    {
        transform.LookAt(player.transform);

        if (Input.GetKeyDown(KeyCode.P)) 
        {
            Spawn();
        }
    }

    public void Spawn() 
    {
        meshEnemy.enabled = false;      
        Vector3 positionToGo = player.transform.position;

        positionToGo.x += Random.Range(-radiusToSpawn, radiusToSpawn);
        positionToGo.z += Random.Range(-radiusToSpawn, radiusToSpawn);
        
        positionToGo.y = Terrain.activeTerrain.SampleHeight(positionToGo);

        transform.position = positionToGo;
        spawned = true;
    }

    void OnBecameInvisible() 
    {
        if (spawned) 
        {
            meshEnemy.enabled = true;
            spawned = false;
        }        
    }
}
