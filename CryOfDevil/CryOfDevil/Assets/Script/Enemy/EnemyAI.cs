//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemyAI : MonoBehaviour
//{
//    public float maxDistanceFromPlayer;
//    public float minDistanceFromPlayer;
//    public float currentDistanceFromPlayer;

//    public GameObject player;

//    void Start() 
//    { 
        
//    }

//    void Update() 
//    {
//        currentDistanceFromPlayer = Vector3.Distance(this.transform.position, player.transform.position);

//        if (currentDistanceFromPlayer < maxDistanceFromPlayer) 
//        {
//            TransformEnemy;
//        }
//    }

//    void TransformEnemy() 
//    {
//        transform.LookAt(player.transform.position);
//    }
//}
