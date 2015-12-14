using UnityEngine;
using System.Collections;

public class tan_OnBecomeVisiable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void  OnBecameInvisible()
	{
		print("I'm destoryed");
		Destroy(this.gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
