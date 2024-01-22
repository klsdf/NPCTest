using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

public class OnTouchNPC : Conditional
{    
    public SharedBool isTouchByPlayer;
    //private bool curValue;
    public override TaskStatus OnUpdate()
    {
        if (isTouchByPlayer.Value) {
            return TaskStatus.Success;
        }
        return TaskStatus.Failure;
    }
}
