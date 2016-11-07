using Jamjardavies.Zenject.ViewController;

public class Scene1Controller : SceneController<Scene1View>
{
    public override void Initialise()
    {
        View.Button.onClick.AddListener(OnButtonClicked);
    }

    public override void OnDestroy()
    {
        View.Button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        SceneChange.Execute<Scene2Controller>(TransitionMode.On);
    }
}
