using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Node : MonoBehaviour
{
    public NavMeshSurface surface;

    public Color hoverColor;
    public Vector3 positionOffset;
    

    private GameObject turret;
    
    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
       if (turret != null)
        {
            Debug.Log("Can't build there! = TODO: Display on Screen.");
            return;
        }
        //Build a Turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        surface.BuildNavMesh();
    }

    private void OnMouseEnter()//Everytime the mouse moves over the object
    {
        rend.material.color=hoverColor;
        
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
