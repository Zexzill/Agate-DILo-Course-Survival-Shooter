using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBooster
{
    void BoosterMethod(int index);
}

public class BoosterManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public PlayerMovement playerMovement;
    public float spawnTime = 4;

    [SerializeField] MonoBehaviour factory;
    private IBooster Booster
    {
        get
        {
            return factory as IBooster;
        }
    }

    private void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void Spawn()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        if(playerHealth.isBoosterTaken)
        {
            int boosterRandom = Random.Range(0, 2);
            Booster.BoosterMethod(boosterRandom);

            playerHealth.isBoosterTaken = false;
        }
    }
}
