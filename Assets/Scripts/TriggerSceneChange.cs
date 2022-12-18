using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();

        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }
}
