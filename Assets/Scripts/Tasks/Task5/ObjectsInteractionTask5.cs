using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    
    [SerializeField] private Shelf _shelf;

    [SerializeField] private int _countOfSpawnedItems = 3;

    private void Start()
    {
       _shelf.ItemSpawned += OnItemSpawned;
    }

    private void OnItemSpawned()
    {
        _countOfSpawnedItems--;
        if (_countOfSpawnedItems==0)
        {
            _shelf.Fall();
        }
    }
    
    private void OnDestroy()
    {
        _shelf.ItemSpawned -= OnItemSpawned;
    }
}