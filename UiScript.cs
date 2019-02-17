using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    public PlayerController PlayerScript;
    public Text pickUpText;
    public Text Wintext;

    public GameObject Winpanel;

    public int PickUpcount;

     public void Start()
    {

        PickUpcount = 0;

        SetCountText();
        Wintext.text = "";

        Winpanel.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }


    public void SetCountText()
    {
        pickUpText.text = "COUNT: " + PickUpcount.ToString();
    }
    public void SetWinText()
    {
        if(PickUpcount == 8)
        {
            Winpanel.gameObject.SetActive(true);
            Wintext.text = "VICTORY!";
            PlayerScript.rb.gameObject.SetActive(false);
        }
    }

}
