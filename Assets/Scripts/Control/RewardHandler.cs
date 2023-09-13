using Unity.MLAgents;
namespace Control
{
    public class RewardHandler : IRewardHandler
    {
        public void HandleReward(Agent agent, float amount){
            agent.AddReward(amount);
        }
    
    }
}