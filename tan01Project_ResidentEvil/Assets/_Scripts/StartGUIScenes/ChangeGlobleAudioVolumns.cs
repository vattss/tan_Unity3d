/***
 * 
 *    Title:  "生化危机" 项目
 *            改变全局音量。
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

public class ChangeGlobleAudioVolumns : MonoBehaviour {
    public UISlider UISlider_Background;           //背景音乐滑动条
    public UISlider UISlider_AudioEffect;          //音效滑动条

	void Start () 
	{
	
	}//Start_end

    /// <summary>
    /// 改变背景音量
    /// </summary>
    public void ChangeBackgroundAudioVolumns()
    {
        AudioManager.SetAudioBackgroundVolumns(UISlider_Background.value);
    }

    //改变音效音量
    public void ChangeAudioEffectVolumns()
    {
        AudioManager.SetAudioEffectVolumns(UISlider_AudioEffect.value);
    }

}//Class_end
