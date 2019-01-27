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

    [SerializeField]
    private float minDelay = 3f;
    [SerializeField]
    private float maxDelay = 10f;

    [SerializeField]
    private bool _randomPitch = false;

    private void Update()
    {
        delay -= Time.deltaTime;

        if(delay <= 0)
        {
            if(!_asrc.isPlaying)
            {
                if(_randomPitch)
                    _asrc.pitch = Random.Range(.6f, 1.4f);
                _asrc.Play();
            }
            else
                delay = Random.Range(minDelay, maxDelay);
        }
    }
}
