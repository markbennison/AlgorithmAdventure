using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : MonoBehaviour
{
    Animator animator;
    const string ANIM_FLOAT_SPEED = "Speed";

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat(ANIM_FLOAT_SPEED, 0f);
    }

    void Update()
    {
        
    }
}
