using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnityEvnetSubscription : MonoBehaviour
{
    #region �Ĥ@��Script
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
        //�w���Ũƥ�
    }

    #endregion

    #region �ĤG��Script
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
