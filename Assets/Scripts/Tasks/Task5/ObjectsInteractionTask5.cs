using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    
    [SerializeField] private Shelf[] _shelfs;

    private int _counter = 0;

    private void Start()
    {
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned += СheckForStrength;
        }
    }

    private void СheckForStrength()
    {
        _counter++;
        foreach (var shelf in _shelfs)
        {
            if (_counter==3)
            {
                shelf.Fall();
            }
        }
    }

    private void OnDestroy()
    {
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned -= СheckForStrength;
        }
    }
}