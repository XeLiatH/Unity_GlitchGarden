using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] int lifePoints = 10;
    [SerializeField] int minimalLifeDamage = 1;

    Text lifeText;
    LevelLoader levelLoader;

    void Start()
    {
        lifeText = GetComponent<Text>();
        levelLoader = FindObjectOfType<LevelLoader>();
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
            levelLoader.LoadLoseScene();
        }
    }

    public void AddLifePoints(int amount)
    {
        lifePoints += amount;
        UpdateDisplay();
    }

    public int GetLifePoits()
    {
        return lifePoints;
    }
}
