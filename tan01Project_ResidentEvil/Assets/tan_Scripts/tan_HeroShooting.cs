using UnityEngine;
using System.Collections;

public class tan_HeroShooting : MonoBehaviour {
	public GameObject enemy01;
	public LayerMask layerMaskGunShoot;
	private Transform tranCamera;
	private Transform tranGunShootPoint;

	public string strGunTypeGunName;
	// Use this for initialization
	void Start () {
	tranCamera=Camera.main.transform;
		tranGunShootPoint=tranCamera.Find("G_M4_icedragon/objGunShootPoint");
	}
	
	// Update is called once per frame
	void Update () {
		 ShootEnemy();
		 
	}
	public void ShootEnemy()
	{
		RaycastHit hit;
		bool Result=Physics.Raycast(tranGunShootPoint.position,tranCamera.TransformDirection(Vector3.forward),out hit,200,layerMaskGunShoot);
		Debug.DrawRay(tranGunShootPoint.position,tranCamera.TransformDirection(Vector3.forward),Color.red);
		if (Input.GetMouseButtonDown(0)) 
		{
			tan_AudioManager.PlayEffect(strGunTypeGunName);
				if (Result) 
			{
				if (hit.collider.name.Equals("Zombie_face"))
				{
					print("击中的对象是："+hit.collider.name);
					enemy01.SendMessage("BeShooted",1);	

				}
			 
			} 
		}
	}

}
