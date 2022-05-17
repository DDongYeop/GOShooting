using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroy : MonoBehaviour
{
    [SerializeField] StageData stageData;
    float destroyWeight = 2f;

    private void LateUpdate()
    {
        if(transform.position.x > stageData.LimitMax.x + destroyWeight || 
           transform.position.x < stageData.LimitMin.x - destroyWeight ||
           transform.position.y > stageData.LimitMax.y + destroyWeight || 
           transform.position.y < stageData.LimitMin.y - destroyWeight )
            Destroy(gameObject);
    }
}
