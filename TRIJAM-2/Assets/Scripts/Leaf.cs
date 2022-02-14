using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : DragObject
{
    [SerializeField]
    string typeOfLeaf;
    [SerializeField]
    GameObject prefab;
    public string getLeaf()
    {
        return typeOfLeaf;
    }
    public override void fuse(GameObject gameObjectFuseTo)
    {
        if(gameObjectFuseTo.GetComponent<Leaf>() != null)
        {
            GameObject packet = Instantiate(prefab, gameObject.transform.position, Quaternion.identity.normalized);
            packet.AddComponent(typeof(Teabag));
            packet.GetComponent<Teabag>().Set(gameObject, gameObjectFuseTo);
            Destroy(gameObjectFuseTo);
            Destroy(gameObject);
        }
       
    }
}
