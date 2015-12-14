/***
 * 
 *    Title:  "生化危机"项目
 *            英雄的移动控制
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

public class HeroMovingControl : MonoBehaviour {
    public float _FloHeroMovingSpeed = 1F;                 //运动的速度
    public float _FloHeroGravity=1F;                       //英雄的重力

    private CharacterController _ChaHeroControl;           //英雄角色控制器
    private Vector3 _VecHeroMoving;                        //英雄的移动

    private Vector3 _VecCameraRotaion;                     //摄像机旋转
    private Transform _TranCamera;                         //（英雄）摄像机的方位


	void Start () 
	{
        //不显示光标
        Screen.showCursor = false;
        //光标锁定
        Screen.lockCursor = true;
        //英雄站立
        GlobalManger.HeroActionInfo = HeroAction.Standing;
        //得到角色控制器
        _ChaHeroControl = this.GetComponent<CharacterController>();
        //得到摄像机的方位
        _TranCamera = Camera.main.transform;
	}//Start_end

    void Update() 
	{
        if (GlobalManger.Bloods > 0.1F)
        {
            HeroMoving();
        }
        else {
            Debug.LogWarning("英雄已经GameOver");
        }
	}//Update_end

    private void HeroMoving()
    {
        /*  英雄的旋转*/
        //摄像机旋转
        float FloX = Input.GetAxis("Mouse X");             //取得鼠标水平位移
        float FloY = Input.GetAxis("Mouse Y");             //取得鼠标垂直位移
        _VecCameraRotaion.y += FloX;
        _VecCameraRotaion.x -= FloY;
        _TranCamera.transform.eulerAngles = _VecCameraRotaion;
        //英雄的旋转
        this.transform.eulerAngles = new Vector3(0, _VecCameraRotaion.y, 0);

        /* 英雄的移动 */
        _VecHeroMoving = Vector3.zero;
        //英雄的重力
        _VecHeroMoving.y -= _FloHeroGravity;
        if (Input.GetKey(KeyCode.W))
        {
            _VecHeroMoving.z += _FloHeroMovingSpeed * Time.deltaTime;
            GlobalManger.HeroActionInfo = HeroAction.Walking;
        }else if (Input.GetKey(KeyCode.S))
        {
            _VecHeroMoving.z -= _FloHeroMovingSpeed * Time.deltaTime;
            GlobalManger.HeroActionInfo = HeroAction.Walking;
        }else if (Input.GetKey(KeyCode.A))
        {
            _VecHeroMoving.x -= _FloHeroMovingSpeed * Time.deltaTime;
            GlobalManger.HeroActionInfo = HeroAction.Walking;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _VecHeroMoving.x += _FloHeroMovingSpeed * Time.deltaTime;
            GlobalManger.HeroActionInfo = HeroAction.Walking;
        }
        else {
            GlobalManger.HeroActionInfo = HeroAction.Standing;
        }

        //Move() 方法必须使用世界坐标系。
        _ChaHeroControl.Move(this.transform.TransformDirection(_VecHeroMoving));        
    }

}//Class_end
