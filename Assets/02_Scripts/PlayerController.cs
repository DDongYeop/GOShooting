using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    KeyCode keyCodeAttack = KeyCode.Space;
    [SerializeField] 
    StageData stageData;
    
    Movement movement;
    Weapon weapon;

    void Awake()
    {
        movement = GetComponent<Movement>();
        weapon = GetComponent<Weapon>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        movement.MoveTo(new Vector3(x, y, 0));

        if(Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFriring();
        }
        else if (Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y), 0);
    }
}
