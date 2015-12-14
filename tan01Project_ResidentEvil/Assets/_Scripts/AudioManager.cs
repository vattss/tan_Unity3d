/***
 * 
 *    Title:  "生化危机" 项目
 *            音频封装类。(程序的重构)
 *
 *
 *    Description: 
 *           [当前脚本的具体作用]
 *
 *    Author: LiuGuozhu
 * 
 *   
 *    Date:  2014.08
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
using System.Collections.Generic; //泛型集合命名控件

public class AudioManager : MonoBehaviour {
    public AudioClip[] AudioClipArray;                            //剪辑数组
    private static Dictionary<string, AudioClip> _DicAudioClipLib;//音频库

    private static AudioSource[] _AudioSourceArray;               //音频源数组
    private static AudioSource _AudioSource_BackgroundAudio;      //背景音乐
    private static AudioSource _AudioSource_AudioEffect;          //音频源


	void Awake() 
	{
	    //音频库加载
        _DicAudioClipLib = new Dictionary<string, AudioClip>();
        foreach (AudioClip audioClip in AudioClipArray)
        {
            _DicAudioClipLib.Add(audioClip.name,audioClip);
        }
        //处理音频源
        _AudioSourceArray=this.GetComponents<AudioSource>();
        _AudioSource_BackgroundAudio = _AudioSourceArray[0];
        _AudioSource_AudioEffect = _AudioSourceArray[1];
	}//Start_end

    //播放背景音乐
    public static void PlayBackground(AudioClip audioClip)
    {
        //防止背景音乐的重复播放。
        if (_AudioSource_BackgroundAudio.clip == audioClip)
        {
            return;
        }

        //处理全局背景音乐音量
        _AudioSource_BackgroundAudio.volume = GlobalManger.AudioBackgroundVolumns;

        if (audioClip)
        {
            _AudioSource_BackgroundAudio.clip = audioClip;
            _AudioSource_BackgroundAudio.Play();
        }else{
            Debug.LogWarning("[AudioManager.cs/PlayBackground()] audioClip==null ! Please Check! ");
        }
    }

    /// <summary>
    /// 播放背景音乐
    /// </summary>
    /// <param name="strAudioName"></param>
    public static void PlayBackground(string strAudioName)
    {
        if (!string.IsNullOrEmpty(strAudioName))
        {
            PlayBackground(_DicAudioClipLib[strAudioName]);
        }else{
            Debug.LogWarning("[AudioManager.cs/PlayBackground()] strAudioName==null ! Please Check! ");            
        }
    }

    //播放音效
    private static void Play(AudioClip audioClip)
    {
        //处理全局音效音量
        _AudioSource_AudioEffect.volume = GlobalManger.AudioEffectVolumns;

        if (audioClip)
        {
            _AudioSource_AudioEffect.clip = audioClip;
            _AudioSource_AudioEffect.Play();
        }
        else
        {
            Debug.LogWarning("[AudioManager.cs/Play()] audioClip==null ! Please Check! ");
        }
    }

    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="strAudioEffctName"></param>
    public static void Play(string strAudioEffctName)
    {
        if (!string.IsNullOrEmpty(strAudioEffctName))
        {
            Play(_DicAudioClipLib[strAudioEffctName]);
        }
        else
        {
            Debug.LogWarning("[AudioManager.cs/Play()] strAudioEffctName==null ! Please Check! ");
        }
    }

    /// <summary>
    /// 改变背景音量
    /// </summary>
    /// <param name="floAudioBGVolumns"></param>
    public static void SetAudioBackgroundVolumns(float floAudioBGVolumns)
    {
        _AudioSource_BackgroundAudio.volume = floAudioBGVolumns;
        GlobalManger.AudioBackgroundVolumns = floAudioBGVolumns;
    }

    //改变音效音量
    public static void SetAudioEffectVolumns(float floAudioEffectVolumns)
    {
        _AudioSource_AudioEffect.volume = floAudioEffectVolumns;
        GlobalManger.AudioEffectVolumns = floAudioEffectVolumns;
    }

	

}//Class_end
