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

public class tan_EnterLoadingLevel : MonoBehaviour {
	public string strLoadingLevel;
	void Start () {
	
	}//StartEnd
	
	void OnClick()
	{
		Application.LoadLevel(strLoadingLevel);
	}

	
	void Update () {
	
	}//UpdateEnd
	
}//classEnd
