using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject StartPanel;
    [SerializeField] GameObject GamePanel;

    public void ToggleGamePanel()
    {
        StartPanel.SetActive(!StartPanel.activeSelf);
        GamePanel.SetActive(!GamePanel.activeSelf);
    }
}
