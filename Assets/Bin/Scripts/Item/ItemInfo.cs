using System;
using UnityEngine;

[Serializable]
public class ItemInfo : ScriptableObject
{
    [field: SerializeField] public string ItemId { get; set; }
}