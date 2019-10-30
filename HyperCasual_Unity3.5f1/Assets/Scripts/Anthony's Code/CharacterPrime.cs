using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPrime : CharacterBase
{
  public override void Move()
  {
    Location.Set(newX:Input.GetAxis("Vertical")*speed, newY:0, newZ:0);
    Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;

    Transform transform;
    (transform = Controller.transform).Rotate(Orientation);
    Location = Controller.transform.TransformDirection(transform.position);

    Controller.Move(Location * Time.deltaTime);
  }
}
