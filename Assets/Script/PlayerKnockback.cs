using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Events;

public class PlayerKnockback : MonoBehaviour//, IDataPersistence
{
    [SerializeField] private Rigidbody2D rb;

    Health health;
    Animator animator;

    [SerializeField] private float strength =16 ,delay = 0.15f;

    public UnityEvent OnBegin,OnDone;

    public void Awake()
    {
        animator = GetComponent<Animator>();
        health=GetComponent<Health>();
    }
    
    // connect to GameData and Data Persistence for save the player's last position 
    // public void LoadData(GameData data)
    // {
    //     this.transform.position = data.playerPosition;
    // }

    // public void SaveData(ref GameData data)
    // {
    //     data.playerPosition = this.transform.position;
    // }

    public void PlayFeedback(GameObject sender)
    {
        StopAllCoroutines();
        OnBegin?.Invoke();
        animator.SetBool("GettingHit",true);
        UnityEngine.Vector2 direction = (transform.position - sender.transform.position).normalized;
        rb.AddForce(direction*strength,ForceMode2D.Impulse);
        StartCoroutine(Reset());
    }

    private IEnumerator Reset()
    {
        yield return new  WaitForSeconds(delay);
        rb.velocity = UnityEngine.Vector3.zero;
        animator.SetBool("GettingHit",false);
        OnDone?.Invoke();

    }

    private void OnTriggerEnter2D(Collider2D sender)
    {
        float push=5;
        if(sender.tag == "Enemy" && health.isDead == false)
        {
            StopAllCoroutines();
            OnBegin?.Invoke();
            animator.SetBool("GettingHit",true);
        
            UnityEngine.Vector2 direction = (transform.position - sender.transform.position).normalized;
            rb.AddForce(direction*push,ForceMode2D.Impulse);
            StartCoroutine(Reset());
        }
    }
    
}