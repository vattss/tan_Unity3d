/***
 * 
 *    Title:  "生化危机" 项目
 *           NGUI Button 音量控制（替代NGUI 相关类）
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

public class ChangeNGUIButtonVolumns : MonoBehaviour {
    public string strNGUIButton_ChangeAudioVolumns;  //改变Button的音频名称 

	void Start () 
	{
	
	}//Start_end

    //调节音量Button_1
    public void SetButtonAudioEffect_ChangeVolums()
    {
        AudioManager.Play(strNGUIButton_ChangeAudioVolumns);
    }

}//Class_end
