using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowHeadCanvas : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private float distance = 1.2f;
    [SerializeField] private float verticalOffset = 0f;

    private void LateUpdate()
    {
        if (head == null) return;

        Vector3 targetPosition =
            head.position +
            head.forward * distance +
            head.up * verticalOffset;

        transform.position = targetPosition;

        transform.rotation = Quaternion.LookRotation(
            transform.position - head.position
        );
    }
}