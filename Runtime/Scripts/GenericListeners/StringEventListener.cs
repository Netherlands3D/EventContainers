using Netherlands3D.Events;
using UnityEngine;
using UnityEngine.Events;

public class StringEventListener : MonoBehaviour
{
    [SerializeField]
    private StringEvent onEvent;

    [SerializeField]
    private UnityEvent<string> trigger;

    void Awake()
    {
        if (onEvent)
        {
            onEvent.AddListenerStarted(Invoke);
        }
    }

	public void Invoke(string value)
	{
        trigger.Invoke(value);
    }
}
