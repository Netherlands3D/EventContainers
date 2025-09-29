using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "ColorEventInvoker", menuName = "EventContainers/Invokers/Color", order = 0)]
    public sealed class ColorEventInvoker : EventInvoker<Color>
    {
    }
}