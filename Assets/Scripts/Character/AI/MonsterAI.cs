﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT
using behaviac;
using UnityEngine;

///<<< END WRITING YOUR CODE

namespace GameGeek.Character
{
    ///<<< BEGIN WRITING YOUR CODE NAMESPACE_INIT

    ///<<< END WRITING YOUR CODE

    public class MonsterAI : GameGeek.Character.CharacterMonster
    ///<<< BEGIN WRITING YOUR CODE MonsterAI
    ///<<< END WRITING YOUR CODE
    {
        public behaviac.EBTStatus Attack()
        {
            ///<<< BEGIN WRITING YOUR CODE Attack
            behaviac.Debug.LogWarning("Attack");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus CanSeeObject()
        {
            ///<<< BEGIN WRITING YOUR CODE CanSeeObject
            behaviac.Debug.LogWarning("CanSeeObject");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus GetCurrentHealth()
        {
            ///<<< BEGIN WRITING YOUR CODE GetCurrentHealth
            behaviac.Debug.LogWarning("GetCurrentHealth");
            if (property.hp > 0)
            {
                return behaviac.EBTStatus.BT_SUCCESS;
            }
            return behaviac.EBTStatus.BT_FAILURE;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus IsAlive()
        {
            ///<<< BEGIN WRITING YOUR CODE IsAlive
            behaviac.Debug.LogWarning("IsAlive");
			if (property.hp > 0)
            {
                return behaviac.EBTStatus.BT_SUCCESS;
            }
            return behaviac.EBTStatus.BT_FAILURE;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus IsDamaged()
        {
            ///<<< BEGIN WRITING YOUR CODE IsDamaged
            behaviac.Debug.LogWarning("IsDamaged");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus Patrol()
        {
            ///<<< BEGIN WRITING YOUR CODE Patrol
            behaviac.Debug.LogWarning("Patrol");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus RotateTowards()
        {
            ///<<< BEGIN WRITING YOUR CODE RotateTowards
            behaviac.Debug.LogWarning("RotateTowards");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus Seek()
        {
            ///<<< BEGIN WRITING YOUR CODE Seek
            behaviac.Debug.LogWarning("Seek");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus ShowAnimation()
        {
            ///<<< BEGIN WRITING YOUR CODE ShowAnimation
            behaviac.Debug.LogWarning("ShowAnimation");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus Wander()
        {
            ///<<< BEGIN WRITING YOUR CODE Wander
            behaviac.Debug.LogWarning("Wander");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        public behaviac.EBTStatus WithinDistance()
        {
            ///<<< BEGIN WRITING YOUR CODE WithinDistance
            behaviac.Debug.LogWarning("WithinDistance");
            return behaviac.EBTStatus.BT_SUCCESS;
            ///<<< END WRITING YOUR CODE
		}

        ///<<< BEGIN WRITING YOUR CODE CLASS_PART

        private static string ExportedFilePath
        {
            get
            {
                string relativePath = "/Resources/behaviac/exported";

                if (Application.platform == RuntimePlatform.WindowsEditor)
                {
                    return Application.dataPath + relativePath;
                }
                else if (Application.platform == RuntimePlatform.WindowsPlayer)
                {
                    return Application.dataPath + relativePath;
                }
                else
                {
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

        private bool InitMonsterAI()
        {
            behaviac.Debug.LogWarning("InitMonsterAI");

            bool bRet = this.btload("MonsterAI");
            if (bRet)
            {
                this.btsetcurrent("MonsterAI");
            }

            return bRet;
        }

        void Awake()
        {
            InitBehavic();

            InitMonsterAI();
        }
        void Start()
        {
            // property = CharacterConfig.GetDefaultCharacterProperty();
        }

        behaviac.EBTStatus _status = behaviac.EBTStatus.BT_RUNNING;

        void Update()
        {
            if (_status == behaviac.EBTStatus.BT_RUNNING)
            {
                _status = this.btexec();
            }
        }

        ///<<< END WRITING YOUR CODE

    }


    ///<<< BEGIN WRITING YOUR CODE NAMESPACE_UNINIT

    ///<<< END WRITING YOUR CODE
}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

