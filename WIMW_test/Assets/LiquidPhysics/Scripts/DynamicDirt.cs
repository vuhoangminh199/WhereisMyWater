using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicDirt : MonoBehaviour{	
	public GameObject currentImage; //The image is for the metaball shader for the effect, it is onle seen by the liquids camera.
	Collider2D collider;
	float particleLifeTime=10000000.0f,startTime;//How much time before the particle scalesdown and dies	
	private bool flag = false;
	private bool flagDestroy = false;

	void Start () {
        collider = GetComponent<CircleCollider2D>();
	}
	
 	 void Update () {
		  //ham lay vi tri chuot de xoa dat 
				// if (Input.GetMouseButtonDown(0)){
				// 	flag = true;
				// }
				// if (Input.GetMouseButtonUp(0)){
				// 	flag = false;
				// }
				// Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				// RaycastHit hit;	
				// if (flag){
				// 	 if(Physics.Raycast(ray,out hit)){
 				// 		//if (gameObject.transform.position == Input.mousePosition){
				// 			 Debug.Log(gameObject.transform.position);
				// 			 Debug.Log(Input.mousePosition);
				// 			 Destroy(this);
				// 		// }
				// 	 }		 
				// }


				// if (Input.GetMouseButtonDown(0)) 
				// 	{
				// 		flagDestroy =true;
				// 	Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
				// //	RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition).normalized, Vector2.zero);
				// 	Vector2 firePointPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
				// 	RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
				// 	if(hit.collider != null)
				// 	{		Debug.Log(hit.collider.gameObject.name);
				// 			if(hit.collider.gameObject==gameObject) {
				// 				if (flagDestroy){
				// 					flagDestroy = false;
				// 					Destroy(hit.collider.gameObject);
				// 				}
				// 			}
				// 	}
				// 	else {
				// 		Debug.Log("null");
				// 	}
				// }

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
        if (collider.OverlapPoint(touchPosWorld))
        {
            Destroy(gameObject);
        }
    }	
	// This scales the particle image acording to its velocity, so it looks like its deformable... but its not ;)
	void MovementAnimation(){
		Vector3 movementScale=new Vector3(1.0f,1.0f,1.0f);//metaball			
		 movementScale.x+=Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.x)/30.0f;
		 movementScale.z+=Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.y)/30.0f;
		movementScale.y=1.0f;		
		currentImage.gameObject.transform.localScale=movementScale;
	}
	// The effect for the particle to seem to fade away
	void ScaleDown(){ 
		float scaleValue = 1.0f-((Time.time-startTime)/particleLifeTime);
		Vector2 particleScale=Vector2.one;
		if (scaleValue <= 0) {
						Destroy (gameObject);
		} else{
			particleScale.x=scaleValue;
			particleScale.y=scaleValue;
			transform.localScale=particleScale;
		}
	}

	
	// Here we handle the collision events with another particles, in this example water+lava= water-> gas
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "DIRT"){
			Debug.Log("a");
		}
		

	}
	
}
