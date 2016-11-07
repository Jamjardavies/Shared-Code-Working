using Jamjardavies.Zenject.ViewController;

public class Scene2Controller : SceneController<Scene2View>
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
        SceneChange.Execute<Scene1Controller>(TransitionMode.On);
    }
}
