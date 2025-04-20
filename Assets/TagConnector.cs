using UnityEngine;
using UnityEngine.UI;

public class TagConnector : MonoBehaviour
{
    [SerializeField] private RectTransform anchorPoint;
    [SerializeField] private RectTransform nameTag;
    [SerializeField] private float lineThickness = 0.02f;
    [SerializeField] private Color lineColor;
    [SerializeField] private LineRenderer lineObject;

    private void Start()
    {
        lineObject= GetComponent<LineRenderer>();
        lineObject.positionCount = 2;
        lineObject.SetPosition(0, nameTag.transform.position);
        lineObject.SetPosition(1, anchorPoint.transform.position);
        lineObject.SetWidth(lineThickness, lineThickness);
        lineObject.SetColors(lineColor, lineColor);
    }

    private void Update()
    {
        lineObject.SetPosition(0, nameTag.transform.position);
        lineObject.SetPosition(1, anchorPoint.transform.position);        
    }


}
