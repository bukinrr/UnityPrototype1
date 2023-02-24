using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EnemyTransport : MonoBehaviour
{
    public GameObject enemyBus;
    public GameObject enemyJip;
    private float enemyBusSpeed = 15;
    private float enemyJipSpeed = 24;

    void Update()
    {
        enemyBus.transform.Translate(Vector3.forward * Time.deltaTime * enemyBusSpeed);
        enemyJip.transform.Translate(Vector3.forward * Time.deltaTime * enemyJipSpeed);
    }
}