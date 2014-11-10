using UnityEngine;
using System.Collections;
 
public class NGUIEventDelegate : MonoBehaviour
{
    private UIButton _button;
 
    void Awake()
    {
        _button = GameObject.Find("ButtonBirth").GetComponent<UIButton>();
        EventDelegate.Add(_button.onClick, onClickButton);
    }
 
    public void onClickButton()
    {
        Debug.Log("onClickButton()");
    }
}
