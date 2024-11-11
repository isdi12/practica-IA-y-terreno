using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " WalkAction (A)", menuName = "ScriptableObjects/Actions/WalkAction")]
public class WalkAction : Action
{
    public float radius = 20f;
    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReferences>().target;
        return !(target.GetComponent<PlayerMovement_CC>().IsRunning());
        
    }

    public override void DrawGizmo(GameObject owner)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(owner.transform.position, radius);
    }
}
