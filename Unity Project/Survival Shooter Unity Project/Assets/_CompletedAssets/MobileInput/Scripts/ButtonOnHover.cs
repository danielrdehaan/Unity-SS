using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Debug Messages")]
    public bool debug = true;
    public string mouseEnter = "Mouse Enter";
    public string mouseExit = "Mouse Exit";

    private string objectName;

    // Start is called before the first frame update
    void Start()
    {
        objectName = gameObject.name;
    }

    // Mouse is hovering over the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (debug)
        {
            Debug.Log(objectName + ": " + mouseEnter);
        }
    }

    // Mouse is no longer hovering over the button
    public void OnPointerExit(PointerEventData eventData)
    {
        if (debug)
        {
            Debug.Log(objectName + ": " + mouseExit);
        }
    }
}
