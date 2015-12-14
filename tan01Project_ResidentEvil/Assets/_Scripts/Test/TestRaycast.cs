/***
 * 
 *    Title:   学习“射线”知识点。
 *             1: 学习“射线”基本原理。
 *             2：应用“射线” 做简易的射击练习Demo
 *
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

public class TestRaycast : MonoBehaviour {
    public GameObject GoShootingTargetObj;                 //射击目标    

    private Vector3 _VecRemoteRayPosition;                 //射线点位置
    private GameObject GoBullet;                           //子弹

	void Start () 
	{
        for (int i = 1; i <=5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                GameObject goClone = (GameObject)GameObject.Instantiate(GoShootingTargetObj);
                goClone.transform.position = new Vector3(goClone.transform.position.x + j, goClone.transform.position.y+i, goClone.transform.position.z);
            }            
        }

	}//Start_end	
	
	void FixedUpdate () 
	{
        //定义射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //射线透射
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            //print("射线碰到的物体是："+hit.collider.name);
            _VecRemoteRayPosition = hit.point;
        }

        //射线调试技术
        Debug.DrawRay(Camera.main.transform.position, _VecRemoteRayPosition - Camera.main.transform.position, Color.red);
        //鼠标点击射击
        if(Input.GetMouseButtonDown(0))
        {
            //创建子弹
            GoBullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //给子弹定义方位。
            GoBullet.transform.position = Camera.main.transform.position;
            //给子弹添加刚体
            GoBullet.AddComponent<Rigidbody>();
            //给子弹添加冲击力。
            GoBullet.rigidbody.AddForce((_VecRemoteRayPosition - GoBullet.transform.position)*10,ForceMode.Impulse);
            //添加脚本
            GoBullet.AddComponent("OnInvisiable");
        }
        
	}//Update_end

}//Class_end
