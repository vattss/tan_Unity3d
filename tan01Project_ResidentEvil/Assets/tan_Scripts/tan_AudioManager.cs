using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tan_AudioManager : MonoBehaviour {
	public AudioClip[]	audioClipArry;
	private static Dictionary<string,AudioClip> dicAudioClipLib;

	private static  AudioSource[] audioSourceArry;
	private static AudioSource  audioSourceBackGround;
	private static AudioSource 	audioSourceEffect;

	// Use this for initialization
	void Awake () {
	dicAudioClipLib=new Dictionary<string,AudioClip >();
	foreach (AudioClip _audiClip in audioClipArry) 
		{
		dicAudioClipLib.Add(_audiClip.name,_audiClip);
		}//Endforeach
	audioSourceArry=this.GetComponents<AudioSource>();
	audioSourceBackGround=audioSourceArry[0];
	audioSourceEffect=audioSourceArry[1];
	
	}
	/// <summary>
	///  播放背景音乐
	/// </summary>
	/// <param name="_audiClip">_audi clip.</param>
	public static void PlayBackGround(AudioClip _audiClip)
	{
		if (audioSourceBackGround.clip==_audiClip) {
			return;
				}
		audioSourceBackGround.volume=tan_GlobalManager.floVolumeOfBackGround;
		if (_audiClip) {
			audioSourceBackGround.clip=_audiClip;
			audioSourceBackGround.Play();
		}else Debug.LogWarning("[tan_AudioManager/PlayBackGround _audiClip==null ! Please Check !]");
	}
	
	public static void PlayBackGround(string _strClipName)
	{
		if (!string.IsNullOrEmpty(_strClipName)) {
			PlayBackGround(dicAudioClipLib[_strClipName]);
		}else Debug.LogWarning("[tan_AudioManager/PlayBackGround _strClipName==null ! Please Check !]");
	}//EndPlayBackGround

	/// <summary>
	///播放音效
	/// </summary>
	/// <param name="_audiClip">_audi clip.</param>
	private static void PlayEffect(AudioClip _audiClip)
	{
		if (_audiClip) {
			audioSourceEffect.clip=_audiClip;
			audioSourceEffect.Play();
		}else Debug.LogWarning("[tan_AudioManager/PlayEffect _audiClip==null ! Please Check !]");
	}
	
	public static void PlayEffect(string _strClipName)
	{
		if (!string.IsNullOrEmpty(_strClipName)) {
			PlayEffect(dicAudioClipLib[_strClipName]);
		}else Debug.LogWarning("[tan_AudioManager/PlayEffect _audiClip==null ! Please Check !]");
	}//EndPlayEffect
	/// <summary>
	/// 改变音量
	/// </summary>
	public static void SetBackGrounVolume(float _BGV)
	{
		audioSourceBackGround.volume=_BGV;
		tan_GlobalManager.floVolumeOfBackGround=_BGV;
	}
	public static void SetEffectVolume(float _EV)
	{
		audioSourceEffect.volume=_EV;
		tan_GlobalManager.floVolumeOfEffect=_EV;
	}
				
	
	// Update is called once per frame
	void Update () {
	
	}
}
