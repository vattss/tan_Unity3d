using UnityEngine;
using System.Collections;

public class tan_EnemyAI : MonoBehaviour {
	public Transform tranHero;
	private NavMeshAgent agent;
	public int  enemyBloodValue;
	//导航寻路
	public AnimationClip aniClipFindHero;
	public AnimationClip aniClipAttack;
	// Use this for initialization
	void Start () {
		agent=this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		//按照距离进行"思考"
		float _floDistance=Vector3.Distance(this.transform.position,tranHero.transform.position);
		if (_floDistance>=200) 
		{
			
		}else if (_floDistance<200&&_floDistance>=3F)
			{ 
			//导航寻路
			if (agent&&tranHero) 
				{
				agent.SetDestination(tranHero.transform.position);
				
				}
			//朝向Hero
			this.tranHero.LookAt(tranHero.transform.position);
				
			//走路动画
			this.animation.Play(aniClipFindHero.name);
			}else if (_floDistance<3F) 
				{
				//关注
				this.tranHero.LookAt(tranHero.transform.position);
			//英雄的攻击，掉血
				this.animation.Play(aniClipAttack.name);
				}
   	}
	private void EnemyDeath()
	{
		++tan_GlobalManager.intEnemyValues;
		++tan_GlobalManager.intGetScore;
		Destroy(this.gameObject);
	}
	public void BeShooted(int _reduceBlood)
	{
		print("Enemy's blood Valme:"+enemyBloodValue);
		enemyBloodValue-=_reduceBlood;
	}
}
