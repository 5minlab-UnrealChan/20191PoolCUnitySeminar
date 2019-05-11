using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationTestMachine : MonoBehaviour
{
    public Transform dest;

    private Vector3 orig;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        orig = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            agent.SetDestination(dest.position);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            agent.SetDestination(orig);
        }
    }
}
