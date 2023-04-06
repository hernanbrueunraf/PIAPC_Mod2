using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _player;

    [SerializeField] private GameObject[] _target;
    [SerializeField] private GameObject _nextPointObject;

    LightStateManager _lsmanager;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _player = GetComponent<Transform>();
        _lsmanager = new LightStateManager();
    }

    void Update()
    {

        foreach(GameObject lights in _target)
        {
            if (lights.GetComponentInChildren<LightStateManager>().visited == false)
            {
                _agent.SetDestination(lights.transform.position);


                FuzzyLogic(lights.transform, _player);

            }
        }
        


        

        //Instantiate(_nextPointObject, _agent.nextPosition, transform.rotation);

    }

    private void FuzzyLogic(Transform _targetPos, Transform _playerPos)
    {
        float distance = (_targetPos.position - _playerPos.position).magnitude;

        //Debug.Log(distance);

        if(distance >= 60) Debug.Log("lejos!");
        if(distance < 60 && distance >= 45) Debug.Log("acerc�ndose..");
        if(distance < 45 && distance >= 25) Debug.Log("llegando..");
        if(distance < 25 && distance >= 10) Debug.Log("cerca..");
        if(distance < 10 && distance >= 0) Debug.Log("llegu�..");


    }
}
