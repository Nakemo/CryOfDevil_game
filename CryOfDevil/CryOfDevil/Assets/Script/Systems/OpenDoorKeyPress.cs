//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OpenDoorKeyPress : MonoBehaviour
//{
//    public GameObject Instruction;
//    public GameObject AnimeObject;
//    public bool Action = false; 

//    void Start()
//    {
//        Instruction.SetActive(false);
//    }

//    void OnTriggerEnter(Collider collision)
//    {
//        if(collision.tranform.tag == "Player")
//        {
//            Instruction.SetActive(true);
//            Action = true;
//        }
//    }

//    void OnTriggerExit(Collider collision)
//    {
//        Instruction.SetActive(false);
//        Action = false;
//    }

//    void Update()
//    {
//        if(Input.GetKeyDown(KeyCode.E))
//        {
//            if(Action == true)
//            {
//                Instruction.SetActive(false);
//                AnimeObject.GetComponent<Animator>().Play("ANIMAÇÃO_NAME");
//                Action = false;
//            }
//        }
//    }
//}
