using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1ImageHandler : MonoBehaviour
{

    [SerializeField] Image p1image;
    [SerializeField] HeroCard[] images;
    int imagenumber;

    private void Start()
    {
        imagenumber = StatePlayerImageController.playerOneImage;
    }

    private void Update()
    {
        DisplayImage();
        
    }

    public void DisplayImage()
    {

        p1image.sprite = images[imagenumber].artWork;
    }

}
