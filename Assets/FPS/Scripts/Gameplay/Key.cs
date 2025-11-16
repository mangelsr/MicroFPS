using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed;
    [SerializeField] private GameObject keyAcquiredMessage;
    [SerializeField] private SphereCollider collider;
    [SerializeField] private MeshRenderer renderer;

    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        KeyHolder keyHolder = other.GetComponent<KeyHolder>();
        if (keyHolder != null)
        {
            Destroy(collider);
            Destroy(renderer);
            keyHolder.hasKey = true;
            //Destroy(gameObject, 5);
            StartCoroutine(ShowKeyAcquiredMessage());
        }
    }

    IEnumerator ShowKeyAcquiredMessage()
    {
        keyAcquiredMessage.SetActive(true);
        yield return new WaitForSeconds(4);
        keyAcquiredMessage.SetActive(false);
    }
}
