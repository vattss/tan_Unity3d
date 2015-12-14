/***
 * 
 *    Title:  "生化危机" 项目
 *            水域检测
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

public class WaterTrigger : MonoBehaviour {
    public string StrHeroName;                   //英雄的名称
    private AudioSource asWater;                 //音频源


	void Start () 
	{
        asWater = this.GetComponent<AudioSource>();
	}//Start_end

    //触发检测
    void OnTriggerEnter(Collider col)
    {
        if (col.collider.name.Equals(StrHeroName))
        {
            asWater.Play();
        }
    }

}//Class_end
