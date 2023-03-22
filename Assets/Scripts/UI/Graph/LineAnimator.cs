using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimator : MonoBehaviour
{
    [SerializeField] public float animationDuration = 53f;

    private LineRenderer lineRenderer;
    public Vector3[] linePoints;
    private int pointsCount;
    public Vector3 startPosition;
    public Vector3 endPosition;

    //private float segmentDuration;


    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        pointsCount = lineRenderer.positionCount;
        linePoints = new Vector3[pointsCount];

        for(int i=0; i<pointsCount; i++)
        {
            linePoints[i] = lineRenderer.GetPosition(i);
        }

        StartCoroutine (AnimateLine());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator AnimateLine()
    {
       //float segmentDuration = animationDuration / pointsCount;

        for (int i =0; i<pointsCount-1; i++)
        {
            float startTime = Time.time;

            startPosition = linePoints[i];
            endPosition = linePoints[i+1];

            Vector3 pos = startPosition;

            while (pos != endPosition)
            {
                float t = (Time.time - startTime) / (animationDuration / pointsCount);
                pos = Vector3.Lerp(startPosition, endPosition, t);

                for (int j = i + 1; j < pointsCount; j++)
                    lineRenderer.SetPosition(j, pos);

                yield return null;
            }
        }


    }

    public void  startParallel()
    {
        lineRenderer = GetComponent<LineRenderer>();

        pointsCount = lineRenderer.positionCount;
        linePoints = new Vector3[pointsCount];

        for (int i = 0; i < pointsCount; i++)
        {
            linePoints[i] = lineRenderer.GetPosition(i);
        }

    }
}