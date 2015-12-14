/***
 * 
 *    Title:  学习 Vector.Lerp() 方法。（向量插值）
 *            基本原理解释。
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

public class TestLerp : MonoBehaviour {

    public Transform TargetObj;     //目标位置

	void Start () 
	{
	
	}//Start_end
	
	void Update () 
	{
        this.transform.position = Vector3.Lerp(this.transform.position, TargetObj.position,Time.deltaTime*3);
	}//Update_end

}//Class_end
