using UnityEngine;

[System.Serializable]
public class GameInstallerModel
{
    [Header("Scene Items")]
    [SerializeField]
    private Canvas m_canvas = null;

    [Header("Views")]
    [SerializeField]
    private TransitionView m_transitionView = null;

    [SerializeField]
    private Scene1View m_scene1 = null;

    [SerializeField]
    private Scene2View m_scene2 = null;

    public Canvas Canvas
    {
        get { return m_canvas; }
    }

    public TransitionView TransitionView
    {
        get { return m_transitionView; }
    }

    public Scene1View Scene1
    {
        get { return m_scene1; }
    }

    public Scene2View Scene2
    {
        get { return m_scene2; }
    }
}