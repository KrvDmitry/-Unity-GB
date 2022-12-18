using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class BadBonus : Bonus


    { // Если я чтото еще упустил в проекте,не там объявил, не от туда вызывал или не правильно реализовал, то опишите пожалуйста, переживаю что упущу нюансы 
        public override void Awake()
        {
            base.Awake();
            AppBonus = -30;
        }





        public override void Update()
        {

        }


        public override void Interaction()
        {


            
            IsInteractable = false;



        }

        

    }

}
