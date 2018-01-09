using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    // a enum used as a state machine for the enemy state
    protected enum EnemyState
    {
        JUST_SPAWNED,
        LOOPING,
        MOVING_TO_TARGET,
        ENGAGING_PLAYER
    }


    // The amount of points this enemy is worth
    public int Worth;
    //the target point for the enemy to move to after it spawns
    protected Vector3 target;
    //the amount of distance this enemy has from the target after it spawns
    protected float startingDistance;
    //the speed with which to move to that target and in engagement phase
    protected float speed;
    //the current state the player is in
    protected EnemyState state;

    protected float direction;
    // Use this for initialization
    void Start()
    {
        //set the defualt player state
        state = EnemyState.JUST_SPAWNED;
        //set the direction to 0
        direction = 0;
    }

    public void SetTarget(Vector3 target)
    {
        //calculate starting distance to target
        startingDistance = Vector3.Distance(transform.position, target);
        //store the target
        this.target = target;
    }

    public void SetSpeed(float speed)
    {
        //store the speed
        this.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //go to the correct pattern depending on the enemys state
        switch (state)
        {
            case EnemyState.JUST_SPAWNED:
                JustSpawnedPattern();
                break;

            case EnemyState.ENGAGING_PLAYER:
                EngagementPattern();
                break;
            case EnemyState.LOOPING:
                LoopingPatern();
                break;
            case EnemyState.MOVING_TO_TARGET:
                MovingToTargetPattern();
                break;
        }
    }

    protected virtual void EngagementPattern()
    {

    }

    protected virtual void LoopingPatern()
    {

    }

    protected virtual void MovingToTargetPattern()
    {

    }

    protected virtual void JustSpawnedPattern()
    {
        //move toawrd the target
        this.transform.LookAt(target);
        this.transform.Translate(new Vector3(target.x > transform.position.x ? speed : -speed, 0, target.z > transform.position.z ? speed : speed));

        if()
    }
}
