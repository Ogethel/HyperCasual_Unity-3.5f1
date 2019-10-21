using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameAction gameActionObj;
    
    public Vector3Data instanceAtLocation;
    
    public void InstanceObj(GameObject obj)
    {
        var newObj = Instantiate(obj, instanceAtLocation.value, Quaternion.identity);
        gameActionObj.transformAction(newObj.transform);
    }
}