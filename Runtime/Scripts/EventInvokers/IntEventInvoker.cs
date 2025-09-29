using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "IntEventInvoker", menuName = "EventContainers/Invokers/Int", order = 0)]
    public sealed class IntEventInvoker : EventInvoker<int>
    {
    }
}