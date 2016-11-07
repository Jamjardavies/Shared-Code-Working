using UnityEngine;
using Jamjardavies.Zenject.ViewController;
using Zenject;

public class AttachToTransformFactory<T> : IFactory<Transform, object[], T>
    where T : IViewController
{
    [Inject]
    private DiContainer m_container = null;

    public T Create(Transform parent, params object[] args)
    {
        T controller = m_container.Instantiate<T>(args);

        controller.View.GameObject.transform.SetParent(parent, false);

        return controller;
    }
}

public class AttachViewToTransformFactory<T> : IFactory<Transform, T>
    where T : IView
{
    [Inject]
    private DiContainer m_container = null;

    public T Create(Transform parent)
    {
        T view = m_container.Instantiate<T>();

        view.GameObject.transform.SetParent(parent, false);

        return view;
    }
}
