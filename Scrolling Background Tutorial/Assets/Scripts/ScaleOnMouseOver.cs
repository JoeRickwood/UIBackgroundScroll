using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleOnMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AnimationCurve scaleCurve;
    public float speed;

    public float startScale;
    public float endScale;

    bool mouseOver;
    float time;
    private void Update()
    {
        if(mouseOver)
        {
            time += Time.deltaTime * speed;
        }else
        {
            time -= Time.deltaTime * speed;
        }

        time = Mathf.Clamp01(time);

        transform.localScale = Vector3.one * Mathf.Lerp(startScale, endScale, scaleCurve.Evaluate(time));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseOver = false;
    }
}
