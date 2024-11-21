using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderDiego : State
{
    public float maxTime;
    public float radius;

    private float currentTime;
    public override State Run(GameObject owner)
    {
        {
            State nextState = CheckActions(owner);

            NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();
            currentTime += Time.deltaTime;
            if (currentTime >= maxTime)
            {
                bool pointFound = false;
                do// para que todo esto se ejecute minimo una vez dentro de la malla de navegación
                {
                    Vector3 randomDirection = Random.insideUnitSphere * radius;
                    randomDirection += navMeshAgent.transform.position; // Aseguramos de que la nueva posición esté en relación con la posición actual

                    // Intenta establecer el destino en la nueva posición
                    NavMeshHit hit; //Se declara una variable hit que contendrá la información sobre el punto en el NavMesh que se encuentra.
                    if (NavMesh.SamplePosition(randomDirection, out hit, radius, NavMesh.AllAreas))  //si encontramos el punto mas cercano dentro del area especificado
                    {
                        navMeshAgent.SetDestination(hit.position); // Establece el destino del agente
                    }

                }
                while (!pointFound);
            }



            return nextState;
        }
    }
   
}
