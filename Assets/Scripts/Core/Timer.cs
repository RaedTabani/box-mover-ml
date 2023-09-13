using System.Collections;
using System.Collections.Generic;
using Config;
using UnityEngine;
using Zenject;

namespace Core{
    public class Timer : MonoBehaviour
    {
        private IConfig config;

        [Inject]
        public void Init(IConfig config){
            this.config = config;
            Debug.Log($"CONFIG CONNECTED TO {gameObject.name}");
        }
       
    }
}
