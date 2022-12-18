using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimSceneChange : MonoBehaviour
{

    private void SceneChange()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();

        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }
}
