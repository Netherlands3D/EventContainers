# Event Containers

This package streamlines the creation of ScriptableObject Event Containers through a straightforward right-click
function within the assets menu. Users have the ability to define EventContainers with precise payload types, enhancing
customization and usability.

Through the utilization of EventContainers in conjunction with Listener MonoBehaviours, seamless communication between
disparate modules is achieved without the necessity for Scene references. This architecture fosters modularity and
mitigates dependencies within the Netherlands3D package scripts, ensuring a robust and maintainable codebase.

Furthermore, this solution empowers non-programmer Unity users to establish connections between modules and user
interfaces autonomously, offering a user-friendly approach to integration without the need for manual coding.

## Installing

This package is provided through OpenUPM, to install it using the CLI you can perform the following:

```bash
$ openupm add eu.netherlands3d.event-containers
```

or, you have to add `https://package.openupm.com` as a scoped registry with, at least, the following scopes:

- `eu.netherlands3d`

## Usage

Each ScriptableObject within the package hosts a trio of UnityEvents tailored to its contained payload type: a 'started'
UnityEvent, carrying the payload type; a 'received' UnityEvent; and a 'cancelled' UnityEvent, both absent of payloads.
These events can be easily invoked or subscribed to through their respective methods.

For reference types stored within EventContainers, an additional feature is available: the 'Send As Copy' option,
conveniently accessible in the Inspector. This option allows users to toggle between sending the payload as a reference
or creating a copy. Should you find a need for a specific payload type not yet included in the package, you're
encouraged to contribute by adding it yourself and initiating a pull request.

We recommend using the Listener scripts in this package to create connections between your own scripts, without creating
dependencies for this package in code.

## Event Invokers

Alongside the EventContainers, this package also provides **EventInvokers**. An EventInvoker is a ScriptableObject that
holds both:

- A reference to an `EventContainer<T>`
- A **preset payload value** of type `T`

When you call `Invoke()` on the Invoker, it automatically fires the target EventContainer with its preset value.  
This makes them useful for cases where you always want to trigger a specific event with a fixed payload, without 
writing custom scripts.

### Available Invokers

The following invokers are included out-of-the-box:

- `BoolEventInvoker`
- `ColorEventInvoker`
- `FloatEventInvoker`
- `IntEventInvoker`
- `LayerMaskEventInvoker`
- `MaterialEventInvoker`
- `StringEventInvoker`
- `StringListEventInvoker`
- `Vector2EventInvoker`
- `Vector2IntEventInvoker`
- `Vector2ListEventInvoker`
- `Vector3EventInvoker`
- `Vector3ListEventInvoker`
- `Vector4EventInvoker`

### Creating an Invoker

You can create an Invoker from the Unity **Assets → Create → EventContainers/EventInvokers/** menu.  
For example, to create a `BoolEventInvoker`:

1. Right-click in your Project window → **Create → EventContainers → EventInvokers → Bool**
2. Assign a target `BoolEvent` container in the Inspector
3. Set the fixed value (true/false)
4. Call `myBoolInvoker.Invoke()` from code, or reference it directly in UnityEvents in the Inspector

### Example Usage

#### 1. Triggering from Code

```csharp
using UnityEngine;

public class ExampleTrigger : MonoBehaviour
{
    [SerializeField] private BoolEventInvoker invoker;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Fires the assigned BoolEvent with the preset value
            invoker.Invoke();
        }
    }
}
```

#### 2. Using in the Inspector

Invokers can also be referenced directly in UnityEvent fields in the Inspector.
For example, a UI Button’s OnClick event can point to BoolEventInvoker.Invoke().
Clicking the button will then raise the associated BoolEvent with the configured payload.

With EventInvokers, designers and non-programmers can wire up specific event triggers without needing custom code, 
while developers can rely on strongly-typed and reusable event channels.