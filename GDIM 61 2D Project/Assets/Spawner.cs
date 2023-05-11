using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [SerializeField]
    protected float resetTimer;//A timer to reset

    [SerializeField]
    protected float countdownTimer;//A timer to count down

    protected bool isActive;//The state of the objects 
    // Start is called before the first frame update
    protected virtual void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    protected abstract void Update();

    protected abstract void CountdownSpawn();

    public void ToggleActive(bool status)
    {
        isActive = status;
    }
}
