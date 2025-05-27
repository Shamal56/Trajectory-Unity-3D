# 🧪 3D Trajectory Simulation with Restitution

This Unity project simulates a bouncing sphere using vector mathematics without relying on Unity’s built-in physics engine. It demonstrates projectile motion under gravity with restitution.

## 🎯 Objective

Simulate a sphere launched with an initial velocity that bounces on the ground and gradually loses height based on a coefficient of restitution.

## ✨ Features

- Custom launch velocity editable via the Inspector
- Time-stepped motion using `Time.deltaTime`
- Gravity vector: `(0, -9.81, 0)`
- Adjustable coefficient of restitution (`e`)
- Bounces stop when vertical motion is negligible (e.g., `v_after / v_before < 0.01`)

## 🛠️ Tools Used

- Unity (Version 2022 or later)
- C# Scripting

## 📂 How to Use

1. Open the project in Unity.
2. Select the sphere object.
3. Adjust `LaunchVelocity` and `Restitution` in the Inspector.
4. Play the scene to see the trajectory and bounce simulation.

---
