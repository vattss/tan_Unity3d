/***
 * 
 *    Title:  "生化危机" 项目
 *            进入下一场景
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

public class EnterNextLevel : MonoBehaviour
{
    public string strNextLevelName;                        //下一关卡的名称

	void Start () {}//Start_end

    void OnClick()
    {
        Application.LoadLevel(strNextLevelName);
    }

}//Class_end
