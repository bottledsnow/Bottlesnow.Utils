using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnityEvnetSubscription : MonoBehaviour
{
    #region 第一個Script
    public event System.Action OnVingName;
    //no Start
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ving();
            Debug.Log("PressedMouse0");
        }
    }
    private void Ving()
    {
        OnVingName?.Invoke();
        //預防空事件
    }

    #endregion

    #region 第二個Script
    [SerializeField]
    private TheFirstScriptName ScriptName;

    void Start()
    {
        ScriptName = GetComponent<ScriptName>();

        ScriptName.OnShootingEvent += ScriptName_OnVingEventEvent;
    }

    //no Update
    private void ScriptName_OnVingEventEvent()
    {
        Debug.Log("EnvetAdd");
    }
    #endregion
}
