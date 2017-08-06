using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitController : MonoBehaviour {
    public Text statusText;
    
    void Start()
    {
        statusText.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && statusText.enabled == false)
        {
            other.gameObject.SetActive(false);
            statusText.enabled = true;
        }
    }

}
