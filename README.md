# MicroFPS

MicroFPS is a first-person shooter project built using the **Unity FPS Microgame** template. This project features a **custom-designed level**, showcasing unique level design and gameplay pacing while leveraging the robust core mechanics provided by the template.

## Key Features

- **Custom Level Design**: A unique environment designed to provide a tailored gameplay experience.
- **Core FPS Mechanics**: Fluid movement, jumping, and shooting mechanics.
- **AI Enemies**: Intelligent turret and mobile enemy behaviors.
- **Modular Systems**: Well-organized code structure for gameplay, AI, and UI.
- **Pickups & Objectives**: Integrated health, ammo, and jetpack power-ups with objective-based progression.

## Tech Stack

- **Engine**: Unity 2022.3.62f3
- **Language**: C#
- **Rendering**: Built-in Render Pipeline (standard for FPS Microgame)

## Project Structure

The project follows a modular organization within `Assets/FPS/Scripts`:

- **AI**: Enemy controllers, detection modules, and navigation logic.
- **Game**: Core managers (GameManager, ObjectiveManager), constants, and utility classes.
- **Gameplay**: Player controller, weapon systems, projectiles, and interactive objects (pickups, doors).
- **UI**: Menus, HUD elements, and feedback systems.

## Getting Started

1.  **Clone the Repository**:
    ```bash
    git clone [repository-url]
    ```
2.  **Open in Unity**:
    - Launch Unity Hub.
    - Click **Add** and select the `MicroFPS` folder.
    - Ensure you are using **Unity 2022.3.62f3** or a compatible version.
3.  **Play the Game**:
    - Open the main scene located in `Assets/FPS/Scenes/`.
    - Press the **Play** button in the Unity Editor.

## Controls

| Action | Control |
| :--- | :--- |
| **Move** | `W`, `A`, `S`, `D` |
| **Look** | `Mouse` |
| **Jump** | `Space` |
| **Shoot** | `Left Click` |
| **Aim** | `Right Click` |
| **Reload** | `R` |
| **Switch Weapon** | `Scroll Wheel` or `1-9` |
| **Jetpack** | `Space` (Hold while in air) |
| **Pause** | `Escape` |

## Credits

Based on the [Unity FPS Microgame](https://learn.unity.com/project/fps-microgame) template.
