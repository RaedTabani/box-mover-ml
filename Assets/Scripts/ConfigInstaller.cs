using System.Threading;
using Config;
using Zenject;

public class ConfigInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IConfig>().To<TrainingConfig>().AsSingle();
        
    }
}