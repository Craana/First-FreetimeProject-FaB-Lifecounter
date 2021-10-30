using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text dropDownText;
    [SerializeField] private TMP_Dropdown dropdown;
   
    private void Update()
    {
        SetText();
    }

    void SetText()
    {
        if (dropdown.value == 0)
        {
            dropDownText.text = "Bravo, Showstopper";
            if(gameObject.tag == "Player1") { StatePlayerImageController.playerOneImage = 0;}
            if(gameObject.tag == "Player2") {StatePlayerImageController.playerTwoImage = 0;}
            
        }
        if (dropdown.value == 1)
        {
            dropDownText.text = "Prism, Sculptor of Arc Light";
            if (gameObject.tag == "Player1") { StatePlayerImageController.playerOneImage = 1; }
            if (gameObject.tag == "Player2") { StatePlayerImageController.playerTwoImage = 1; }
        }
        if (dropdown.value == 2)
        {
            dropDownText.text = "Katsu, the Wanderer";
            if (gameObject.tag == "Player1") { StatePlayerImageController.playerOneImage = 2; }
            if (gameObject.tag == "Player2") { StatePlayerImageController.playerTwoImage = 2; }
        }
    }

}
