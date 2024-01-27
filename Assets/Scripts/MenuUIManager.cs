using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public TMP_Text usernameText;
    public TMP_InputField usernameInput;

    public void UpdateUsername(string username)
    {
        usernameText.text = username;
    }

    public string GetCurrentUsernameField()
    {
        return usernameInput.text;
    }

    public void SetUsernameField(string username)
    {
        usernameInput.text = username;
    }
}

