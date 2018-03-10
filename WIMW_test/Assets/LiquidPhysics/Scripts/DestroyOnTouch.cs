using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyOnTouch : MonoBehaviour {
    Collider2D collider;
	// Use this for initialization
	void Start () {
        collider = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchBegan(Input.GetTouch(0).position);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            touchBegan(Input.mousePosition);
        }
    }

    private void touchBegan(Vector2 position)
    {
        Vector2 touchPosWorld = Camera.main.ScreenToWorldPoint(position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 point = ray.origin + (ray.direction * 4.5f);
        Vector2 touchPos = new Vector2(touchPosWorld.x-Camera.main.transform.position.x,touchPosWorld.y-Camera.main.transform.position.y);
        //Vector2 touchPos = new Vector2(touchPosWorld.x-Camera.main.transform.position.x,touchPosWorld.y-Camera.main.transform.position.y);
       if (collider.OverlapPoint(touchPos))
       //if (collider.OverlapPoint(touchPosWorld))
        {
            Destroy(gameObject);
        }
        else{
           //  Debug.Log(ray.origin.x);
             Debug.Log("camera"+touchPosWorld.x); 
             Debug.Log("touch"+touchPos.x);
             Debug.Log("object"+gameObject.transform.position.x);
             Debug.Log("object"+gameObject.transform.position.x);
        }
    }
}
