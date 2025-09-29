using UnityEngine;

namespace Netherlands3D.Events
{
    public class StringEventTrigger : MonoBehaviour
    {
        public StringEvent stringEvent;

        public void call(string value)
        {
            stringEvent.InvokeStarted(value);
        }
    }
}
