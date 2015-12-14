/***
 * 
 *    Title:  当本游戏对象离开视锥体。
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

public class OnInvisiable : MonoBehaviour {


	void Start () 
	{
	
	}//Start_end

    //离开视锥体
    void OnBecameInvisible()
    {
        print("已经销毁！");
        Destroy(this.gameObject);
    }

}//Class_end
