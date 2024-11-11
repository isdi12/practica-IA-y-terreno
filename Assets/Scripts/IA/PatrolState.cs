using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[CreateAssetMenu(fileName = "PatrolState (S)", menuName = "ScriptableObjects/States/PatrolState")]
public class PatrolState : State
{
    public Vector3[] WayPoints;

    public int currentPoint;
    public override State Run(GameObject owner)
    {
        State nextState = CheckActions(owner);

        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();

        if (navMeshAgent.remainingDistance < 1)
        {
            currentPoint++;  // nos lleva a la siguiente posicion del array
            if (currentPoint >= WayPoints.Length) // cuando el current point es mayor o igual que el array nos manda otra vez a la posicion de patrulla inicial 
            {
                currentPoint = 0;
            }
        }
        

        navMeshAgent.SetDestination(WayPoints[currentPoint]);

        return nextState;
    }

    
}
