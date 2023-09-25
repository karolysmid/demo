using System.Collections;
using System.Collections.Generic;
using Controllers;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;

public class Guyscript : MonoBehaviour
{

    public GameObject player;
    public Animator animator;
    public NavMeshAgent navMeshAgent;
    public Controller controller;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator  = GetComponent<Animator>();
        controller = player.GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.GetControlsEnabled()){
        navMeshAgent.destination = player.transform.position;
       animator.SetFloat("Speed", navMeshAgent.speed);
       navMeshAgent.isStopped = false;
        }else navMeshAgent.isStopped = true;
    }
}
