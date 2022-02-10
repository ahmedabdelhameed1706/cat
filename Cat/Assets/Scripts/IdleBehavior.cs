using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehavior : StateMachineBehaviour
{
    readonly float _idleMin = 1f;
    readonly float _idleMax = 5f;

    float idleTimer = 0;
    string _idle = "IdleB";


    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (idleTimer <= 0)
        {
            ActivateIdle(animator);
            idleTimer = Random.Range(_idleMin,_idleMax);
        }
        else
        {
            idleTimer -= Time.deltaTime;
        }
    }

    void ActivateIdle(Animator animator)
    {
        animator.SetTrigger(_idle);
    }
}
