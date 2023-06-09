using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del objeto
    public float rotateSpeed = 100f; // Velocidad de rotación del objeto

    void Update()
    {
        // Obtiene los valores de entrada horizontal y vertical solo si se usan las flechas de dirección
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput = -1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1f;
        }

        // Calcula el vector de movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * speed * Time.deltaTime;

        // Mueve el objeto en la dirección del vector de movimiento
        transform.Translate(movement, Space.Self);

        // Rota el objeto hacia la izquierda o la derecha al presionar flecha izquierda o derecha respectivamente
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
