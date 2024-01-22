using System;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class NPCObject : MonoBehaviour
{
    public BehaviorTree behaviorTreeHappy;
    public BehaviorTree behaviorTreeSad;

    public BehaviorTree CurTree;

    private int CollisionTimes = 0;
    public void Start()
    {
        var trees = GetComponents<BehaviorTree>();
        behaviorTreeHappy = trees[0];
        behaviorTreeSad = trees[1];
        
        behaviorTreeHappy.EnableBehavior();
        behaviorTreeSad.DisableBehavior();
        CurTree = behaviorTreeHappy;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerObject"))
        {
            CollisionTimes += 1;
            TriggerCollisionActions(CollisionTimes);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        DistriggerCollisionActions(CollisionTimes);
    }

    void TriggerCollisionActions(int times)
    {
        switch (times)
        {
            case 1:
                CurTree.SetVariable("isTouchByPlayer1", (SharedBool)true);
                break;
            case 2:
                CurTree.SetVariable("isTouchByPlayer2", (SharedBool)true);
                break;
            case 3:
                CurTree.SetVariable("isTouchByPlayer3", (SharedBool)true);
                break;
        }
    }
    
    void DistriggerCollisionActions(int times)
    {
        switch (times)
        {
            case 1:
                CurTree.SetVariable("isTouchByPlayer1", (SharedBool)false);
                break;
            case 2:
                CurTree.SetVariable("isTouchByPlayer2", (SharedBool)false);
                break;
            case 3:
                CurTree.SetVariable("isTouchByPlayer3", (SharedBool)false);
                CollisionTimes = 0;
                break;
        }
    }
}
