using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator animator;
    float _idleStartTime;
    float _idleMinLoopingTime = 1f;
    private float idle2AnimationTime = 3f;
    


    // Start is called before the first frame update
    void Start()
    {
        _idleStartTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > _idleMinLoopingTime + _idleStartTime)
        {
            int randomNumber = Random.Range(0, 10);

            if (randomNumber >= 5)
            {
                animator.SetTrigger("IdleB");
                _idleStartTime = Time.time + 3f;
            }
            else
                _idleStartTime = Time.time;

        }
        





        MovePlayer();
    }
    void MovePlayer()
    {

        transform.position += GetInput() * 10 * Time.deltaTime;
        

        if (GetInput()!= Vector3.zero) {
            animator.SetBool("isWalking", true);     
        }

        else
        {
            animator.SetBool("isWalking", false);
            _idleStartTime = Time.time;
        }
    }

    Vector3 GetInput()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(xMove, 0, zMove);
        return movement;
    }
}// CLASS
