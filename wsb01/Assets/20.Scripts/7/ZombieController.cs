using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ZombieController: MonoBehaviour
{
    public GameObject destinationFolder;
    Transform[] destinations;
    int destinationIndex;

    NavMeshAgent nav;
    bool isArrived = false;
    float minDistance = 1f;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        destinations = destinationFolder.GetComponentsInChildren<Transform>();
        destinationIndex = Random.Range(1, destinations.Length);

    }

    void Update()
        {
            if (Arrived())
        {
            destinationIndex = Random.Range(1, destinations.Length);
        }
            nav.SetDestination(destinations[destinationIndex].position);
        }
        bool Arrived()
        {
        if (Vector3.Distance(transform.position, destinations[destinationIndex].position) < minDistance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
