using System.Collections.Generic;
using UnityEngine;

namespace Netherlands3D.Events.EventInvokers
{
    [CreateAssetMenu(fileName = "StringListEventInvoker", menuName = "EventContainers/Invokers/StringList", order = 0)]
    public sealed class StringListEventInvoker : EventInvoker<List<string>>
    {
    }
}