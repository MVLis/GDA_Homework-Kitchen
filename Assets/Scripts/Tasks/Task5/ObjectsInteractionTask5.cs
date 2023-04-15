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
        _shelfs.Initialize();
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned += MakeFall;
        }
    }

    private void MakeFall()
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
    
    
}