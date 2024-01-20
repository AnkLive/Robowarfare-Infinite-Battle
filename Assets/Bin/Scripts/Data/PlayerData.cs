using System;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New player data file", menuName = "Data/Player Data", order = 0)]
public class PlayerData : ScriptableObject
{
    private List<Bot> _bots;
    private List<Boost> _boosts;
    private BigInteger _coinCount;
    private float _currentLevel;
}