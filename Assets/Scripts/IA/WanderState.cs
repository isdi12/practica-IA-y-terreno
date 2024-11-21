using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[CreateAssetMenu(fileName = "WanderState (S)", menuName = "ScriptableObjects/States/WanderState")]
public class WanderState : State
{
    public float wanderRadius; // Radio por el que se va a mover 
    public float wanderTimer = 2f; // Tiempo entre cada movimiento

    private float timer;
    public override State Run(GameObject owner)
    {
        State nextState = CheckActions(owner);

        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();
        // Incrementa el temporizador
        timer += Time.deltaTime;

        // Si ha pasado el tiempo definido, elige una nueva posición
        if (timer >= wanderTimer)
        {
            Wander(navMeshAgent);
            timer = 0; // Reinicia el temporizador
        }

        
       
        return nextState; // Retorna el siguiente estado si existe, de lo contrario, permanece en este estado
    }

    private void Wander(NavMeshAgent navMeshAgent)
    {
        bool pointFound = false;
        do
        {
            // Genera una nueva posición aleatoria dentro del radio de deambulación
            Vector3 randomDirection = Random.insideUnitSphere * wanderRadius;
            randomDirection += navMeshAgent.transform.position; // Aseguramos de que la nueva posición esté en relación con la posición actual

            // Intenta establecer el destino en la nueva posición
            NavMeshHit hit; //Se declara una variable hit que contendrá la información sobre el punto en el NavMesh que se encuentra.
            if (NavMesh.SamplePosition(randomDirection, out hit, wanderRadius, NavMesh.AllAreas))  //si encontramos el punto mas cercano dentro del area especificado
            {
                navMeshAgent.SetDestination(hit.position); // Establece el destino del agente
                pointFound = true;
            }
        }
        while (!pointFound);
    }
}

