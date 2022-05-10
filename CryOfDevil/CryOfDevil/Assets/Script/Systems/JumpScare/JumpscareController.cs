using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareController : MonoBehaviour
{
    public Animator _jumpscareAnim;       

    void start() 
    {
        _jumpscareAnim = this.transform.parent.GetComponent<Animator>();
    }

    void OnTriggerEnter()
    {
        _jumpscareAnim.SetBool("Scary", true);
        
    }

    void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        Destroy(animator.gameObject);
    }

}
