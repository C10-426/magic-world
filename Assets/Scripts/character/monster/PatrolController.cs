using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PatrolController : MonoBehaviour
{
    public enum PatrolState : int
    {
        IDLE,
        WANDER,
        WALK_LEFT,
        WALK_FORWARD,
        WALK_RIGHT,
        WALK_BACK,
        BATTLE,
        CHASE,
        WARN,
        RETURN
    }

    private GameObject target;
    private CharacterController targetController;
    private Animator animator;
    private PatrolState currentState;
    private Vector3 initPosition;
    private float wanderRadius;
    private float alertRadius;
    private float defendRadius;
    private float chaseRadius;
    private float attackRange;
    private float turnSpeed = 0.1f;

    private float walkSpeed = 1.0f;

    private float runSpeed = 3.0f;

    public Transform[] walkFlagObjects;
    public int nextPointIndex = 0;

    void Start()
    {
        currentState = PatrolState.IDLE;
        animator = GetComponent<Animator>();
        initPosition = GetComponent<Transform>().position;
        targetController = GetComponent<CharacterController>();
        // walkFlagObjects = transform.Find("PatrolRange").GetComponentsInChildren<Transform>();

        //检查并修正怪物设置  
        //1. 自卫半径不大于警戒半径，否则就无法触发警戒状态，直接开始追击了  
        defendRadius = Mathf.Min(alertRadius, defendRadius);
        //2. 攻击距离不大于自卫半径，否则就无法触发追击状态，直接开始战斗了  
        attackRange = Mathf.Min(defendRadius, attackRange);
        //3. 游走半径不大于追击半径，否则怪物可能刚刚开始追击就返回出生点  
        wanderRadius = Mathf.Min(chaseRadius, wanderRadius);
    }

    void FixedUpdate()
    {
        Walk();
    }

    public void Idle()
    {

    }

    private void Walk()
    {
        bool isArriveNextPiont = Vector3.Distance(transform.position, walkFlagObjects[nextPointIndex].position) < 0.5f;
        if (isArriveNextPiont)
        {
            nextPointIndex++;
            nextPointIndex = nextPointIndex % walkFlagObjects.Length;
        }
        ForwardTargetPosition(walkFlagObjects[nextPointIndex].position);
        targetController.SimpleMove((walkFlagObjects[nextPointIndex].position - transform.position).normalized * runSpeed);
    }

    private void Chase()
    {
        ForwardTargetPosition(target.transform.position);
        Run();
    }


    private void ReturnBack()
    {
        float distanceToInit = Vector3.Distance(transform.position, initPosition);
        if (distanceToInit > 0.5f)
        {
            ForwardTargetPosition(initPosition);
            Run();
        }
    }

    private void ForwardTargetPosition(Vector3 forwardTargetPosition)
    {
        Quaternion targetPosition = Quaternion.LookRotation(forwardTargetPosition - transform.position, Vector3.up);
        // Debug.Log("ForwardTargetPosition:"+targetPosition);
        // Debug.Log("ForwardTargetPosition:rotation:"+transform.rotation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetPosition, turnSpeed);
    }

    private void Run()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
    }

    private void RunAction()
    {
        switch (currentState)
        {
            case PatrolState.IDLE:

                break;
            case PatrolState.WANDER:

                break;
            case PatrolState.WARN:

                break;
            case PatrolState.CHASE:

                break;
            case PatrolState.BATTLE:

                break;
            case PatrolState.RETURN:

                break;
        }
    }

    public PatrolState CalculateNewPatrolState()
    {
        float distanceToTarget = Vector3.Distance(target.transform.position, transform.position);
        PatrolState newPatrolState = currentState;
        if (distanceToTarget < attackRange)
        {
            newPatrolState = PatrolState.BATTLE;
        }
        else if (distanceToTarget < defendRadius)
        {
            newPatrolState = PatrolState.CHASE;
        }
        else if (distanceToTarget < alertRadius)
        {
            newPatrolState = PatrolState.WARN;
        }

        if (distanceToTarget > wanderRadius)
        {
            newPatrolState = PatrolState.RETURN;
        }
        return newPatrolState;
    }
}