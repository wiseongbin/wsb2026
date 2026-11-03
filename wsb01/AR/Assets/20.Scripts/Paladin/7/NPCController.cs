using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCController : MonoBehaviour
{
    public Transform targetTR;

    NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (targetTR != null && nav.enabled && nav.isOnNavMesh)
        {
            nav.SetDestination(targetTR.position);
        }
    }
}