using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Cryscript : MonoBehaviour
{
    private AudioSource _asrc;

    private void Start()
    {
        _asrc = GetComponent<AudioSource>();
    }

    [SerializeField]
    private float delay = 5f;

    private void Update()
    {
        delay -= Time.deltaTime;

        if(delay <= 0)
        {
            if(!_asrc.isPlaying)
                _asrc.Play();
            else
                delay = Random.Range(3f, 10f);
        }
    }
}
