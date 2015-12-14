/***
 * 
 *    Title:  "生化危机" 项目
 *            武器展示面板滑动控制
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

public class ChangeSliderPanle : MonoBehaviour {
    private float _FloDeltaPosion;                         //累加位置
    private bool _boolMovingControl = false;               //移动开关
    private const int REBACK_VALUES = 5;                   //弹性系数

    public string StrBackgroundAudioName;                  //背景音乐名称
    public string StrAudioEffectName_GUISlider;            //GUI滑动音效名称

	void Start () 
	{
        //播放背景音乐
        AudioManager.PlayBackground(StrBackgroundAudioName);
	}//Start_end

    /// <summary>
    /// 鼠标的点击(NGUI 事件函数)
    /// </summary>
    /// <param name="boolIsRress"></param>
    void OnPress(bool boolIsRress)
    {
        _boolMovingControl = boolIsRress;
        if (!boolIsRress)
        {
            _FloDeltaPosion = 0;
        }
    }

    /// <summary>
    /// 鼠标的拖拽 (NGUI 事件函数)
    /// </summary>
    /// <param name="vec"></param>
    void OnDrag(Vector2 vec)
    {
        if (_boolMovingControl)
        {
            _FloDeltaPosion += vec.x;
            this.transform.Translate(new Vector3(_FloDeltaPosion / 1000, 0, 0), Space.World);
        }
    }
	
	void Update() 
	{
        //运动受限处理（向右移动）
        if (this.transform.localPosition.x>0)
        {
            //this.transform.localPosition = new Vector3(0,0,0);
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, new Vector3(0, 0, 0), Time.deltaTime * REBACK_VALUES);
 
        }

        //运动受限处理（向左移动）
        if (this.transform.localPosition.x <=-3200)
        {
            //this.transform.localPosition = new Vector3(0,0,0);
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, new Vector3(-3200, 0, 0), Time.deltaTime * REBACK_VALUES);

        }

        //整版移动运动受限处理
        if (this.transform.localPosition.x < 0 && this.transform.localPosition.x > -800)
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, new Vector3(-800, 0, 0), Time.deltaTime * REBACK_VALUES);
            if (Mathf.RoundToInt(this.transform.localPosition.x)==-800)
            {
                //播放音效
                AudioManager.Play(StrAudioEffectName_GUISlider);
                this.transform.localPosition = new Vector3(-800,0,0);
            }
        }
        if (this.transform.localPosition.x < -800 && this.transform.localPosition.x > -1600)
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, new Vector3(-1600, 0, 0), Time.deltaTime * REBACK_VALUES);
            if (Mathf.RoundToInt(this.transform.localPosition.x) == -1600)
            {
                //播放音效
                AudioManager.Play(StrAudioEffectName_GUISlider);
                this.transform.localPosition = new Vector3(-1600, 0, 0);
            }
        }
        if (this.transform.localPosition.x < -1600 && this.transform.localPosition.x > -2400)
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, new Vector3(-2400, 0, 0), Time.deltaTime * REBACK_VALUES);
            if (Mathf.RoundToInt(this.transform.localPosition.x) == -2400)
            {
                //播放音效
                AudioManager.Play(StrAudioEffectName_GUISlider);
                this.transform.localPosition = new Vector3(-2400, 0, 0);
            }
        }
        if (this.transform.localPosition.x < -2400 && this.transform.localPosition.x > -3200)
        {
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, new Vector3(-3200, 0, 0), Time.deltaTime * REBACK_VALUES);
            if (Mathf.RoundToInt(this.transform.localPosition.x) == -3200)
            {
                //播放音效
                AudioManager.Play(StrAudioEffectName_GUISlider);
                this.transform.localPosition = new Vector3(-3200, 0, 0);
            }
        }
	}//Update_end

}//Class_end
