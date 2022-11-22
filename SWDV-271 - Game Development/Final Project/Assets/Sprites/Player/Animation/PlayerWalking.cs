using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : StateMachineBehaviour
{

    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource walking = animator.GetComponent<AudioSource>();
        //animator.GetComponent<AudioSource>();
        walking.enabled = true;
        walking.Play();
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource walking = animator.GetComponent<AudioSource>();
        //animator.GetComponent<AudioSource>();
        walking.enabled = true;
        walking.Stop();
    }
}
