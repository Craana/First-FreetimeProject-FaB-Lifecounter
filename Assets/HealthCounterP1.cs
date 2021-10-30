using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCounterP1 : MonoBehaviour
{
    [SerializeField] TMP_Text healthP1;
      public int health;

    void Awake()
    {
        health = StateIntController.health;
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();

    }


    void UpdateHealth()
    {
        healthP1.text = health.ToString();
        IncreaseHealth();
        DecreaseHealth();
    }
    public void IncreaseHealth()
    {
        health++;
    }

    public void DecreaseHealth()
    {
        health--;
    }

}
