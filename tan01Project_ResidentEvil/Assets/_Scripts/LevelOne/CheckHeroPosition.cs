/***
 * 
 *    Title:  "生化危机" 项目
 *            第一场景： 检测主人公的位置
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

public class CheckHeroPosition : MonoBehaviour {
    public Transform TranHero;                             //英雄的方位

	void Start () 
	{
        InvokeRepeating("IdentifyHeroPosition",1F,5F);
	}//Start_end

    /// <summary>
    /// 识别主人公的位置信息
    /// </summary>
    private void IdentifyHeroPosition()
    { 
        //山脚下
        if(TranHero.transform.position.x<=200 &&  (TranHero.transform.position.z>=150 && TranHero.transform.position.z<=300))
        {
            GlobalManger.HeroPositionInfo = HeroPosition.MontainFooter;
            //print("[CheckHeroPosition.cs/IdentifyHeroPosition] 在山脚下");
        }
        //小屋
        else if((TranHero.transform.position.x>300 && TranHero.transform.position.x<350) &&(TranHero.transform.position.z<200))
        {
            GlobalManger.HeroPositionInfo = HeroPosition.VillageHouse;
            //print("[CheckHeroPosition.cs/IdentifyHeroPosition] 在小屋区域");
        }
        //化工厂
        else if (TranHero.transform.position.x > 345 && TranHero.transform.position.z>380)
        {
            GlobalManger.HeroPositionInfo = HeroPosition.Factor;
            //print("[CheckHeroPosition.cs/IdentifyHeroPosition] 化工厂区域");
        }
        //其他位置
        else{
            GlobalManger.HeroPositionInfo = HeroPosition.Other;
            //print("[CheckHeroPosition.cs/IdentifyHeroPosition] 在其他区域");
        }
    }
	

}//Class_end
