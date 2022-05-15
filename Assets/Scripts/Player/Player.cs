using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int> HeathChanged;

    private void Start()
    {
        HeathChanged?.Invoke(_health);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HeathChanged?.Invoke(_health);
        
        if (_health <= 0)
            Die();
        
    }

    private void Die()
    {
        Debug.Log("I'm die");
    }
}
