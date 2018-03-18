using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class Enemy_NavPuse : MonoBehaviour {

    private Enemy_Master enemyMaster;
    private UnityEngine.AI.NavMeshAgent myNavMesh;
    
    private float puaseTime = 1;

    IEnumerator RestartNavMeshAgent()
    {
        yield return new WaitForSeconds(puaseTime);
        enemyMaster.isNavPuse = false;
    }

    void SetIntiailReferance()
    {
        enemyMaster = GetComponent<Enemy_Master>();
        if (GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
        {
            myNavMesh = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

        
    }
    private void OnEnable()
    {
        SetIntiailReferance();
        enemyMaster.EventEnemyDie += DisableThis;
        enemyMaster.EventEnemyDedectHealth += PauseNaveMeshAgent;
    }
    private void OnDisable()
    {
        enemyMaster.EventEnemyDie -= DisableThis;
        enemyMaster.EventEnemyDedectHealth -= PauseNaveMeshAgent;
    }

    private void DisableThis()
    {

        StopAllCoroutines();
    }

    // Update is called once per frame
    void PauseNaveMeshAgent(int dummy)
    {
        if (myNavMesh != null)
        {
            if (myNavMesh.enabled)
            {
                myNavMesh.ResetPath();
                enemyMaster.isNavPuse = true;
                StartCoroutine(RestartNavMeshAgent());
            }
        }
    }
}
