### USAGE:

Just add the two folders to your Assets folder in your unity project.

In code usage:

```csharp
[Foldout("Movement Parameters", true)]
[SerializeField] private float moveSpeed = 20;
[Foldout("Movement Parameters")]
[SerializeField] private LayerMask groundMask;
[Foldout("Movement Parameters")]
[SerializeField] private float jumpSpeed = 100;
[Foldout("Movement Parameters")]
[SerializeField] private float jumpSustain = 0.0f;
[Foldout("Movement Parameters")]
[SerializeField] private float coyoteTime = 0.1f;
[Foldout("Movement Parameters")]
[Range(0.0f, 1.0f)]
[SerializeField] private float switchDirectionDrag = 0.0f;
```

Or for big groups:

```csharp
[Foldout("Movement Parameters")]
[SerializeField] private float moveSpeed = 20;
[SerializeField] private LayerMask groundMask;
[SerializeField] private float jumpSpeed = 100;
[SerializeField] private float jumpSustain = 0.0f;
[SerializeField] private float coyoteTime = 0.1f;
[Range(0.0f, 1.0f)]
[SerializeField] private float switchDirectionDrag = 0.0f;

[Foldout("Other parameters")]
[SerializeField] private Transform feet;
```
