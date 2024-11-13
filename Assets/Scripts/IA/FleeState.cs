using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FleeState (S)", menuName = "ScriptableObjects/States/FleeState")]
public class FleeState : State
{
    public float fleeDistance = 5f; // Distancia a la que el objeto debe huir
    public float fleeSpeed = 3f; // Velocidad a la que el objeto debe huir

    public override State Run(GameObject owner)
    {
        // Comprobar si se debe cambiar a otro estado
        State nextState = CheckActions(owner);
        // Obtener la posición del player
        Vector3 playerPosition = GetPlayerPosition(owner);
        Vector3 fleeDirection = (owner.transform.position - playerPosition).normalized;

        // Calcular la nueva posición a la que huir
        Vector3 fleePosition = owner.transform.position + fleeDirection * fleeDistance;

        // Mover al objeto hacia la nueva posición de huida
        MoveOwnerToPosition(owner, fleePosition);

        return nextState;
    }

    private Vector3 GetPlayerPosition(GameObject owner)
    {
        // Aquí deberías implementar la lógica para obtener la posición del enemigo
        // Esto es solo un ejemplo. Puedes usar un sistema de detección de enemigos.
        GameObject enemy = GameObject.FindWithTag("Player"); // Suponiendo que el player tiene la etiqueta "player"
        return enemy != null ? enemy.transform.position : owner.transform.position; // Si no hay enemigo, no se mueve
    }

    private void MoveOwnerToPosition(GameObject owner, Vector3 targetPosition)
    {
        // Mover el objeto hacia la posición de huida
        owner.transform.position = Vector3.MoveTowards(owner.transform.position, targetPosition, fleeSpeed * Time.deltaTime);
    }

}
