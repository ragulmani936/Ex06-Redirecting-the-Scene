using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubecPlayer : MonoBehaviour
{
    Rigidbody rb;
    public GameObject winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("level2");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("sphere"))
        {
            Destroy(other.gameObject);
            
                winText.SetActive(true);
            
        }
    }
}