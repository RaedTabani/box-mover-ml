namespace Config{
    public class TrainingConfig : IConfig
    {
        //Speed
        public float agentRunSpeed => _agentRunSpeed;
        //Rotation
        public float agentRotationSpeed => _agentRotationSpeed;
        //Training
        public float spawnZoneMultiplier => _spawnZoneMultiplier;
        public int maxTrainingSteps => _maxTrainingSteps;

        //Reward
        public float reward => _reward;
        public float punishment =>_punishment;
        public float existantial =>_existantial;

        private float _agentRunSpeed = 80;
        private float _agentRotationSpeed = 50;
        private float _spawnZoneMultiplier = .9f;
        private int _maxTrainingSteps = 25000;

        private float _reward = 1;
        private float _punishment = -1;
        private float _existantial = -1;
    }
}