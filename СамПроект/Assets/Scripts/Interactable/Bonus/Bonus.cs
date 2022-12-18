using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {

        private bool _isInteractable;
      //  protected Color _color; // Почему протектед?
        private Renderer _renderer;
        private Collider _collider;
     
       protected GameObject _player;


        protected int AppBonus;


        public bool IsInteractable
        {
            get => _isInteractable;
            set
            {
                _isInteractable = value;
                _renderer.enabled = value;
                _collider.enabled = value;
            }
        }
        
        public virtual void Awake()
        {
            if (!TryGetComponent<Renderer>(out _renderer))
            {
                Debug.Log("No Renderer Component");
            }

            if (!TryGetComponent<Collider>(out _collider))
            {
                Debug.Log("No Colliderr Component");
            }

            IsInteractable = true;
          //  _color = Random.ColorHSV();
           // _renderer.sharedMaterial.color = _color;
        }
  

       

        protected virtual void OnTriggerEnter(Collider other) 
        {
            if (other.CompareTag("Player"))
            {
                _player = other.gameObject;
                _player.GetComponent<Player>().AppBonus(AppBonus);
                Debug.LogError("Столкновение" + this.GetType().Name);

                Interaction();


            }






        }
        //я так и не понял в каких случаях создают объекты классов, если Классы без них реализуют действия




        public abstract void Interaction();
        public abstract void Update(); // Я правильно понял что этот метод не вызывается пока его не вызовут в Классе Main ?, у наследников тоже они не вызовутся пока их не вызовут в Классе Main?

       
    }

}

