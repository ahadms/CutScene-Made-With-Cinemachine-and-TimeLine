using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerForwardmoving : MonoBehaviour
{
    private CharacterController character;
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(0, 0, 1.3f);
        character.SimpleMove(move);

    }
}
