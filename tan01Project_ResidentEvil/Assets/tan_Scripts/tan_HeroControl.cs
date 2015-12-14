using UnityEngine;
using System.Collections;

public class tan_HeroControl : MonoBehaviour {
	private CharacterController character_HeroCtrl;
	private Vector3 vecHeroPositon;
	public float floHeroMovingSpeed=10f;

	private Transform transCamera; 							//
	private Vector3 vecCamereRotaion;
	public float floHeroGravity;						//英雄的重力

	//private Vector3  tranHeroRotation;

	// Use this for initialization
	void Start () {
	character_HeroCtrl=this.GetComponent<CharacterController>();
		transCamera=Camera.main.transform;
		Screen.showCursor=false;
		Screen.lockCursor=true;

		tan_GlobalManager.heroAction=HeroAct.None;

	}
	
	// Update is called once per frame
	void Update () {
		MovingControl();
	}
	private void MovingControl()
	{
		/*角色旋转**/
		//摄像机旋转
		float _FloX=Input.GetAxis("Mouse X");
		float _FloY=Input.GetAxis("Mouse Y");
		vecCamereRotaion.y+=_FloX;
		vecCamereRotaion.x-=_FloY;
		transCamera.transform.eulerAngles=vecCamereRotaion;
		//Hero的旋转
		this.transform.eulerAngles=new Vector3(0,vecCamereRotaion.y,0);
		/*英雄的移动**/
		
		
		vecHeroPositon=Vector3.zero;
		//英雄的重力
		vecHeroPositon.y-=floHeroGravity;
		
		if (Input.GetKey(KeyCode.W)) {
			vecHeroPositon.z+=floHeroMovingSpeed*Time.deltaTime;
			tan_GlobalManager.heroAction=HeroAct.Walking;
		}else
		if (Input.GetKey(KeyCode.S)) {
			vecHeroPositon.z-=floHeroMovingSpeed*Time.deltaTime;
			tan_GlobalManager.heroAction=HeroAct.Walking;

		}else
		if (Input.GetKey(KeyCode.A)) {
			vecHeroPositon.x-=floHeroMovingSpeed*Time.deltaTime;
			tan_GlobalManager.heroAction=HeroAct.Walking;

		}else
		if (Input.GetKey(KeyCode.D)) {
			vecHeroPositon.x+=floHeroMovingSpeed*Time.deltaTime;
			tan_GlobalManager.heroAction=HeroAct.Walking;
		}else {tan_GlobalManager.heroAction=HeroAct.Standing;}

		character_HeroCtrl.Move(this.transform.TransformDirection(vecHeroPositon));

	}
}
