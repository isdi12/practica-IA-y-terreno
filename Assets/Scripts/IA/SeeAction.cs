using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " SeeAction (A)", menuName = "ScriptableObjects/Actions/SeeAction")]
public class SeeAction : Action
{
    public Vector3 see;
    public override bool Check(GameObject owner)
    {
        RaycastHit[] hits = Physics.(owner.transform.position, see); // castea un rayo desde el enemigo
        GameObject target = owner.GetComponent<TargetReferences>().target; // accedemos al target

        foreach (RaycastHit hit in hits) // recorremos todos los objetos que estemos escuchando si alguno es el objetivo devuelvo true si no false 
        {
            if (hit.collider.gameObject == target)
            {
                //le hemos escuchado / oler

                return true;
            }
        }
        return false;
    }

    public override void DrawGizmo(GameObject owner)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(owner.transform.position, see);
    }

    
}
