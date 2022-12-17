using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public class Player : Unit
    {
      
        [SerializeField] Bonus bonus;
        [SerializeField] GameObject game;
        public void Awake() // Почему публичный?
        {
            base.Awake();
        }

        public override void Move(float x, float y, float z)
        {
            if(_rb)
            {
                _rb.AddForce(new Vector3(x, y, z) * Speed);
                 
            }
        }

        public override void AppBonus(int bonus)
        {
            
            Health = Health + bonus;
            if (Health <= 0)
            {
                Debug.Log("Вы проиграли");
                gameObject.SetActive(false);
            }

        }


        private void OnTriggerEnter(Collider other)
        {

           
        }



    }

}

