using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseToWorld : MonoBehaviour
{

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<PlayerController>() != null)
            {
                SceneManager.LoadScene("World", LoadSceneMode.Additive);
            }
        }
}
