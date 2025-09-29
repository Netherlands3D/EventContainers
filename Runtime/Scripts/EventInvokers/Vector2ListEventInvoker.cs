using System.Collections.Generic;
using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "Vector2ListEventInvoker", menuName = "EventContainers/Invokers/Vector2List",
        order = 0)]
    public sealed class Vector2ListEventInvoker : EventInvoker<List<Vector2>>
    {
    }
}