using UnityEngine;
using System.Collections;

public class tan_ChangeButtonVolums : MonoBehaviour {
	public string strGetButtonVolumName;

	// Use this for initialization
	void Start () {
	
	}
	public void ChangeButtonVolum()
	{
		tan_AudioManager.PlayEffect(strGetButtonVolumName);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
