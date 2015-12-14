using UnityEngine;
using System.Collections;

public class tan_CheckPlauEffect : MonoBehaviour {
	public string strHeroName;
	// Use this for initialization
	void Start () {
	
	}
	//触发器检测是否播放踩水声
	void OnTriggerStay(Collider col)
	{
 		if (col.collider.name.Equals(strHeroName)) {
			this.audio.Play();
 				}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
