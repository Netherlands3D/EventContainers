using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    /// <summary>
    /// Base invoker that relays a preset Value to an assigned EventContainer<T>.
    /// </summary>
    /// <typeparam name="T">Payload type</typeparam>
    public abstract class EventInvoker<T> : ScriptableObject, IEventInvoker
    {
        [SerializeField] private EventContainer<T> eventContainer;
        [SerializeField] private T value;

        /// <summary>Invoke the assigned channel with the preset Value.</summary>
        public void Invoke()
        {
            if (eventContainer == null)
            {
                Debug.LogWarning($"{name}: No EventContainer assigned.", this);
                return;
            }

            eventContainer.InvokeStarted(value);
        }
    }
}