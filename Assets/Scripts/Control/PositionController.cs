using UnityEngine;
using Zenject;
using Config;

namespace Control{
    [RequireComponent(typeof(Rigidbody))]
    public class PositionController : MonoBehaviour
    {
        public Vector3 Velocity{get=>rb.velocity.normalized;}
        private IConfig config;
        private Rigidbody rb;

        [Inject]
        public void Init(IConfig config)
        {
            this.config = config;
        }

        private void Awake(){
            rb = GetComponent<Rigidbody>();
        }
        public void Move(Vector3 direction){
            rb.AddRelativeForce(direction * config.agentRunSpeed,ForceMode.Force);
        }
        public void Rotate(Vector3 direction){
            rb.AddTorque(direction * config.agentRotationSpeed,ForceMode.Force);
        }
        public void Reset(){
            transform.localPosition = GetRandomSpawnPosition();
        }

        private Vector3 GetRandomSpawnPosition(){
            int attempts = 0;
            do{
                float x = Random.Range(-15,15);

            }while(Physics.OverlapSphere(transform.position,2,LayerMask.GetMask("Player")).Length>0 && attempts< 10);
            
            return default;
        }

    }
}