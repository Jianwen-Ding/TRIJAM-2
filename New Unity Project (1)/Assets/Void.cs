using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : DragObject
{
    public override void attach(GameObject attachingGameObject)
    {
    }
    public override void fuse(GameObject gameObjectFuseTo)
    {
            Destroy(gameObjectFuseTo);    
    }
}
