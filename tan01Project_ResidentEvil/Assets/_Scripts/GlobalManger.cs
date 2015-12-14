/***
 * 
 *    Title:  "生化危机" 项目
 *            全局管理类
 *
 *
 *    Description: 
 *             跨场景数据传值
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

public class GlobalManger : MonoBehaviour {
    public static float AudioBackgroundVolumns =0.5F;                //背景音量
    public static float AudioEffectVolumns = 1F;                     //音效音量
    public static int SkillEnemyNumber = 0;                          //杀敌数量
    public static int GameScore = 0;                                 //游戏分数
    public static float Bloods = 1F;                                 //英雄血量

    public static HeroPosition HeroPositionInfo = HeroPosition.None; //位置
    public static HeroAction HeroActionInfo = HeroAction.None;       //动作
    public static GunType HeroGunType = GunType.None;                //枪支类型




}//Class_end
