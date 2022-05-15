using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    private TMP_Text _healthDisplay;

    private void Awake()
    {
        _healthDisplay = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _player.HeathChanged += OnHeathChanged;
    }

    private void OnDisable()
    {
        _player.HeathChanged -= OnHeathChanged;
    }

    private void OnHeathChanged(int health)
    {
        _healthDisplay.text = health.ToString();
    }
}
