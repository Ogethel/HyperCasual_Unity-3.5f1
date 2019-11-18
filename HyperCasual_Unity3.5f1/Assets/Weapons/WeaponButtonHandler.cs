using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Text))]

public class WeaponButtonHandler : MonoBehaviour
{
   public WeaponConfig weaponObj;

   private Button weaponButton;
   private Image buttonImage;
   private Text buttonText;
   
   private void Start()
   {
      weaponButton = GetComponent<Button>();
      weaponButton.onClick.AddListener(weaponObj.RaiseFireAction);
      buttonImage = GetComponent<Image>();
      buttonImage.color = weaponObj.weaponColor;
      buttonText = GetComponentInChildren<Text>();
      buttonText.text = weaponObj.name + " Fire";
      weaponObj.collectWeaponAction = OnCollectWeapon;
      weaponButton.interactable = true;
   }

   public void OnCollectWeapon()
   {
      weaponButton.interactable = false;
   }
}
