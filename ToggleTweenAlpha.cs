using UnityEngine;
using System.Collections;
 
public class ToggleTweenAlpha : MonoBehaviour
{
    private GameObject _label;
    private Vector3 _posLabel;
    private bool _flag;
 
    void Awake()
    {
        _flag = false;
    }
 
    void Start()
    {
        _label = GameObject.Find("LabelOnFinished");
        _posLabel = _label.transform.position;
        _posLabel.x = 999;
        _label.transform.position = _posLabel;
    }
 
    public void onClickButton()
    {
        _flag = !_flag;
 
        _posLabel.x = 999;
        _label.transform.position = _posLabel;
 
        TweenAlpha tw;
 
        if (_flag)
        {
            tw = TweenAlpha.Begin(gameObject, 1, 0);
        }
        else
        {
            tw = TweenAlpha.Begin(gameObject, 1, 1);
        }
 
        EventDelegate.Set(tw.onFinished, onFinishTweenAlpha);
    }
 
    public void onFinishTweenAlpha()
    {
        _posLabel.x = 0;
        _label.transform.position = _posLabel;
    }
 
}
