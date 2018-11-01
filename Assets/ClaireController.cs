using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaireController : MonoBehaviour {

    [SerializeField]
    private float walkSpeed = 2;
	
    private float axisH;
    private float axisV;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }
    // Update is called once per frame
    void Update () {
        axisH = Input.GetAxis("Horizontal");
        axisV = Input.GetAxis("Vertical");

        if (axisV > 0)
        {
            animator.SetBool("Walking", true);
            transform.Translate(Vector3.forward * walkSpeed * axisV * Time.deltaTime);
        }
        if (axisV == 0)
        {
            animator.SetBool("Walking", false);
        }
    }
}
