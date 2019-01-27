using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Animator _player;

    private bool _hasAgency = true;

    void Update()
    {
        if(!_hasAgency)
        {
            return;
        }

        _player.SetFloat("X", Input.GetAxis("Horizontal"));
    }
}
