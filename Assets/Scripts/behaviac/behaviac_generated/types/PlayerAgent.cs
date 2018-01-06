﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT
using UnityEngine;
///<<< END WRITING YOUR CODE

public class PlayerAgent : behaviac.Agent
///<<< BEGIN WRITING YOUR CODE PlayerAgent
///<<< END WRITING YOUR CODE
{
	public void Move()
	{
///<<< BEGIN WRITING YOUR CODE Move
		behaviac.Debug.LogWarning("Player Move!");
///<<< END WRITING YOUR CODE
	}

///<<< BEGIN WRITING YOUR CODE CLASS_PART
private static string ExportedFilePath
{
    get
    {
        string relativePath = "/Resources/behaviac/exported";

        if (Application.platform == RuntimePlatform.WindowsEditor) {
            return Application.dataPath + relativePath;
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer) {
            return Application.dataPath + relativePath;
        }
        else {
            return "Assets" + relativePath;
        }
    }
}

private bool InitBehavic()
{
    behaviac.Debug.LogWarning("InitBehavic");

    behaviac.Workspace.Instance.FilePath = ExportedFilePath;
    behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_xml;

    return true;
}

private bool InitPlayer()
{
    behaviac.Debug.LogWarning("InitPlayer");

    bool bRet = this.btload("PlayerBehaviorsTree");
    if (bRet)
    {
        this.btsetcurrent("PlayerBehaviorsTree");
    }

    return bRet;
}

void Awake()
{
    InitBehavic();

    InitPlayer();
}

behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;
void Update()
{
    if (_status == behaviac.EBTStatus.BT_RUNNING)
    {
        behaviac.Debug.LogWarning("Update");

        _status = this.btexec();
     }
}
///<<< END WRITING YOUR CODE

}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

