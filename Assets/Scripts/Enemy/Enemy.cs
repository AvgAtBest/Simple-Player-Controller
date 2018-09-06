using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    GameObject detectedPlayer;

    void Awake()
    {
        detectedPlayer = GameObject.FindGameObjectWithTag("Player");
        target = detectedPlayer.GetComponent<Transform>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}
