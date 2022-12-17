//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    


    public abstract class Unit : MonoBehaviour
    {
       

        public Transform _transform;
        public Rigidbody _rb;

        private float _speed = 5f;
        [SerializeField]private int _health = 100;
        private bool _isDead;

        public int Health { get => _health; set 
            {
                if (value > 0)
                {
                    if (value <= 100)
                    {
                        _health = value;
                        Debug.LogError("1");
                    }

                    else
                    {
                        _health = 100;
                        Debug.LogError("2");

                    }
                }

                else
                {
                    _health = value;
                    Debug.LogError("3");
                }



            } 
        }

       [SerializeField] public float Speed { get => _speed; set => _speed = value; }

        public virtual void Awake()
   
        {
            if (!TryGetComponent<Transform>(out _transform))
            {
                Debug.Log("No Transform Component");
            }

            if (!TryGetComponent<Rigidbody>(out _rb))
            {
                Debug.Log("No Rigidbody Component");
            }

        }


        public abstract void Move(float x, float y, float z);


        public abstract void AppBonus(int bonus);



        //private void OnTriggerEnter(Collider other)
        //{

        //    if (other.gameObject.tag == "Bonus")
        //    {
              


             

        //    }


        //}
    }

}
