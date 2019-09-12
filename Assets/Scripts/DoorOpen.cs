using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        BallMovement.OnScoreComplete += startAnimation;
    }


    void OnDisable()
    {
        BallMovement.OnScoreComplete -= startAnimation;
    }

    void startAnimation() {
        animator.enabled = true;
    }
}
