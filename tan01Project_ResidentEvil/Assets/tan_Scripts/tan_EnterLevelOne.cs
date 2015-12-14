/*
 *Project: Kupao01							Scene:level1
 *Version:Day8_Chapter4_15052501
 *Function:
 *
 *
 * 
 *
 * 
 **/ 
using UnityEngine;
using System.Collections;

public class tan_EnterLevelOne : MonoBehaviour {
	private AsyncOperation asyncOpera;
	public string strNextLevelName;
	void Start () {
		StartCoroutine("AsyncEnterNextLevel");
	}//StartEnd
 IEnumerator AsyncEnterNextLevel()
	{
		asyncOpera=Application.LoadLevelAsync(strNextLevelName);
		yield return asyncOpera;
	}
	void Update () {
	
	}//UpdateEnd
	
}//classEnd
