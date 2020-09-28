using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;

public class GridSpace : MonoBehaviour
{
    public Button button;
    //public Text buttonText;
    public string text;
    // public string playerSide;
    public Image image;

    private GameController gameController;

    
    public void Setspace()
    {
        if(gameController.playerMove==true)
        {
            text = gameController.GetPlayerSide();
            image.sprite = gameController.GetPlayerSideImage();
            button.interactable = false;
            gameController.EndTurn();
        }
         
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }
    public void ResetGridSpace()
    {
        text = "";
        image.sprite = null;
    }
}