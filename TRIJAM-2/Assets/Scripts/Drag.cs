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
            transform.GetChild(0).gameObject.GetComponent<DragObject>().fuse(collision.gameObject);
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
            collision.gameObject.gameObject.GetComponent<DragObject>().fuse(transform.GetChild(0).gameObject);
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
