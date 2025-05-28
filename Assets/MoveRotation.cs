using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float _speedMove = 8f;
    public float SpeedMove => _speedMove;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //float x = Input.GetAxis("Horizontal") * _speedMove * Time.deltaTime; // влево-вправо
        float z = Input.GetAxis("Vertical") * _speedMove * Time.deltaTime;

        Vector3 movement = new Vector3(0, 0, z);

        movement = Vector3.ClampMagnitude(movement, _speedMove);

        movement = transform.TransformDirection(movement);

        controller?.Move(movement);
    }

}
