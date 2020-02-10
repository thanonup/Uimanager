using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelMNG : MonoBehaviour
{
    public GameObject SettingPOP;

    public void PopUpSetting()
    {
        bool isActive = SettingPOP.activeSelf;
        SettingPOP.SetActive(!isActive);
    }
}
