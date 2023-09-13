using UnityEngine;
using Zenject;
using Config;

namespace Control{
    [RequireComponent(typeof(Rigidbody))]
    public class PositionController : MonoBehaviour
    {
        private IConfig config;
        
        private Rigidbody rb;

        [Inject]
        public void Init(IConfig config)
        {
            this.config = config;
            Debug.Log($"CONFIG CONNECTED TO {gameObject.name}");
        }

        private void Awake(){
            rb = GetComponent<Rigidbody>();
        }


        public void Move(Vector3 direction){
            Debug.Log($"MOVING {direction}");
            rb.AddRelativeForce(direction * config.agentRunSpeed,ForceMode.Force);
        }
        public void Rotate(Vector3 direction){
            //transform.Rotate(direction, Time.fixedDeltaTime * config.agentRotationSpeed);
            rb.AddTorque(direction * config.agentRotationSpeed,ForceMode.Force);
        }
        public void Reset(){

        }

    }
}