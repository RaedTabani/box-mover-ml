using System.Collections;
using System.Collections.Generic;
using Config;
using UnityEngine;
using Zenject;

namespace Core{
    public class Timer : MonoBehaviour
    {
        private IConfig config;

        private float timer;
        [Inject]
        public void Init(IConfig config){
            this.config = config;
            Debug.Log($"CONFIG CONNECTED TO {gameObject.name}");
        }

        private void Reset(){
            timer = 0;
        }

        private void Update(){
            timer+=Time.deltaTime;

            if(timer> config.maxTrainingSteps){
                //Fire Game over event
            }
        }
       
    }
}
