using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    public GameObject concentrador;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        nav.SetDestination(player.transform.position);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            this.concentrador.GetComponent<InterfazVida>().vidas = 0;
        }
    }


}
