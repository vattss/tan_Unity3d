/***
 * 
 *    Title:  "生化危机" 项目
 *             场景管理器
 *             1： 负责敌人的动态生成。
 *             2:  （道具、枪支、子弹、钥匙等道具的生成）
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

public class ScenesManager_LevelOne : MonoBehaviour {
    public GameObject GoEnmyPerfab;                        //招手僵尸
    public Transform TraBirthPosition_MontainFooter;       //山脚下
    public Transform TraBirthPosition_MontainFooterArea_1; 
    public Transform TraBirthPosition_MontainFooterArea_2;
    public Transform TraBirthPosition_VillageHouse;        //小屋
    public Transform TraBirthPosition_VillageHouse_1;
    public Transform TraBirthPosition_VillageHouse_2;
    public Transform TraBirthPosition_Factory;             //化工厂

    private bool _boolIsBirth = true;                      //是否产生

	void Start () 
	{
        InvokeRepeating("CreateEnimyPerfab",2F,5F);
	}//Start_end

    //创建敌人
    private void CreateEnimyPerfab()
    { 
        //在山脚下
        if(GlobalManger.HeroPositionInfo==HeroPosition.MontainFooter)
        {
            if (_boolIsBirth)
            {
                _boolIsBirth = false;
                //print("第1 波");
                CreatePerfabe(GoEnmyPerfab, TraBirthPosition_MontainFooterArea_1.transform.position, 3);

                //print("第2 波");
                CreatePerfabe(GoEnmyPerfab, TraBirthPosition_VillageHouse_1.transform.position, 5);
            }
        }
        //乡村小屋
        else if (GlobalManger.HeroPositionInfo == HeroPosition.VillageHouse)
        {
            //思路： 取得预设，取得生成位置以及生成的数量
            if (_boolIsBirth)
            {
                _boolIsBirth = false;
            //print("第 3 波");
            CreatePerfabe(GoEnmyPerfab, TraBirthPosition_VillageHouse_1.transform.position, 5);

            //print("第 4 波");
            CreatePerfabe(GoEnmyPerfab, TraBirthPosition_VillageHouse_2.transform.position, 5);            
            }
        }
        //化工厂
        else if (GlobalManger.HeroPositionInfo == HeroPosition.Factor)
        {
            //思路： 取得预设，取得生成位置以及生成的数量
        }
    }

    /// <summary>
    /// 克隆预设
    /// </summary>
    /// <param name="goPerfabe">预设</param>
    /// <param name="VecBirthPosition">创建的位置</param>
    /// <param name="intCloneNumber">创建数量</param>
    private void CreatePerfabe(GameObject goPerfabe,Vector3 VecBirthPosition,int intCloneNumber)
    {
        for (int i = 1; i <=intCloneNumber; i++)
        {
            GameObject goClonePerfab=(GameObject)GameObject.Instantiate(goPerfabe);
            goClonePerfab.transform.position = new Vector3(VecBirthPosition.x  + i, VecBirthPosition.y, VecBirthPosition.z);
            goClonePerfab.SetActive(true);
        }
    }
}//Class_end
