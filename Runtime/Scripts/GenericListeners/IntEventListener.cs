using Netherlands3D.Events;
using UnityEngine;
using UnityEngine.Events;

public class IntEventListener : MonoBehaviour
{
    [SerializeField]
    private IntEvent onEvent;

    [SerializeField]
    private UnityEvent<int> trigger;

    void Awake()
    {
        if (onEvent)
        {
            onEvent.AddListenerStarted(Invoke);
        }
    }

	public void Invoke(int value)
	{
        trigger.Invoke(value);
    }
}
