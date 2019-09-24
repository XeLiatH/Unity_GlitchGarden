using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (costText)
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
        else
        {
            Debug.LogError(name + " has no cost text, add some!");
        }
    }

    void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(50, 50, 50, 255);
        }

        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
