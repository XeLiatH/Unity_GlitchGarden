using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 2f)] [SerializeField] float currentSpeed = 1f;

    Animator animator;
    Defender currentTarget;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(Defender target)
    {
        animator.SetBool("IsAttacking", true);
        currentTarget = target;
    }
}
