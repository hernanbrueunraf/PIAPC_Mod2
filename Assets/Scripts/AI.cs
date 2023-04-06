using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using UnityEngine.TMPro;

public class AI : MonoBehaviour
{
    private NavMeshAgent _agent;

    [SerializeField] private GameObject[] _target;
    [SerializeField] private GameObject _nextPointObject;

    LightStateManager _lsmanager;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _lsmanager = new LightStateManager();
    }

    void Update()
    {

        foreach(GameObject lights in _target)
        {
            if (lights.GetComponentInChildren<LightStateManager>().visited == false)
            {
                _agent.SetDestination(lights.transform.position);

                //Debug.Log(_target[0].GetComponentInChildren<LightStateManager>().visited);

            }
        }
        


        

        //Instantiate(_nextPointObject, _agent.nextPosition, transform.rotation);

    }
}
