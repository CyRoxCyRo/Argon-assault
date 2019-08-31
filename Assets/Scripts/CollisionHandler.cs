using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    [SerializeField] GameObject explosionEffect;
    private void OnCollisionEnter(Collision collision)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
        SendMessage("BlockMovement");
        explosionEffect.SetActive(true);
        Invoke("DeathResetLevel", levelLoadDelay);
    }
    private void DeathResetLevel()
    {
        FindObjectOfType<SceneLoader>().RestartLevel();
    }
}
