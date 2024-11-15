using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    private static readonly int IsMoving = Animator.StringToHash("isMoving");
    private static readonly int Hit = Animator.StringToHash("hit");

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMoving(bool moving)
    {
        animator.SetBool(IsMoving, moving);
    }

    public void TriggerHit()
    {
        animator.SetTrigger(Hit);
    }
}