using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgenteScript : MonoBehaviour
{
    public Transform targetTR;
    public Transform targetTR2;
    public float remaining; 
    public float minDistance;
    public bool yendo; 
    public NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (navAgent.remainingDistance < minDistance && navAgent.hasPath)
        {
            Debug.Log("Llegue : " + navAgent.remainingDistance);
            yendo = !yendo; 
        }
        if (yendo)
        {
            navAgent.destination = targetTR.position; //le seteo hasta donde tiene que ir
        }
        else
        {
            navAgent.destination = targetTR2.position; 
        }
    }
}
