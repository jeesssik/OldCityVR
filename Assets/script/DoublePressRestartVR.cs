using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoublePressRestartVR : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private float maxDelay = 0.4f;

    private float lastPressTime = -1f;

    private void Update()
    {
        // Botón Y del control izquierdo
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            Debug.Log("Y presionado");

            if (Time.time - lastPressTime <= maxDelay)
            {
                Debug.Log("Doble Y detectado - reiniciando escena");
                RestartScene();
            }

            lastPressTime = Time.time;
        }
    }

    private void RestartScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}