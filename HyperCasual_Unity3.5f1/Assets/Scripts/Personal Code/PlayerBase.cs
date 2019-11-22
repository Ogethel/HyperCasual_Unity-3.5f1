using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public Color hoverColor;

    public GameObject playerTower;

    private Renderer rend;
    private Color startColor;

    private void Start()
    {
        rend = playerTower.GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (playerTower != null)
        {
            Debug.Log("Can't Move There! - TODO: Display in Game");
            return;
        }

        //Move Player
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
