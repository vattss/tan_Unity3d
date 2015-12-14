using UnityEngine;
using System.Collections;

public class tan_ChangeSlider : MonoBehaviour {
	private float floPosition;
	private bool isPressed;
	private float rebackValues=5;

	public string AudioClipName_BackGround;
	public string audioClipName_Effect;
	// Use this for initialization
	void Start () {
	tan_AudioManager.PlayBackGround(AudioClipName_BackGround);
	}

	void  OnPress(bool _isPressed)
	{
		isPressed=_isPressed;
		if (!_isPressed) {
			floPosition=0;
				}
	}
	void OnDrag(Vector2 _vec2)
	{
		if (isPressed) {
			floPosition+=_vec2.x;
			this.transform.Translate(new Vector3(floPosition/1000,0,0),Space.World);
				}

	}
	// Update is called once per frame
	void Update () {
	if (this.transform.localPosition.x>0) {
			this.transform.localPosition=Vector3.Lerp(this.transform.localPosition,new Vector3(0,0,0),Time.deltaTime*rebackValues);
				}
	if (this.transform.localPosition.x<=-3200) {
			this.transform.localPosition=Vector3.Lerp(this.transform.localPosition,new Vector3(-3200,0,0),Time.deltaTime*rebackValues);

		}
	
		//整版受限移动
	if (this.transform.localPosition.x<0&&this.transform.localPosition.x>-800) {
			this.transform.localPosition=Vector3.Lerp(this.transform.localPosition,new Vector3(-800,0,0),Time.deltaTime*rebackValues);
			if (Mathf.RoundToInt(this.transform.localPosition.x)==-800) {
				tan_AudioManager.PlayEffect(audioClipName_Effect);
				this.transform.localPosition=new Vector3(-800,0,0);

			}
		}
	if (this.transform.localPosition.x<-800&&this.transform.localPosition.x>-1600) {
			this.transform.localPosition=Vector3.Lerp(this.transform.localPosition,new Vector3(-1600,0,0),Time.deltaTime*rebackValues);
		}
	if (this.transform.localPosition.x<-1600&&this.transform.localPosition.x>-2400) {
			this.transform.localPosition=Vector3.Lerp(this.transform.localPosition,new Vector3(-2400,0,0),Time.deltaTime*rebackValues);
		}

	if (this.transform.localPosition.x<-2400&&this.transform.localPosition.x>-3200) {
			this.transform.localPosition=Vector3.Lerp(this.transform.localPosition,new Vector3(-3200,0,0),Time.deltaTime*rebackValues);
		}
	}
}
