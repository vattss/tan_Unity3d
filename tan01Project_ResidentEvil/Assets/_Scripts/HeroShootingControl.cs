/***
 * 
 *    Title:  “生化危机”项目
 *             射击控制
 *
 *    Description: 
 *           [当前脚本的具体作用]
 *
 *    Author: Liu
 * 
 *   
 *    Date:  2014
 *
 *
 *    Version:  1.0
 *
 *
 *    Modify recoder:
 * 
 *       
 *
 * 
 * 
 */
using UnityEngine;
using System.Collections;

public class HeroShootingControl : MonoBehaviour {
    //public GameObject GoEnemyObj_1;                      //敌人
    public string StrGunType_GunName;                      //普通枪支音效
    public string StrEnmyShootingName;                     //射击名称

    public LayerMask LayMask_GameGunMask;                  //层蒙版
    private Transform _TranGunEndPoint;                    //枪口的方位
    private Transform _TranCamera;                         //摄像机方位
    

	void Start () 
	{
        //摄像机的方位
        _TranCamera=Camera.main.transform;
        //枪口的方位
        _TranGunEndPoint = _TranCamera.FindChild("G_M4_icedragon/GunEndPoint");
	}//Start_end
	
	void Update () 
	{
        //射击敌人
        if (GlobalManger.Bloods > 0.1F)
        {
            ShootingEnemy();
        }
        else
        {
            Debug.LogWarning("英雄已经GameOver,不允许继续射击！");
        }        
	}//Update_end

    private void ShootingEnemy()
    {
        //射线投射
        RaycastHit hit;
        bool boolResult = Physics.Raycast(_TranGunEndPoint.position, _TranCamera.TransformDirection(Vector3.forward), out hit, 200, LayMask_GameGunMask);
        //测试
        Debug.DrawRay(_TranGunEndPoint.position, _TranCamera.TransformDirection(Vector3.forward),Color.red);

        if(Input.GetMouseButtonDown(0))
        {
            AudioManager.Play(StrGunType_GunName);
            if (boolResult)
            {
                if (hit.collider.name.Equals(StrEnmyShootingName))
                {
                    print("击中敌人");
                    //调用敌人的受伤方法。
                    //GoEnemyObj_1.SendMessage("OnShootHurt", 1,SendMessageOptions.DontRequireReceiver);
                    hit.collider.gameObject.GetComponent<EnemyAI>().OnShootHurt(1);
                }
            }            
        }    
    }

}//Class_end
