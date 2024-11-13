using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



[CreateAssetMenu(fileName = "AttackState (S)", menuName = "ScriptableObjects/States/AttackState")]
public class AttackState : State
{
    //    public float attackRange = 2f; // Rango de ataque
    //    public float attackDamage = 10f; // Daño del ataque
    //    public float attackCooldown = 1f; // Tiempo de recarga entre ataques
    //    private float lastAttackTime; // Tiempo del último ataque

    //  public override State Run(GameObject owner)
    //    {
    //        State nextState = CheckActions(owner);
    //        // Verificar si hay un enemigo en rango
    //        GameObject enemy = FindPlayer(owner);
    //        if (enemy != null)
    //        {
    //            // Si el enemigo está dentro del rango, atacar
    //            if (IsEnemyInRange(owner, player))
    //            {
    //                Attack(enemy);
    //                lastAttackTime = Time.time; // Actualizar el tiempo del último ataque
    //            }
    //            else
    //            {
    //                // Si el enemigo está fuera de rango, moverse hacia él
    //                MoveTowardsEnemy(owner, player);
    //            }
    //        }
    //        else
    //        {
    //            // Si no hay enemigo, quizás regresar a un estado de patrullaje o inactivo
    //            return null; // Puede regresar a un estado anterior o a un estado inactivo
    //        }

    //        return nextState;

    //    }

    //    private GameObject FindPlayer(GameObject owner)
    //    {
    //        // Implementar lógica para encontrar un enemigo cercano
    //        // Este es un ejemplo simple, puedes usar un sistema de detección más sofisticado
    //        return GameObject.FindWithTag("player"); // Suponiendo que el enemigo tiene la etiqueta "Enemy"
    //    }

    //    private bool IsEnemyInRange(GameObject owner, GameObject player)
    //    {
    //        float distance = Vector3.Distance(owner.transform.position, player.transform.position);
    //        return distance <= attackRange;
    //    }

    //    private void Attack(GameObject player)
    //    {
    //        // Aquí se implementa la lógica de ataque
    //        // Por ejemplo, se puede hacer daño al jugador
    //        //PlayerHealth playerHealth = player.GetComponent<playerHealth>();
    //        //if (playerHealth != null)
    //        //{
    //        //    playerHealth.TakeDamage(attackDamage);
    //        //}

    //        //Debug.Log($"Attacked {enemy.name} for {attackDamage} damage!");
    //    }

    //    private void MoveTowardsEnemy(GameObject owner, GameObject player)
    //    {
    //        // Mover al objeto hacia el enemigo
    //        Vector3 direction = (player.transform.position - owner.transform.position).normalized;
    //        owner.transform.position += direction * Time.deltaTime; // Mover a la velocidad deseada
    //    }
    public override State Run(GameObject owner)
    {
        throw new System.NotImplementedException();
    }
}
    

