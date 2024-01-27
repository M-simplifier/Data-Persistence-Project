using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public MenuUIManager menuUIManager;

    // Start is called before the first frame update

    void Start()
    {
        GlobalSettings.Instance.Load();
        menuUIManager.SetUsernameField(GlobalSettings.Instance.CurrentUsername);
        menuUIManager.UpdateUsername(GlobalSettings.Instance.CurrentUsername);
    }

    public void UpdateMenuState()
    {
        UpdateGlobalSettings();
        UpdateMenuUI();
    }

    public void UpdateGlobalSettings()
    {
        GlobalSettings.Instance.CurrentUsername = menuUIManager.GetCurrentUsernameField();
    }

    public void UpdateMenuUI()
    {
        menuUIManager.UpdateUsername(GlobalSettings.Instance.CurrentUsername);
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("main");
    }
}
