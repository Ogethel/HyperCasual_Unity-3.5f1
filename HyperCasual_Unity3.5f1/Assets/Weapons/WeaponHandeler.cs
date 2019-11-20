using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandeler : MonoBehaviour
{
    public WeaponConfig weaponObj;

    private void Start()
    {
        weaponObj.weaponFireAction = Fire;
        var renderer = GetComponent<Renderer>();
        renderer.material.color = weaponObj.weaponColor;
    }

    public void Fire()
    {
        var ammo = Instantiate(weaponObj.ammoObj);
        //ammo.GetComponent<AmmoHandeler>().weaponObj = weaponObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        weaponObj.RaiseCollectAction();
    }
}
