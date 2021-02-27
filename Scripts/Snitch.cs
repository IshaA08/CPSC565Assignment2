using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float movementDuration = 2.0f;
    private float waitBeforeMoving = 0.3f;
    private bool hasArrived = false;

    private void Update()
    {
        if (!hasArrived)
        {
            hasArrived = true;
            float randX = Random.Range(-30.0f, 30.0f);
            float randY = Random.Range(0.0f, 20.0f);
            float randZ = Random.Range(-50.0f, 50.0f);
            StartCoroutine(MoveToPoint(new Vector3(randX, randY, randZ)));
        }
}

    private IEnumerator MoveToPoint(Vector3 targetPos)
    {
        float timer = 0.0f;
        Vector3 startPos = transform.position;

        while (timer < movementDuration)
        {
            timer += Time.deltaTime;
            float t = timer / movementDuration;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            transform.position = Vector3.Lerp(startPos, targetPos, t);

            yield return null;
        }

        yield return new WaitForSeconds(waitBeforeMoving);
        hasArrived = false;
    }

}
