using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToWorld : MonoBehaviour
{

        void OnTriggerEnter2D(Collider2D other)
        {
        PlayerController controller = other.GetComponent<PlayerController>();
        if (controller != null)
        {
            controller.DestroyPlayer();
        }
            if (other.GetComponent<PlayerController>() != null)
            {
                SceneManager.LoadScene("World", LoadSceneMode.Single);
            }
        }
}
