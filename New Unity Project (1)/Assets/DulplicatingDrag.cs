using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DulplicatingDrag : DragObject
{
    [SerializeField]
    GameObject prefab;
    public override void attach(GameObject attachingGameObject)
    {
        if (attachingGameObject.transform.childCount == 0)
        {
            Instantiate(prefab, gameObject.transform.position, Quaternion.identity.normalized).transform.parent = attachingGameObject.transform;
        }
    }
}
