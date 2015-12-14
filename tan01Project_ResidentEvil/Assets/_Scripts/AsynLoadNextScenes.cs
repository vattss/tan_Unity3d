/***
 * 
 *    Title:  "生化危机" 项目
 *            异步加载机制。
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

public class AsynLoadNextScenes : MonoBehaviour {
    public string strNextScenesName;                       //下一关卡的名称
    private AsyncOperation AsyLoadResult;

	void Start () 
	{
        StartCoroutine("EnterNextScenes");
	}//Start_end

    IEnumerator EnterNextScenes()
    {
        AsyLoadResult = Application.LoadLevelAsync(strNextScenesName);
        yield return AsyLoadResult;        
    }

	void Update () 
	{
	
	}//Update_end

}//Class_end
