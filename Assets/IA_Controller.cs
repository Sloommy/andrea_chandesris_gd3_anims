using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum IaState
{
    None,
    Idle,
    Walk,
    Fuite,
    Repos,
    Observation,
    PlayerNear,
}
public class IA_Controller : MonoBehaviour
{
    private IaState _State = IaState.None;
    public bool PlayerNear = false;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private GameObject _waypoint;
    private void Behaviour()
    {
        switch (_State)
        {
            case IaState.None:
                break;
            case IaState.Idle:
                break;
            case IaState.Walk:
                _agent.SetDestination(_waypoint.transform.position);

                break;
            case IaState.Fuite:
                break;
            case IaState.Repos:
                break;
            case IaState.Observation:
                break;
            case IaState.PlayerNear:
                break;
        }
    }

    private void CheckTransition()
    {
        switch (_State)
        {
            case IaState.None:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
            case IaState.Idle:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
            case IaState.Walk:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
            case IaState.Fuite:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
            case IaState.Repos:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
            case IaState.Observation:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
            case IaState.PlayerNear:
                if (PlayerNear)
                {
                    _State = IaState.PlayerNear;
                }
                break;
        }
    }

}