using UnityEngine;
using System.Collections;

public class tan_AudioControlLevelOne : MonoBehaviour {
	public AudioClip audioClip_BGMusic_01;
	public AudioClip audioClip_BGMusic_02;
	public AudioClip audioClip_BGMusic_03;
	public AudioClip audioClip_BGMusic_04;

	public string strFootAudioEffectName;
	 
	// Use this for initialization
	void Start () {
		InvokeRepeating("CheckProjecBackGround",0,2);
		InvokeRepeating("CheckProjectEffect",0.1F,0.5F);
	}
	private void CheckProjecBackGround()
	{
		switch (tan_GlobalManager.heroPosition) 
		{
		case HeroPosi.None:
			break;
		case HeroPosi.Mountain:
			tan_AudioManager.PlayBackGround(audioClip_BGMusic_01);
			break;
		case HeroPosi.SeaHouse:
			tan_AudioManager.PlayBackGround(audioClip_BGMusic_03);
			break;
		case HeroPosi.Factory:
			tan_AudioManager.PlayBackGround(audioClip_BGMusic_04);
			break;
				default:
						break;
		}
	}
	private void CheckProjectEffect()
	{
		switch (tan_GlobalManager.heroAction) {
		case HeroAct.None:
 				break;
		case HeroAct.Standing:
			break;
		case HeroAct.Walking:
			tan_AudioManager.PlayEffect(strFootAudioEffectName);
			break;
		case HeroAct.Running:
			break;
				default:
						break;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
