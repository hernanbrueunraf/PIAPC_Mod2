using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using UnityEngine.TMPro;

public class AI : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject _nextPointObject;


    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _agent.SetDestination(_target.position);
        Debug.Log(_agent.remainingDistance);

        //Instantiate(_nextPointObject, _agent.nextPosition, transform.rotation);

    }
}
