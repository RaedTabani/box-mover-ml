using Unity.MLAgents;
namespace Control{
    public interface IRewardHandler
    {
        public void HandleReward(Agent agent, float amount);
    }
}