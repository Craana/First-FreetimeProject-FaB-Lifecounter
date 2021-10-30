using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void SetUpPlayerOneImage(int playerOneImage)
    {
        StatePlayerImageController.playerOneImage = playerOneImage;
    }

    public void SetUpPlayerTwoImage(int playerTwoImage)
    {
        StatePlayerImageController.playerTwoImage = playerTwoImage;
    }

    public void SetUpHealth(int health)
    {
        StateIntController.health = health;
    }
}
