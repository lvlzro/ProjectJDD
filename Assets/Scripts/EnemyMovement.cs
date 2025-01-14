﻿using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    NavMeshAgent nav;               // Reference to the nav mesh agent.

    public float speed = 5f;
    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
            nav.SetDestination(player.position);
    }
}
