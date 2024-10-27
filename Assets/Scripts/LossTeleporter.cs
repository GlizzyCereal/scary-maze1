using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossTeleporter : MonoBehaviour
{
    private string sceneToLoad = "Level 1";

    private void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}