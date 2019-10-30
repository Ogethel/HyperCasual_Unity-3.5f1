using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
   public CharacterController Controller { get; set; }

   protected Vector3 Location;
   protected Vector3 Orientation;
   public float speed = 10f;
   public float orientSpeed = 3f;

   public abstract void Move();

}
