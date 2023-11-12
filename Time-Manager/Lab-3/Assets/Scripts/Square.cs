using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private float interval = 600f;
    
    public void OnEnable()
    {
        TimeManager.OnMinuteChanged += TimeCheck;
    }

    public void OnDisable()
    {
        TimeManager.OnMinuteChanged -= TimeCheck;
    }

    private void TimeCheck()
    {
        if (TimeManager.Hour == 10 && (TimeManager.Minute == 10 || TimeManager.Minute == 20 || TimeManager.Minute == 30 || TimeManager.Minute == 40 || TimeManager.Minute == 50))
        {
            StartCoroutine(MoveSquare());
        }   
    }

    private IEnumerator MoveSquare()
    {
        transform.position = new Vector3(-100f,100f,0);
        Vector3 targetPos = new Vector3(1100f,100f,0);

        Vector3 currentPos = transform.position;

        float timeElapsed = 0;
        float timeToMove = 3;

        while(timeElapsed < timeToMove){
            transform.position = Vector3.Lerp(currentPos,targetPos,timeElapsed/timeToMove);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }
}
