using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoublePressRestartVR : MonoBehaviour
{
    [Header("Configuración")]
    public float maxDelay = 0.4f; // tiempo máximo entre presiones

    private float lastPressTime = -1f;

    void Update()
    {
        // Botón Y = control izquierdo en Meta/Oculus
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (Time.time - lastPressTime <= maxDelay)
            {
                RestartScene();
            }

            lastPressTime = Time.time;
        }
    }

    void RestartScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}