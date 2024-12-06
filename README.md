# C# Reference Type Modification Bug

This example showcases a common issue in C# related to reference types.  When you assign one object reference to another (instance2 = instance1), both variables point to the same object in memory.  Modifying the object through either reference affects the object's state as seen by both references. This behavior might be unexpected if you're expecting independent copies.

**Files:**
- `bug.cs`: Demonstrates the problematic code.
- `bugSolution.cs`: Provides a solution using cloning or creating a new instance to avoid unintended modifications.