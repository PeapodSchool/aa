﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] Rotator rotator;
    [SerializeField] PinSpawner pinSpawner;
    [SerializeField] CameraAnimator animator;
    [SerializeField] int numberOfPins;
    private int currentNumberOfPins = 0;

    public int GetTotalNumberOfPins() 
    { 
        return numberOfPins;
    }

    public int GetCurrentNumberOfPins() 
    { 
        return currentNumberOfPins; 
    }

    public void AddPin()
    {
        currentNumberOfPins++;
    }

    public void GameOver()
    {
        DisableGameElements();
        animator.SetGameOverTrigger();
    }

    public void LevelComplete()
    {
        DisableGameElements();
        animator.SetLevelCompleteTrigger();
    }

    private void DisableGameElements()
    {
        rotator.enabled = false;
        pinSpawner.enabled = false;
    }
}
