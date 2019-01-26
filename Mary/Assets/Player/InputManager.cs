using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Animator _player;
    
    void Update()
    {
        _player.SetFloat("X", Input.GetAxis("Horizontal"));
    }
}
