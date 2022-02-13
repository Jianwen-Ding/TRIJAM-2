using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetAxis("Fire1") != 0 && collision.gameObject.GetComponent<DragObject>())
        {
            collision.gameObject.GetComponent<DragObject>().attach(gameObject);
        }
        if (Input.GetAxis("Fire1") == 0 && transform.childCount == 1 && collision.gameObject.GetComponent<DragObject>())
        {
            print("wow");
            transform.DetachChildren();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetAxis("Fire1") != 0 && collision.gameObject.GetComponent<DragObject>())
        {
            collision.gameObject.GetComponent<DragObject>().attach(gameObject);
        }
        if (Input.GetAxis("Fire1") == 0 && transform.childCount == 1 && collision.gameObject != transform.GetChild(0).gameObject && collision.gameObject.GetComponent<DragObject>())
        {
            print(collision.name);
            transform.DetachChildren();
        }
    }
    // Update is called once per frame
    void Update()
    {
       transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetAxis("Fire1") == 0)
        {
            transform.DetachChildren();
        }
    }
}
