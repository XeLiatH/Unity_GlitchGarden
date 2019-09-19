using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

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
