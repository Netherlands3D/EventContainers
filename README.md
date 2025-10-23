> Archived – Now maintained in the Netherlands3D Main Repository; OpenUPM updates suspended.

# Event Containers

This package streamlines the creation of ScriptableObject Event Containers through a straightforward right-click function within the assets menu. Users have the ability to define EventContainers with precise payload types, enhancing customization and usability.

Through the utilization of EventContainers in conjunction with Listener MonoBehaviours, seamless communication between disparate modules is achieved without the necessity for Scene references. This architecture fosters modularity and mitigates dependencies within the Netherlands3D package scripts, ensuring a robust and maintainable codebase.

Furthermore, this solution empowers non-programmer Unity users to establish connections between modules and user interfaces autonomously, offering a user-friendly approach to integration without the need for manual coding.

## Installing

This package is provided through OpenUPM, to install it using the CLI you can perform the following:

```bash
$ openupm add eu.netherlands3d.event-containers
```

or, you have to add `https://package.openupm.com` as a scoped registry with, at least, the following scopes:

- `eu.netherlands3d`

## Usage

Each ScriptableObject within the package hosts a trio of UnityEvents tailored to its contained payload type: a 'started' UnityEvent, carrying the payload type; a 'received' UnityEvent; and a 'cancelled' UnityEvent, both absent of payloads. These events can be easily invoked or subscribed to through their respective methods.

For reference types stored within EventContainers, an additional feature is available: the 'Send As Copy' option, conveniently accessible in the Inspector. This option allows users to toggle between sending the payload as a reference or creating a copy. Should you find a need for a specific payload type not yet included in the package, you're encouraged to contribute by adding it yourself and initiating a pull request.

We recommend using the Listener scripts in this package to create connections between your own scripts, without creating dependencies for this package in code.

# Repository Archived

This repository has been **archived** and is no longer maintained independently.

The contents of this package have been merged into the  
**[Netherlands3D Main Repository](https://github.com/Netherlands3D/twin)**  
into the `Packages` folder.

## Current Location

The latest version and future updates of this package will be maintained inside the Netherlands3D main repository as part of an effort to simplify and unify our development workflow.

## Why was this repository archived?

To streamline development and reduce overhead, the Netherlands3D packages are being integrated into the main repository.  
This approach allows for better coordination between packages and features, while we continue to evaluate whether a full monorepo setup (including versioning) is desirable in the future.

## Where to contribute

Please open issues and pull requests in the [Netherlands3D Main Repository](https://github.com/Netherlands3D/twin).

## Publication status

Updates to this package on **OpenUPM** are **suspended until further notice**.  
Future releases will be managed from the main repository once the new development flow has been finalized.

## Historical reference

This repository remains available in read-only mode as a historical record of its standalone development.

