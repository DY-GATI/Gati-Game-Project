using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Run",true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}
