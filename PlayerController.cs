using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public UiScript HudScript;
    public Rigidbody2D rb;

    public float Speed;

 



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }


    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(MoveHorizontal, MoveVertical, 0);

        rb.AddForce(Movement * Speed);

        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUps"))
        {
            other.gameObject.SetActive(false);
            HudScript.PickUpcount = HudScript.PickUpcount + 1;

            HudScript.SetCountText();
            HudScript.SetWinText();

        }
    }
   

}
