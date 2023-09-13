using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Control;
using Zenject;
using Events;
using Config;

namespace AI{
    [RequireComponent(typeof(PositionController))]
    public class Mover : Agent
    {
        private IRewardHandler rewardHandler;
        private IConfig config;
        private PositionController controller;

        [Inject]
        private void Init(IConfig config, IRewardHandler rewardHandler){
            this.config = config;
            this.rewardHandler = rewardHandler;
        }

        private void OnEnable(){
            EventBus.Subscribe(TrainingEventType.Gamewin,GrantReward);
            EventBus.Subscribe(TrainingEventType.Gamelose,ApplyPunishment);
        }
        private void OnDisable() {
            EventBus.Unsubscribe(TrainingEventType.Gamewin,GrantReward);
            EventBus.Unsubscribe(TrainingEventType.Gamelose,ApplyPunishment);        
        }
       
        public override void Initialize(){
            controller = GetComponent<PositionController>();    
        }
        public override void OnEpisodeBegin()
        {
            controller.Reset();
        }
        public override void OnActionReceived(ActionBuffers actions){
            ActionSegment<float> continousActions = actions.ContinuousActions;
            Vector3 direction = new Vector3(continousActions[0],0,continousActions[1]);
            Vector3 rotation = new Vector3(0,continousActions[2],0);

            controller.Move(direction);
            controller.Rotate(rotation);

            rewardHandler.HandleReward(this,config.existantial);
        }
        public override void CollectObservations(VectorSensor sensor)
        {
           sensor.AddObservation(transform.localPosition);
           sensor.AddObservation(controller.Velocity);
        }

        public override void Heuristic(in ActionBuffers actionsOut)
        {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            float y = Input.GetAxis("Fire1");

            Vector3 direction = new Vector3(x,0,z);
            Vector3 rotation = new Vector3(0,y,0);

            controller.Move(direction);
            controller.Rotate(rotation);
        }

        private void GrantReward(){
            rewardHandler.HandleReward(this,config.reward);
            EndEpisode();
        }
        private void ApplyPunishment(){
            rewardHandler.HandleReward(this,config.punishment / config.maxTrainingSteps);
            EndEpisode();
        }
 

    }
}