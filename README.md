# Cruuzie 🚗📦

A vibrant, top-down 2D driving and delivery game built with **Unity 6** and the **Universal Render Pipeline (URP)**.

---

## 🎮 Overview

**Cruuzie** puts you behind the wheel as a delivery driver navigating neighborhood roads, sharp corners, and obstacles. Pick up packages, watch your car change color to signify package pickup, hit nitro boosts, and deliver packages to customers as fast as you can!

---

## ✨ Features

- **Responsive 2D Vehicle Physics**: Realistic steering, turning, and acceleration mechanics.
- **Package Delivery System**:
  - Pick up packages scattered across the map.
  - Car dynamically alters its color indicator when carrying a package.
  - Safely drop packages off at customer delivery points.
- **Nitro Boosts & Obstacles**:
  - Hit nitro triggers for a high-speed surge.
  - Avoid bumping into houses, trees, and rocks that slow you down.
- **Dynamic Smooth Follow Camera**: Orthographic camera tracking the driver with late-update positioning.
- **Modern 2D URP Visuals**: Powered by Unity's Universal Render Pipeline 2D.

---

## 🕹️ Controls

| Action | Primary Key | Secondary Key |
| :--- | :--- | :--- |
| **Accelerate / Reverse** | `W` / `S` | `Up Arrow` / `Down Arrow` |
| **Steer Left / Right** | `A` / `D` | `Left Arrow` / `Right Arrow` |

---

## 🛠️ Tech Stack & Requirements

- **Engine**: [Unity 6 (6000.3.23f1 or compatible)](https://unity.com/)
- **Render Pipeline**: Universal Render Pipeline (URP) 2D
- **Language**: C# (.NET Standard)
- **Editor Version Control**: Git LFS compatible structure

---

## 🚀 Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/ahmadxhashmi/cruuzie.git
```

### 2. Open with Unity Hub
1. Open **Unity Hub**.
2. Click **Add** -> **Add project from disk**.
3. Select the cloned `cruuzie` project folder.
4. Open the project with **Unity 6 (6000.3.x)**.

### 3. Play the Game
1. In the Project window, navigate to `Assets/Scenes/SampleScene.unity`.
2. Double-click to open the scene.
3. Click the **Play** button at the top of the Unity Editor.

---

## 📁 Project Structure

```plaintext
Cruuzie/
├── Assets/
│   ├── assets/              # Sprites (Cars, Roads, Trees, Houses, etc.) & Animations
│   ├── Scenes/              # Game scenes (SampleScene.unity)
│   ├── Settings/            # URP & Input Action configs
│   ├── Delivery.cs          # Package pickup & delivery logic
│   ├── Driver.cs            # Car steering, acceleration & nitro boost mechanics
│   └── FollowCamera.cs      # Smooth camera tracking
├── Packages/                # Unity Package Manager manifest & lock
├── ProjectSettings/         # Unity engine & project configuration
└── .gitignore               # Standard Unity gitignore (excludes Library/, Temp/, etc.)
```

---

## 📄 License

This project is licensed under the [MIT License](LICENSE) (or standard open-source terms). Feel free to customize and expand it!
