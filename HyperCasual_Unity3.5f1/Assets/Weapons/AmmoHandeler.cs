using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AmmoHandeler : MonoBehaviour
{
    public WeaponConfig weaponObj;
    private Rigidbody rigidbodyObj;

    public Vector3 Forces;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyObj = GetComponent<Rigidbody>();
        rigidbodyObj.AddForce(Forces);
        Destroy(gameObject,  1f);
        var renderer = GetComponent<Renderer>();
        //renderer.material.color = weaponObj.RandomColor();
    }

    
    
}
