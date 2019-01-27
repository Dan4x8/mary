using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Animator _player;

    public bool Agency { get; set; }

    private void Start()
    {
        Agency = true;
    }

    void Update()
    {
        if(!Agency)
        {
            return;
        }

        _player.SetFloat("X", Input.GetAxis("Horizontal"));
    }

    public Animator GetAnimator()
    {
        return _player;
    }
}
