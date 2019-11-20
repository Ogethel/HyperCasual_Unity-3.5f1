using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponConfig : ScriptableObject
{
   public UnityAction collectWeaponAction;
   public UnityAction weaponFireAction;
   public Color weaponColor = Color.red;
   public GameObject ammoObj;
   public GameAction damageAction;
   public Color[] colorArray;
   public float firePower = 0.1f;
   public FloatData playerHealth;
   public void RaiseFireAction()
   {
      weaponFireAction?.Invoke(); //The ? is = !=null
   }

   public void RaiseCollectAction()
   {
      collectWeaponAction?.Invoke();
   }

   public Color RandomColor()
   {
      return weaponColor;
   }

   public void DoDamage()
   {
      playerHealth.UpdateValue(firePower);
      damageAction.Raise();
   }
}
