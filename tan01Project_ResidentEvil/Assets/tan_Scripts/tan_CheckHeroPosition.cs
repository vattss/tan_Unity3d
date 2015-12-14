using UnityEngine;
using System.Collections;

public class tan_CheckHeroPosition : MonoBehaviour {
	public Transform tranHero;
	// Use this for initialization
	void Start () {
		InvokeRepeating("IndentifyHeroPosition",0,2);
	}

	private void IndentifyHeroPosition ()
	{
		if (tranHero.transform.position.x<400&&tranHero.transform.position.z>450){
			tan_GlobalManager.heroPosition=HeroPosi.Mountain;
			print("Hero come to Mountation");
		}else if (tranHero.transform.position.x>400&&tranHero.transform.position.x<=475&&tranHero.transform.position.z<=500) {
			tan_GlobalManager.heroPosition=HeroPosi.SeaHouse;
			print ("Hero come to SeaHouse");
		}else if (tranHero.transform.position.x>519&&tranHero.transform.position.z>430) {
			tan_GlobalManager.heroPosition=HeroPosi.Factory;
			print("Hero come to Factory");
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
