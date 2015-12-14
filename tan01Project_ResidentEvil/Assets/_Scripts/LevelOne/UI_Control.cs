/***
 * 
 *    Title:  "生化危机" 项目
 *            第一场景： UI 显示控制
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

public class UI_Control : MonoBehaviour {
    public UISlider UISlider_Bloods;                       //血量条
    public UILabel UILabel_SkillEnemy;                     //射杀敌人数量
    public GameObject goGaveOverPanel;                     //游戏结束面板

	void Start () 
	{
	
	}//Start_end
	
	void Update () 
	{
        UISlider_Bloods.value = GlobalManger.Bloods;
        UILabel_SkillEnemy.text = GlobalManger.SkillEnemyNumber.ToString();
        //游戏结束判断
        if(GlobalManger.Bloods<=0.1F)
        {
            goGaveOverPanel.GetComponent<TweenPosition>().PlayForward();
        }
	}//Update_end

}//Class_end
