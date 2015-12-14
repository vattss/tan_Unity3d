using UnityEngine;
using System.Collections;

public class tan_TestRalCast : MonoBehaviour {
	private Vector3 vecHitPositon;
	private GameObject objBullet;
	private GameObject objTarget;

 	// Use this for initialization
	void Start () 
	{
		objTarget=GameObject.Find("Cube");
	for(int i=1;i<=5;i++)
		{
			for(int j=1;j<=5;j++)
			{
				GameObject objGoClone=(GameObject)GameObject.Instantiate(objTarget);
				objGoClone.transform.position=new Vector3(objGoClone.transform.position.x+j,objGoClone.transform.position.y+i,objGoClone.transform.position.z);
				                                          
			}
		}
	}
	//射线投射
	
		// Update is called once per frame
	void FixedUpdate () {
	//定义射线
		
		Ray ray01=Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray01,out hit)) 
		{
			//print("射线碰撞的物体是："+hit.collider.name);
			vecHitPositon=hit.point;
		}
		Debug.DrawRay(Camera.main.transform.position,vecHitPositon-Camera.main.transform.position,Color.red);
		if (Input.GetMouseButtonDown(0)) 
		{
			objBullet=GameObject.CreatePrimitive(PrimitiveType.Sphere);
			objBullet.transform.position=Camera.main.transform.position;
			objBullet.AddComponent<Rigidbody>();
			objBullet.rigidbody.AddForce((vecHitPositon-objBullet.transform.position)*10,ForceMode.Impulse);
			Destroy(objBullet,5);
			this.gameObject.AddComponent("an_OnBecomeVisiable");

		}
		 
	}
}
