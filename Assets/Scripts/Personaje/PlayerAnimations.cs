using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement_CC PlayerMovement_CC;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        PlayerMovement_CC = GetComponent<PlayerMovement_CC>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        animator.SetFloat("Speed", PlayerMovement_CC.GetCurrentSpeed() / PlayerMovement_CC.runningSpeed);
    }
}
