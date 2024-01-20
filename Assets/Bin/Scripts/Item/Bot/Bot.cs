using System;
using System.Numerics;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New bot", menuName = "Item/Bot", order = 0)]
public class Bot : BotInfo
{
    [field: SerializeField] public BigInteger CurrentPrice { get; set; }
    [field: SerializeField] public BigInteger CurrentDamage { get; set; }
    [field: SerializeField] public BigInteger NextPrice { get; set; }
    [field: SerializeField] public BigInteger NextDamage { get; set; }
    [field: SerializeField] public float CurrentLevel { get; set; }
}