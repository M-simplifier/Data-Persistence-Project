using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text usernameText;
    public TMP_Text bestScoreText;

    public void SetUsernameText(string username)
    {
        usernameText.text = username;
    }

    public void SetBestScoreText(string username, int score)
    {
        bestScoreText.text = username + " : " + score;
    }
}

