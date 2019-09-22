using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var otherGameObject = other.gameObject;

        var defender = otherGameObject.GetComponent<Defender>();
        var gravestone = otherGameObject.GetComponent<Gravestone>();

        if (gravestone)
        {
            animator.SetTrigger("JumpTrigger");
        }

        else if (defender)
        {
            GetComponent<Attacker>().Attack(defender);
        }
    }
}
