using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " PlayerLookAtMeAction (A)", menuName = "ScriptableObjects/Actions/PlayerLookAtMeAction")]
public class PlayerLookAtMeAction : Action
{
    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReferences>().target; // accedemos al target
        PlayerViewList viewListComponent = target.GetComponentInChildren<PlayerViewList>();
        List<GameObject> list = viewListComponent.viewList; //view list contiene todos los jugadores que el target esta mirando

        foreach (GameObject gameobject in list)
        {
            if (owner == gameobject)  // indica que el jugador (representado por owner) esta siendo mirado por el target
            {
                return true;
            }
        }
        return false;
    }

    public override void DrawGizmo(GameObject owner)
    {
        
    }
}
