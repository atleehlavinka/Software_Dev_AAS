using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    //public HealthBar healthBar;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void SetActive()
    {
        gameObject.SetActive(true);
    }

    public void SetInactive()
    {
        gameObject.SetActive(false);
    }

    public void CheckActive(int health)
    {
        if (health > 1)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
