using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = " SeeAction (A)", menuName = "ScriptableObjects/Actions/SeeAction")]
public class SeeAction : Action
{
    public Vector3 see;
    [Range(0f, 360f)]
    public float visionAngle = 90f; // el angulo de vision que queremos
    public float visionDistance = 2f; // la distancia de vision que queremos
    public override bool Check(GameObject owner)
    {
       
        GameObject target = owner.GetComponent<TargetReferences>().target; // accedemos al target
            
        Vector3 playerVector = target.transform.position - owner.transform.position;
        if (Vector3.Angle(playerVector.normalized, owner.transform.position ) < visionAngle * 0.5f)
        {
            if (playerVector.magnitude < visionDistance)
            {
                return true;
            }
        }
      return false;
    }
    private Vector3 PointForAngle(float angle, GameObject owner) 
    {
        Vector3 ret = new Vector3(
            Mathf.Cos(angle * Mathf.Deg2Rad), 0 , Mathf.Sin(angle * Mathf.Deg2Rad)) * visionDistance; // formula matematica del puto cono

        return ret;
    }
    public override void DrawGizmo(GameObject owner)
    {
        if (visionAngle <= 0f) return; // para que cuando el angulo de vision sea igual o menor que 0 no dibuje nada 
        if (visionDistance <= 0f) return;
        float halfVisionAngle = visionAngle * .5f; //para utilizar las dos mitades del campo

        Vector3 p1, p2; // puntos auxiliares para que salgan las lineas 
        p1 = PointForAngle(halfVisionAngle,owner);
        p2 = PointForAngle(-halfVisionAngle, owner); 
        Gizmos.color = Color.red;
        Gizmos.DrawLine(owner.transform.position, owner.transform.position + p1);
        Gizmos.DrawLine(owner.transform.position, owner.transform.position + p2); // para dibujar las l�neas
    }

    
}
