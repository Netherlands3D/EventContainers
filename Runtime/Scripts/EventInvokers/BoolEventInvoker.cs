using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "BoolEventInvoker", menuName = "EventContainers/Invokers/Bool", order = 0)]
    public sealed class BoolEventInvoker : EventInvoker<bool>
    {
    }
}