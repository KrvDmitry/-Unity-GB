using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class DeadBonus : Bonus //Класс Бонуса который моментально убивает
    {
        [SerializeField] private Transform _targetPos1, _targetPos2;
        private Transform _target; // Куда в данный момент движется цель




        public override void Awake()
        {
            base.Awake();
            AppBonus = -100;
            _target = _targetPos1;
        }





        public override void Update()
        {
            MoveBonus();
        }


        public override void Interaction()
        {


           
            IsInteractable = false;



        }

        private void MoveBonus ()
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime);



            transform.LookAt(new Vector3(_target.position.x, transform.position.y, _target.position.z));
        }





        protected override void OnTriggerEnter(Collider other) // Правильно что я переопределил метод чтобы добавить функционал или нужно было реализовать через интерфейс или вообще иначе?
        {
            base.OnTriggerEnter(other);
            if (other.transform == _targetPos1)
            {
                _target = _targetPos2;
            }

            if (other.transform == _targetPos2)
            {
                _target = _targetPos1;
            }
        }

    }


    

}
