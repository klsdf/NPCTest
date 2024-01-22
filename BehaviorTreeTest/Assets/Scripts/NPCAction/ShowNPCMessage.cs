using UnityEngine;
using BehaviorDesigner.Runtime;
using TMPro;
using BehaviorDesigner.Runtime.Tasks;

public class ShowNPCMessage : Action
{
    public TextMeshProUGUI myText;  // 需要在 Behavior Designer 中设置该参数为我们创建的Text对象
    public SharedString showText;
    public override void OnStart()
    {
        myText.gameObject.SetActive(true); 
        myText.text = showText.Value;
    }
}
