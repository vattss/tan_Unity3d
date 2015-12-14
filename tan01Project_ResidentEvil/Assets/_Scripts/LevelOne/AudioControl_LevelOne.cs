/***
 * 
 *    Title:  "生化危机" 项目
 *            第一关卡： 背景音乐与部分音效集中控制
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

public class AudioControl_LevelOne : MonoBehaviour {

    public AudioClip AudioClip_BGMusic_1;        //背景音乐剪辑
    public AudioClip AudioClip_BGMusic_2;
    public AudioClip AudioClip_BGMusic_3;
    public AudioClip AudioClip_BGMusic_4;

    public string StrFooterAudioEffectName;      //脚本声名称


	void Start () 
	{
	    //背景音效的播放处理
        InvokeRepeating("CheckProjectBackgroundAudio",1F,5F);

        //脚本音效处理
        InvokeRepeating("CheckHeroFooterAudioEffect", 0.5F, 0.5F);
	}//Start_end

    /// <summary>
    /// 检测项目的背景音效
    /// </summary>
    private void CheckProjectBackgroundAudio()
    {
        switch (GlobalManger.HeroPositionInfo)
        {
            case HeroPosition.None:
                break;
            case HeroPosition.MontainFooter:
                AudioManager.PlayBackground(AudioClip_BGMusic_1);
                break;
            case HeroPosition.VillageHouse:
                AudioManager.PlayBackground(AudioClip_BGMusic_3);
                break;
            case HeroPosition.Factor:
                AudioManager.PlayBackground(AudioClip_BGMusic_4);
                break;
            case HeroPosition.Other:
                AudioManager.PlayBackground(AudioClip_BGMusic_2);
                break;
            default:
                break;
        }
    }//CheckProjectBackgroundAudio_end

    //检测英雄的脚步声
    private void CheckHeroFooterAudioEffect()
    {
        switch (GlobalManger.HeroActionInfo)
        {
            case HeroAction.None:
                break;
            case HeroAction.Standing:
                break;
            case HeroAction.Walking:
                AudioManager.Play(StrFooterAudioEffectName);                   
                break;
            case HeroAction.Runing:
                break;
            case HeroAction.Failing:
                break;
            default:
                break;
        }
    }
        

}//Class_end
