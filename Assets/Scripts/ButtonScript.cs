using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject layerOn;

    public void Open()
    {
        layerOn.gameObject.SetActive(true);
    }
}