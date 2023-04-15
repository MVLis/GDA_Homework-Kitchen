using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    [SerializeField]
    private Lamp[] _lamps;
    
    private void Start()
    {
        _lamps = FindObjectsOfType<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Keypad2))
        {
            foreach (var Lamp in _lamps)
            {
                Lamp.Interact();
            }
        }
    }
}