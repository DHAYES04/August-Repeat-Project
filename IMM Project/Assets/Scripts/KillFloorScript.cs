using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class KillFloorScript : MonoBehaviour
{
    [SerializeField] private string sceneName; // Name of the scene to load

    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene(sceneName); // Load the specified scene

    }
}
