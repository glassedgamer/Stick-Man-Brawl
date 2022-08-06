using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    [SerializeField] private Animator animator;

    public GameObject attackTrigger;

    public void OnAttack(InputAction.CallbackContext context) {
        animator.SetTrigger("playerPunch");
    }

    public void TriggerOn() {
        attackTrigger.SetActive(true);
    }

    public void TriggerOff() {
        attackTrigger.SetActive(false);
    }

}
