using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    
    public Color hoverColor;

    public GameObject playerTower;
    private Vector3 newPosition;
    private Transform parentPrefab;
    private Renderer rend;
    private Color startColor;

    private void Start()
    {
        rend = playerTower.GetComponent<Renderer>();
        startColor = rend.material.color;
        parentPrefab = this.transform.parent;
    }

    public void OnMouseDown()
    {
        if (playerTower != null)
        {
            Debug.Log("Can't Move There! - TODO: Display in Game");
            return;
        }
        playerTower.transform.position = parentPrefab.transform.position;
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
