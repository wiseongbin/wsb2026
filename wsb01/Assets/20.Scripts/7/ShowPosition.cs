using System.Runtime.CompilerServices;
using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    public Color color = Color.yellow;
    public float radius = 0.5f;
    private void OnDrawGizoms()
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, radius);
    }
}

