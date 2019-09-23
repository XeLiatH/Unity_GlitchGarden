using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] float baseLifePoints = 3f;
    [SerializeField] int minimalLifeDamage = 1;

    Text lifeText;
    float lifePoints;

    void Start()
    {
        lifePoints = baseLifePoints - PlayerPrefsController.GetDifficulty();
        lifeText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        lifeText.text = lifePoints.ToString();
    }

    public void DecreaseLifePoints(int amount)
    {
        if (amount < minimalLifeDamage)
        {
            amount = minimalLifeDamage;
        }

        lifePoints -= amount;
        UpdateDisplay();

        if (lifePoints <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondiditon();
        }
    }

    public void AddLifePoints(int amount)
    {
        lifePoints += amount;
        UpdateDisplay();
    }

    public float GetLifePoits()
    {
        return lifePoints;
    }
}
