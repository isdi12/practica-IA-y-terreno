using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " WalkAction (A)", menuName = "ScriptableObjects/Actions/WalkAction")]
public class WalkAction : Action
{
    public override bool Check(GameObject owner)
    {
        throw new System.NotImplementedException();
    }

    public override void DrawGizmo(GameObject owner)
    {
        throw new System.NotImplementedException();
    }
}
