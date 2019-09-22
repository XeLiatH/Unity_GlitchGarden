using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        var defender = other.gameObject.GetComponent<Defender>();

        if (defender)
        {
            GetComponent<Attacker>().Attack(defender);
        }
    }
}
