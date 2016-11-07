using Jamjardavies.Zenject.ViewController;
using Zenject;

public class AppManager : Controller
{
    [Inject]
    private SceneChangeCommand m_sceneChange = null;

    #region Signals
    
    #endregion

    public override void Initialise()
    {
        m_sceneChange.Execute<Scene1Controller>(TransitionMode.On);

        AddListeners();
    }

    public override void OnDestroy()
    {
        RemoveListeners();
    }

    private void AddListeners()
    {
        
    }

    private void RemoveListeners()
    {
        
    }
}