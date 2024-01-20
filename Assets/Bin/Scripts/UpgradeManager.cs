using System.Numerics;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private GameData gData;
    
    public void Upgrade(Bot bot)
    {
        bot.CurrentDamage = bot.NextDamage;
        bot.CurrentPrice = bot.NextPrice;
        bot.NextDamage = bot.InitDamage * (BigInteger)(gData.DamageMultiplierPerLevel * bot.CurrentLevel);
    }
}