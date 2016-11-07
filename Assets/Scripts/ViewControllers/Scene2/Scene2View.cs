using UnityEngine;
using Jamjardavies.Zenject.ViewController;
using UnityEngine.UI;

public class Scene2View : View
{
    [SerializeField]
    private Button m_button = null;

    public Button Button
    {
        get { return m_button; }
    }
}
