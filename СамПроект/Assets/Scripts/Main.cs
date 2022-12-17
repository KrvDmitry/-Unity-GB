using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputController _inputController;
        private ListExecuteObjectController _executeObject;

        [SerializeField] private Unit _player;


       [SerializeField] private int _numGoodBonusMax ; // Нужно собарть все Хорошие бонусы и тогда уровень пройден
        private int _numGoodBonus; // Сколько собрано бонусов (текущий прогресс)

      

        void Awake()
        {
            _numGoodBonusMax = GameObject.FindGameObjectsWithTag("GoodBonus").Length;

            _inputController = new InputController(_player);
            _executeObject = new ListExecuteObjectController();
            _executeObject.AddExecuteObject(_inputController);
        }

        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < _executeObject.Lenght; i++)
            {
                if(_executeObject.InteractiveObject[i] == null)
                {
                    continue;
                }

                _executeObject.InteractiveObject[i].Update();
            }
        }


        public void ProgressBonus() // Правильно ли то что я выполняю метод подсчета собарнных бонусов отвечающих за прогресс в методе мейн?
        {
            _numGoodBonus++;
            if (_numGoodBonus == _numGoodBonusMax)
            {
                Debug.Log("Уровень Пройден");
               
            }
        }

    }

}
