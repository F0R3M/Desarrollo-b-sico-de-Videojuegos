using UnityEngine;

public class Win : MonoBehaviour
{
    public Canvas targetCanvas;

    void Start()
    {
        if (targetCanvas != null)
        {
            targetCanvas.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (targetCanvas != null)
            {
                targetCanvas.gameObject.SetActive(true);
            }
        }
    }

    /*void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (targetCanvas != null)
            {
                targetCanvas.gameObject.SetActive(false);
            }
        }
    }*/
}
