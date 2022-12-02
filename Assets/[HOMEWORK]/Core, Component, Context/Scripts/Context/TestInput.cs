using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    private void Update()
    {
        this.HandleKeyboard();
    }

    private void HandleKeyboard()
    {
        //для проверки работоспособности, если при инициализации скрипт отключен, то клавиатура не реагирует
        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("eeee");
        }

    }
}
