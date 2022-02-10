using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator animator;
    float _randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        _randomNumber = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(AnimateIdle(_randomNumber));
    }

    IEnumerator AnimateIdle(float idleTime)
    {
        yield return new WaitForSeconds(idleTime);
        animator.SetTrigger("IdleB");
    }

}// CLASS
