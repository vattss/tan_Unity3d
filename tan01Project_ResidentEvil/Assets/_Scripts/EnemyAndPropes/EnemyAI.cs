/***
 * 
 *    Title:  "生化危机"项目
 *            敌人AI 脚本。
 *
 *    Description: 
 *           [当前脚本的具体作用]
 *
 *    Author: Liu
 * 
 *   
 *    Date:  2014
 *
 *
 *    Version:  1.0
 *
 *
 *    Modify recoder:
 * 
 *       
 *
 * 
 * 
 */
using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    public int IntEnemyLife=2;                            //敌人的血量
    private Transform TranHero;                           //主角的方位
    public AnimationClip AniClip_Finding;                 //寻找英雄动画
    public AnimationClip AniClip_Attack;                  //攻击英雄动画
    
    private NavMeshAgent agent;                           //导航代理



	void Start () 
	{
        //英雄的方位
        TranHero = GameObject.Find("HeroPlayer").transform;
        //得到导航代理
        agent = this.GetComponent<NavMeshAgent>();
	}//Start_end	
	
	void Update () 
	{
        float floDistance=Vector3.Distance(this.transform.position, TranHero.transform.position);

        //按照距离进行“思考”
        //观察
        if (floDistance>=200F)
        {
            //。。。。
        }
        //寻路
        else if (floDistance < 200F && floDistance>=3F)
        {
            //导航寻路
            if (agent && TranHero)
            {
                agent.SetDestination(TranHero.transform.position);
            }
            //关注
            this.transform.LookAt(TranHero.transform.position);
            //走路动画
            this.animation.Play(AniClip_Finding.name);
        }
        //攻击
        else if (floDistance<3F)
        {
            //关注
            this.transform.LookAt(TranHero.transform.position);
            //攻击动画
            this.animation.Play(AniClip_Attack.name); 
            //英雄被攻击，掉血。
            GlobalManger.Bloods = GlobalManger.Bloods - (GlobalManger.Bloods*0.05F);
        }
       
	    //判断死亡
        if (IntEnemyLife<=0)
        {
            this.OnDeath();
        }
	}//Update_end


    /// <summary>
    /// 敌人死亡
    /// </summary>
    private void OnDeath()
    { 
        //增加杀敌数量。
        ++GlobalManger.SkillEnemyNumber;
        //增加分数
        ++GlobalManger.GameScore;
        //销毁
        Destroy(this.gameObject);
    }

    //射击受伤。
    public void OnShootHurt(int intBlood)
    {
        //print("射中了敌人，敌人的血量：" + IntEnemyLife);
        IntEnemyLife-=intBlood;
    }

}//Class_end
