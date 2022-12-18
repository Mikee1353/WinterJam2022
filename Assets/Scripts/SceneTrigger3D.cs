using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger3D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();

        Initiate.Fade("Cinematic1", Color.black, 30f);

        //SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }
}
