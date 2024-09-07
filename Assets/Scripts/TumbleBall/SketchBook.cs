using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SketchBook : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private List<Vector2> points = new List<Vector2>();
    private LineRenderer lineRenderer;
    private EdgeCollider2D edgeCollider;


    public void OnPointerDown(PointerEventData eventData)
    {
 
        points.Clear();
        beforPoint = Vector2.zero;
        if (!Dyestuffs.Instance.Drawing(0))
        {
            return;
        }
        CreateLine(Dyestuffs.Instance.CurDystuff);
        AddPoint(eventData.position);
    }

    Vector2 beforPoint= Vector2.zero;
    public void OnDrag(PointerEventData eventData)
    {
        float dist = 0;
        if (beforPoint != Vector2.zero)
        {
            dist = Vector2.Distance(beforPoint, eventData.position);
            if (5f>dist)
            {
                return;
            }
        }

        if (!Dyestuffs.Instance.Drawing(dist))
        {  
            CreateCollider();
            OnPointerDown(eventData);
            return;
        }
        AddPoint(eventData.position);
        UpdateLine();

        beforPoint = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (!Dyestuffs.Instance.Drawing(0))
        {
            return;
        }
        AddPoint(eventData.position);
        UpdateLine();
        CreateCollider();
    }

    private void CreateLine(Dyestuff dyestuff)
    {
        GameObject lineObject = new GameObject("LineObject");
        lineObject.transform.SetParent(transform);

        lineRenderer = lineObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));


        lineRenderer.useWorldSpace = false; 
        lineRenderer.sortingOrder = 10;


        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;

        GameObject collider = new GameObject();
        collider.transform.SetParent(lineObject.transform);

        edgeCollider = collider.AddComponent<EdgeCollider2D>();
        edgeCollider.edgeRadius = 0.05f;
        collider.transform.localScale = Vector3.one / lineObject.transform.localScale.x;
        dyestuff.Create(lineRenderer,edgeCollider);
  
    }

    private void AddPoint(Vector2 point)
    {


        points.Add(point);
    }

    private void UpdateLine()
    {
        lineRenderer.positionCount = points.Count;
        for (int i = 0; i < points.Count; i++)
        {
            Vector3 worldPoint;
            RectTransformUtility.ScreenPointToWorldPointInRectangle(transform as RectTransform, points[i], Camera.main, out worldPoint);
            lineRenderer.SetPosition(i, worldPoint);
        }
    }

    private void CreateCollider()
    {
        Vector2[] colliderPoints = new Vector2[points.Count];
        RectTransform rectTransform = transform as RectTransform;

        for (int i = 0; i < points.Count; i++)
        {
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, points[i], Camera.main, out localPoint);

            colliderPoints[i] = localPoint;
        }

        edgeCollider.points = colliderPoints;
    }
}
