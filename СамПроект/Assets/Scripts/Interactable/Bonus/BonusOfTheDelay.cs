using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 namespace Maze
{
    public class BonusOfTheDelay : Bonus // Замедление Игрока 

    // Если я чтото еще упустил в проекте,не там объявил, не от туда вызывал или не правильно реализовал, то опишите пожалуйста, переживаю что упущу нюансы 
    {
        private bool _isEffectWorks;
        private float _effectTime;
        private float _timer;





        public override void Awake()
        {
            base.Awake();
           
            _isEffectWorks = false;
            _effectTime = 5;

        }





        public override void Update()
        {
            if (_isEffectWorks == true)
            {
                _timer = _timer + Time.deltaTime;

                if (_timer >= _effectTime)
                {
                    _isEffectWorks = false;
                    _player.GetComponent<Player>().Speed = _player.GetComponent<Player>().Speed * 2f; // Я слышал что ГетКомпонент лучше не вызывать, как обойти его в данный момент и целесообразно это вообще ?
                }
            }
        }


        public override void Interaction()
        {

            _isEffectWorks = true;
            _player.GetComponent<Player>().Speed = _player.GetComponent<Player>().Speed * 0.5f;
            
            IsInteractable = false;



        }



    }

}
