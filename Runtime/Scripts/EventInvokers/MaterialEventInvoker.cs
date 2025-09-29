using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "MaterialEventInvoker", menuName = "EventContainers/Invokers/Material", order = 0)]
    public sealed class MaterialEventInvoker : EventInvoker<Material>
    {
    }
}