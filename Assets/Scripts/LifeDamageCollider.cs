using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDamageCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<LifeDisplay>().DecreaseLifePoints(1);
        Destroy(other.gameObject);
    }
}
