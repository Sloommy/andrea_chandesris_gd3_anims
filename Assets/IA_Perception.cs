using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Perception : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pawn;
    private Vector3 checkdirection;
    [SerializeField] private float _distance;

    void Start()
    {

    }


    void Update()
    {

    }

    private void CheckDistance()
    {
        checkdirection = player.transform.position - pawn.transform.position;
        checkdirection = checkdirection.normalized;
        checkdirection = checkdirection * _distance;

        RaycastHit hit;
        if (Physics.Raycast(pawn.transform.position, checkdirection, out hit))
        {
            if (hit.collider.gameObject.GetComponent<Player_Controller>())
            {
                pawn.GetComponentInChildren<IA_Controller>().PlayerNear = true;
            }
            else
            {
                pawn.GetComponentInChildren<IA_Controller>().PlayerNear = false;
            }

        }
        else
        {
            pawn.GetComponentInChildren<IA_Controller>().PlayerNear = false;
        }
    }
}
