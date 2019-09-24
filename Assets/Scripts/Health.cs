using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    const string VFX_PARENT_NAME = "Visual Effects";

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    GameObject VFXParent;

    void Start()
    {
        CreateVFXParent();
    }

    private void CreateVFXParent()
    {
        VFXParent = GameObject.Find(VFX_PARENT_NAME);
        if (!VFXParent)
        {
            VFXParent = new GameObject(VFX_PARENT_NAME);
        }
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        }

        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity) as GameObject;
        deathVFXObject.transform.parent = VFXParent.transform;
        Destroy(deathVFXObject, 1f);
    }
}
