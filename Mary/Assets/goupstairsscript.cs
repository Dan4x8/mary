using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goupstairsscript : MonoBehaviour
{
    [SerializeField]
    private InputManager _input;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetButtonDown("Action") && _input.Agency)
        {
            _input.Agency = false;
            _input.GetAnimator().SetFloat("X", 1);
            _input.GetAnimator().GetComponent<Rigidbody2D>().AddForce(Vector2.up*90f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!_input.Agency)
        {
            _input.Agency = true;
            _input.GetAnimator().GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}
