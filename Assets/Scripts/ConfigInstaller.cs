using System.Threading;
using Config;
using Control;
using Zenject;

public class ConfigInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IConfig>().To<TrainingConfig>().AsSingle();
        Container.Bind<IRewardHandler>().To<RewardHandler>().AsSingle().NonLazy();
    }
}