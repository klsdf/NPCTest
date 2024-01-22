using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class LookAtAction : Action
{
    public SharedGameObject target; // 你想要看向的目标

    public override TaskStatus OnUpdate()
    {
        if (!target.Value.CompareTag("PlayerObject"))
        {
            return TaskStatus.Failure;
        }
        
        // 让物体看向目标
        transform.LookAt(target.Value.transform);

        return TaskStatus.Success;
    }
}