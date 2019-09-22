using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        Attacker attacker = other.gameObject.GetComponent<Attacker>();

        if (attacker)
        {
            // TODO: do animation
        }
    }
}
