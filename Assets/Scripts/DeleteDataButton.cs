using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteDataButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClicked()
    {
        GlobalSettings.Instance.ResetBestScore();
    }
}
