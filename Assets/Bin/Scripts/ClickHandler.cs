using System.Collections;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private PlayerData pData;
    [SerializeField] private GameData gData;
    
    private void OnClick()
    {
        
    }

    private IEnumerable OnAutoClick()
    {
        yield return new WaitForSeconds(1f);
    }
}
