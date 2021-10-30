using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2ImageHandler : MonoBehaviour
{


    [SerializeField] Image p2image;
    [SerializeField] HeroCard[] images;
    int imagenumber;

    private void Start()
    {
        imagenumber = StatePlayerImageController.playerTwoImage;
    }

    private void Update()
    {
        DisplayImage();

    }

    public void DisplayImage()
    {

        p2image.sprite = images[imagenumber].artWork;
    }

}

