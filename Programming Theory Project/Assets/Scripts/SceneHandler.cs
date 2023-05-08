using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [SerializeField] int LoadSceneIndex;
    private bool isBusy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBusy)
		{
            isBusy = true;
            LoadScene(LoadSceneIndex);
		}
    }

    private void LoadScene(int sceneId)
	{
        SceneManager.LoadSceneAsync(sceneId);
	}
}
