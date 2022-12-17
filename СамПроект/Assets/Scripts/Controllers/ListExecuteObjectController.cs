﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // Для Класса Array


namespace Maze
{
    public class ListExecuteObjectController
    {
        private IExecute[] _interactiveObject;

        public int Lenght => _interactiveObject.Length;

        public IExecute[] InteractiveObject { get => _interactiveObject; set => _interactiveObject = value; }

        public ListExecuteObjectController()
        {

        }

        public void AddExecuteObject(IExecute execute)
        {
            if (InteractiveObject == null)
            {
                InteractiveObject = new[] { execute };
                return;
            }

            Array.Resize(ref _interactiveObject, Lenght + 1);
            InteractiveObject[Lenght - 1] = execute;
            

            
        }
    }
}

