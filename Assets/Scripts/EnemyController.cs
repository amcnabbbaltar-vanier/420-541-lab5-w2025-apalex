using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        Console.WriteLine("GOTHITT");
        hitParticles.Play();
        audioSource.Play();
        GameManager.Instance.IncrementScore();
    }
}
