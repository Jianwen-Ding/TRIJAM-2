using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teabag : DragObject
{
    [SerializeField]
    int redLeaves = 0;
    [SerializeField]
    int blueLeaves = 0;
    [SerializeField]
    int greenLeaves = 0;
    SpriteRenderer rend;
    private void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
    }
    private void colorSet(int r, int b, int g)
    {
        int TotalLeaves = r + b + g;
        float Intensity = TotalLeaves * 50;
        if (Intensity > 255)
        {
            Intensity = 255;
        }
        Color32 bagColor = new Color32((byte)((float)r / (float)TotalLeaves * (float)Intensity), (byte)((float)g / (float)TotalLeaves * (float)Intensity), (byte)((float)b / (float)TotalLeaves * (float)Intensity), 255);
        rend.color = bagColor;
    }
    public void Set(int r, int b, int g)
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        redLeaves = r;
        blueLeaves = b;
        greenLeaves = g;
        colorSet(redLeaves, blueLeaves, greenLeaves);
    }
    public void Set(GameObject ob1, GameObject ob2)
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        switch (ob1.gameObject.GetComponent<Leaf>().getLeaf())
        {
            case "r":
                redLeaves++;
                break;
            case "b":
                blueLeaves++;
                break;
            case "g":
                greenLeaves++;
                break;
        }
        switch (ob2.gameObject.GetComponent<Leaf>().getLeaf())
        {
            case "r":
                redLeaves++;
                break;
            case "b":
                blueLeaves++;
                break;
            case "g":
                greenLeaves++;
                break;
        }
        colorSet(redLeaves, blueLeaves, greenLeaves);
    }
    public override void fuse(GameObject gameObjectFuseTo)
    {
        //lmao
        if(gameObjectFuseTo.tag.Equals("Leave") && gameObjectFuseTo.gameObject.GetComponent<Leaf>() != null)
        {
            switch (gameObjectFuseTo.gameObject.GetComponent<Leaf>().getLeaf()) {
                case "r":
                    redLeaves++;
                    break;
                case "b":
                    blueLeaves++;
                    break;
                case "g":
                    greenLeaves++;
                    break;
            }
            colorSet(redLeaves, blueLeaves, greenLeaves);
            Destroy(gameObjectFuseTo);
        }
        
    }
}
