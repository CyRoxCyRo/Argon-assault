using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject explosionEffect;
    [SerializeField] Transform parent;
    [SerializeField] int healthPoints = 10;

    [SerializeField] float destroyDelay = 4f;

    [SerializeField] int points = 12;

    GameObject deathFX;
    ScoreBoard scoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        AddCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddCollider()
    {
        gameObject.AddComponent<MeshCollider>().convex = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        if (healthPoints < 1) { return; }
        else if (healthPoints == 1)
        {
            KillEnemy();
        }
        healthPoints--;
        scoreBoard.ScoreHit(points);
    }

    private void KillEnemy()
    {
        gameObject.GetComponent<MeshCollider>().enabled = false;
        gameObject.AddComponent<Rigidbody>();

        deathFX = Instantiate(explosionEffect, transform.position, Quaternion.identity) as GameObject;
        deathFX.transform.parent = parent;

        Destroy(deathFX, destroyDelay);
        Destroy(gameObject, destroyDelay);
    }
}
