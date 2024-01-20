using System;
using System.Numerics;
using UnityEngine;

[Serializable]
public class BotInfo : ItemInfo
{
    [field: SerializeField] public string Name { get; set; }
    [field: SerializeField] public string Description { get; set; }
    [field: SerializeField] public BigInteger InitPrice { get; set; }
    [field: SerializeField] public BigInteger InitDamage { get; set; }
}