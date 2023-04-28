using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [SerializeField] int LoadSceneIndex;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
            LoadScene(LoadSceneIndex);
		}
    }

    private void LoadScene(int sceneId)
	{
        SceneManager.LoadSceneAsync(sceneId); //this bitch is the winner!**
        //SceneManager.LoadScene(sceneId);
	}
}
