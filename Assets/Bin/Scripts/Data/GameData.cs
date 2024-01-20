using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New game data file", menuName = "Data/Game Data", order = 0)]
public class GameData : ScriptableObject
{
    [field: SerializeField] public float DamageMultiplierPerLevel { get; set; }
    [field: SerializeField] public float PriceMultiplierPerLevel { get; set; }
    [field: SerializeField] public float HealthMultiplierPerLevel { get; set; }
    [field: SerializeField] public float InstantBoostDuration { get; set; }
    [field: SerializeField] public float BoostDuration { get; set; }
}