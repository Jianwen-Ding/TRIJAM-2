using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public virtual void attach(GameObject attachingGameObject)
    {
        if(attachingGameObject.transform.childCount == 0)
        {
            gameObject.transform.parent = attachingGameObject.transform;
        }
    }
    public virtual void fuse(GameObject gameObjectFuseTo)
    {

    }
}
