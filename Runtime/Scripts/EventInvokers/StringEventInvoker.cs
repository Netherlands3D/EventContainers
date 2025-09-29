using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "StringEventInvoker", menuName = "EventContainers/Invokers/String", order = 0)]
    public sealed class StringEventInvoker : EventInvoker<string>
    {
    }
}