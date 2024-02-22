using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsUtility : MonoBehaviour
{
    [ContextMenu("DeleteSaveData")]
    public void DeleteSaveData()
    {
        PlayerPrefs.DeleteAll();
    }
}
