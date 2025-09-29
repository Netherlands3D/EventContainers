using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "LayerMaskEventInvoker", menuName = "EventContainers/Invokers/LayerMask", order = 0)]
    public sealed class LayerMaskEventInvoker : EventInvoker<LayerMask>
    {
    }
}