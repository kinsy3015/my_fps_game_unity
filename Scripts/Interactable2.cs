using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable2 : MonoBehaviour
{

    public float radius = 3f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);

    }
}
