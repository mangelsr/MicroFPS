using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] private GameObject needAKeyMessage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            KeyHolder keyHolder = other.GetComponent<KeyHolder>();
            if (keyHolder != null)
            {
                if (keyHolder.hasKey)
                {
                    Destroy(gameObject);
                }
                else
                {
                    StartCoroutine(NeedKeyMessage());
                }
            }
        }
    }

    IEnumerator NeedKeyMessage()
    {
        needAKeyMessage.SetActive(true);
        yield return new WaitForSeconds(4);
        needAKeyMessage.SetActive(false);
    }
}
