using UnityEngine;
[CreateAssetMenu]
public class MoveLRArrows : ScriptableObject, IMove
{
    public Vector3 location { get; set; }
    public Vector3 newLoc;
    
    public void Move(CharacterController controller)
    {
        newLoc.x = Input.GetAxis("Horizontal")*Time.deltaTime;
        controller.Move(newLoc);
    }
}
