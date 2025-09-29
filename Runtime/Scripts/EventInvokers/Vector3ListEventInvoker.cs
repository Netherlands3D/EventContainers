using System.Collections.Generic;
using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "Vector3ListEventInvoker", menuName = "EventContainers/Invokers/Vector3List",
        order = 0)]
    public sealed class Vector3ListEventInvoker : EventInvoker<List<Vector3>>
    {
    }
}