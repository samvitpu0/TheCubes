# 🧊 TheCubes – A Hyper-Casual Fidget Game in 3D

**TheCubes** is a minimal, addictive 3D fidgeting game developed in Unity. The player shreds a massive cube by swiping over it, cutting it down into smaller cubes for a satisfying and relaxing experience.

Swipe. Shred. Repeat.

---

## 🎮 Gameplay Summary

- 🖐️ Swipe your finger or mouse across the screen to slice through a massive 3D cube.
- 🧩 The cube is made up of smaller cubes — each swipe cuts a few away.
- 🧨 Cutting a cube spawns satisfying destruction particles.
- 🌪️ Use two fingers to rotate the cube for better angles.
- 💰 Earn rewards and coins for completing cube levels.

---

## 🛠️ Core Features

- ✂️ **Interactive Cutting** – Destroy cubes on swipe using a finger trail
- 🌌 **3D Cube Grid** – Procedurally generated volumetric grid of cubes
- 🎆 **Destruction FX** – Particle effect for each cut cube
- 🌀 **Touch-Based Rotation** – Use two fingers to rotate the cube grid
- 💡 **Level Progression System** – Regenerates a new cube when all pieces are destroyed

---

## 📲 Controls

👉 Swipe on Cube	Cuts into the grid and destroys cubes
---
✌️ Two-finger drag	Rotates the whole cube for better slicing angles
---
💨 Finger Trail	Visual indicator of your cut path
---
💥 Cube Destroy FX	Satisfying explosion when a cube is destroyed

---

## 🎯 How to Play

Open the game on mobile or desktop (touch or mouse supported).

- Swipe through the cube to shred it.

- Use two fingers to rotate the cube and reach hidden faces.

- Destroy all cubes to complete the level.

- A new cube is generated, and coins are rewarded.

---

## 🧪 Developer Notes

- TrailScript.cs: Uses ScreenToWorldPoint with smoothing to follow the finger.

- MainController.cs: Manages game state, rotation, level progress.

- BoxDestroy.cs: Checks for touch eligibility and instantiates destruction particles.

- BoxGridGenerator.cs: Spawns a full 3D grid of cubes under a central parent.

---

## 📦 Installation & Run

### Requirements

Unity 2020.3 LTS or higher

Supports Android, iOS, and PC builds

### Steps

- Open the project in Unity.

- Ensure boxInstance, fingerTrail, grid etc. are correctly assigned in the Inspector.

- Press Play in the Unity Editor or build to your target device.