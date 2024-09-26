using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoTitle : MonoBehaviour
{
    
    public void TitleReturn()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
