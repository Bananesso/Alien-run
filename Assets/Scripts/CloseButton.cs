using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject layerOff;

    public void Close()
    {
        layerOff.gameObject.SetActive(false);
    }
}