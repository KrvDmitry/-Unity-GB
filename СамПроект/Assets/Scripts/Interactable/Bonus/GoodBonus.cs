using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public class GoodBonus : Bonus
    {
        [SerializeField] private GameObject MainObj; 
        
        public override void Awake()
        {
            base.Awake();
            AppBonus = 20;
            MainObj = GameObject.FindGameObjectWithTag("Main"); // Правильно что я обращаюсь к мейн в этом Классе или подсчет бонусов лучше производить както иначе ? ?
           
        }

      


     
        public override void Update()
        {

        }


        public override void Interaction()
        {


            MainObj.GetComponent<Main>().ProgressBonus();

            
            
            IsInteractable = false;



        


        }




    }





}

  
