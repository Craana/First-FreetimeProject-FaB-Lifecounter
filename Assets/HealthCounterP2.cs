using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCounterP2 : MonoBehaviour
{
    [SerializeField] TMP_Text healthP2;
    public int health;

    private void Awake()
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
        healthP2.text = health.ToString();
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
