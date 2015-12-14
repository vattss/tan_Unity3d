/*
 *Project: 					Scene:
 *Version:Day8_Chapter4_15052501
 *Function:
 *		学习四元数的旋转固定角度和插值旋转固定角度
 *
 *
 * 
 *
 * 
 **/ 
using UnityEngine;
using System.Collections;

public class tan_LearnEuler : MonoBehaviour {
	private bool isStartRotate=false;
	void Start () {
	
	}//StartEnd
	
	void OnGUI () {
		if (GUILayout.Button("旋转固定角度",GUILayout.Height(50))) {
			gameObject.transform.rotation=Quaternion.Euler(0,50,0);
				}
		if (GUILayout.Button("插值旋转固定角度",GUILayout.Height(50))) {
				isStartRotate=true;
				}
	}//OnGUIEnd
	
	void Update () {
		if (isStartRotate) {
			gameObject.transform.rotation=Quaternion.Slerp(gameObject.transform.rotation,Quaternion.Euler(0,50,0),Time.time*0.1f);
				}
	}//UpdateEnd
	
}//classEnd
