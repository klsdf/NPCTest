using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.UI;
using UnityEngine;

public class ChangeNpcState : MonoBehaviour
{
    public Button BtnSad;
    public Button BtnHappy;
    public GameObject npcObject;
    
    BehaviorTree behaviorTreeSad;
    BehaviorTree behaviorTreeHappy;
    private void Awake()
    {
        var trees = npcObject.GetComponents<BehaviorTree>();
        behaviorTreeHappy = trees[0];
        behaviorTreeSad = trees[1];
    }

    void Start()
    {
        
        BtnSad.onClick.AddListener(() =>
        {
            behaviorTreeSad.EnableBehavior();
            behaviorTreeHappy.DisableBehavior();
            npcObject.GetComponent<NPCObject>().CurTree = behaviorTreeSad;
        });
        
        BtnHappy.onClick.AddListener(() =>
        {
            behaviorTreeHappy.EnableBehavior();
            behaviorTreeSad.DisableBehavior();
            npcObject.GetComponent<NPCObject>().CurTree = behaviorTreeHappy;
        });
    }
    
}
