using UnityEngine;
using Jamjardavies.Zenject.ViewController;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    [SerializeField]
    private GameInstallerModel m_model = null;

    public override void InstallBindings()
    {
        BindManagers();
        BindViewControllers();
        BindInstances();
        BindFactories();
        BindObjects();
        BindSignals();
    }

    private void BindManagers()
    {
        // First the Scene Manager.
        Container.BindController<SceneManager>();
        Container.BindCommand<SceneChangeCommand, System.Type, TransitionMode, object[]>()
            .To<SceneManager>(m => m.ChangeScene)
            .AsSingle();

        Container.BindCommand<SceneBackCommand>().To<SceneManager>(m => m.GoBack).AsSingle();

        // Now the transition.
        Container.BindViewController<TransitionView, TransitionManager>(m_model.TransitionView);

        // Now the App Manager.
        Container.BindController<AppManager>();
    }

    private void BindViewControllers()
    {
        Container.BindTransientViewController<Scene1View, Scene1Controller>(m_model.Scene1);
        Container.BindTransientViewController<Scene2View, Scene2Controller>(m_model.Scene2);
    }

    private void BindInstances()
    {
        Container.Bind<Canvas>().FromInstance(m_model.Canvas);
    }

    private void BindFactories()
    {
        Container.Bind<Controller.TransientFactory>().ToSelf().AsSingle();
    }

    private void BindObjects()
    {

    }

    private void BindSignals()
    {

    }
}