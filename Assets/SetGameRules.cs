using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SetGameRules : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown setRules;
    

    private void Awake()
    {

    }


    // Update is called once per frame
    void Update()
    {
        SetRules();
    }

    void SetRules()
    {
        if (setRules.value == 0)
        {
           
        }
        if (setRules.value == 1)
        {
            StateIntController.health = 20;
        }
        if (setRules.value == 2)
        {
            StateIntController.health = 40;
        }
    }


}
