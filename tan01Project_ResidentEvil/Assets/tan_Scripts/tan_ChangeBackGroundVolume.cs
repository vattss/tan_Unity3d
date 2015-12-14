using UnityEngine;
using System.Collections;

public class tan_ChangeBackGroundVolume : MonoBehaviour {
	public UISlider uisliderBackGround;
	public UISlider uisliderEffect;
	// Use this for initialization
	void Start () {
	
	}
	/// <summary>
	/// Changes the back ground volume.
	/// </summary>
	public void ChangeBackGroundVolume()
	{
		tan_AudioManager.SetBackGrounVolume(uisliderBackGround.value);

	}
	public void ChangeEffectVolume()
	{
		tan_AudioManager.SetEffectVolume(uisliderEffect.value);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
