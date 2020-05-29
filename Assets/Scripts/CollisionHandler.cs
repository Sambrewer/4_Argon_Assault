using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")] [SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")]  [SerializeField] GameObject deathFX;

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        ReloadScene();
    }

    private void ReloadScene()
    {
        throw new NotImplementedException();
    }

    private void StartDeathSequence()
    {
        SceneManager.LoadScene(1);
    }
}
