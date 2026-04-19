using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCounterManager : MonoBehaviour
{
    public static ObjectCounterManager Instance;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI counterText;

    private int currentCount = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        UpdateCounterUI();
    }

    public void AddPoint()
    {
        currentCount++;
        UpdateCounterUI();
    }

    private void UpdateCounterUI()
    {
        if (counterText != null)
        {
            counterText.text = currentCount.ToString();
        }
    }

    public int GetCurrentCount()
    {
        return currentCount;
    }
}