# Flappy Bird Unity Project

A classic Flappy Bird clone built with Unity 2020.3.33f1, featuring smooth bird physics, obstacle avoidance gameplay, and retro-style graphics.

## 🎮 Demo Video

[![Flappy Bird Unity Gameplay](https://img.youtube.com/vi/IhoNSSLzVnE/0.jpg)](https://www.youtube.com/watch?v=IhoNSSLzVnE&list=PLKz7QOwPaa35za3Q2WB6QacrwIFppwwSh&index=2)

*Click the image above to watch the gameplay demo on YouTube*

## 🚀 Features

- **Physics-Based Flight**: Realistic bird movement with gravity and flap mechanics
- **Dynamic Rotation**: Bird rotates smoothly between ascent and descent
- **Collision Detection**: Precise collision system for game-ending obstacles
- **Point Scoring**: Score points by flying through pipe gaps
- **Audio System**: Sound effects for flapping, scoring, and game over
- **Animation System**: Smooth bird flap animations
- **Background Scrolling**: Infinite scrolling background for immersive gameplay
- **Game Reset**: Press 'R' to restart the game instantly

## 🎯 How to Play

- **Space Bar**: Make the bird flap and fly upward
- **R Key**: Restart the game after game over
- **Objective**: Navigate through the gaps between pipes without hitting them or the ground
- **Scoring**: Each pipe you successfully pass through increases your score

## 🛠️ Technical Details

### Unity Version
- **Unity Editor**: 2020.3.33f1

### Core Scripts

- **`Main.cs`**: Game manager handling scene reloading and global game state
- **`Bird.cs`**: Player controller with physics-based movement and input handling
- **`Environment.cs`**: Background and obstacle management
- **`Pipe.cs`**: Individual pipe behavior and movement
- **`PointCounter.cs`**: Score tracking and display
- **`Audio.cs`**: Sound effects management
- **`GameOver.cs`**: Game over screen handling
- **`Background.cs`**: Infinite scrolling background system
- **`VisibilityObserver.cs`**: Performance optimization for off-screen objects

### Key Components

- **Physics**: Unity's Rigidbody2D for realistic bird movement
- **Animation**: Animator Controller for bird flapping animations
- **Audio**: AudioSource components for immersive sound effects
- **UI**: TextMeshPro for clean score display

## 📁 Project Structure

```
Assets/
├── Animations/          # Bird animation controller and clips
├── Audio/              # Sound effects (flap, score, game over)
├── Scenes/             # Main game scene
├── Scripts/            # All C# gameplay scripts
├── Sprites/            # Game textures and sprite assets
└── TextMesh Pro/       # UI text rendering assets
```

## 🎨 Assets

- **Bird Sprites**: Animated flapping bird character
- **Environment**: Background, ground, and pipe textures
- **UI Elements**: Game over screen graphics
- **Audio Files**: 
  - Flap sound effect
  - Point scoring sound
  - Game over sound

## 🚀 Getting Started

1. **Clone the Repository**
   ```bash
   git clone https://github.com/kyanbarker/FlappyBirdUnityProject.git
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open" and select the project folder
   - Ensure you're using Unity 2020.3.33f1 or compatible version

3. **Play the Game**
   - Open `Assets/Scenes/SampleScene.unity`
   - Click the Play button in the Unity Editor
   - Use Space Bar to control the bird

4. **Build the Game**
   - Go to File > Build Settings
   - Select your target platform
   - Click "Build" to create a standalone executable

## 🎮 Controls

| Key | Action |
|-----|--------|
| Space | Flap wings / Jump |
| R | Restart game |

## 📊 Game Mechanics

- **Gravity**: Constant downward force on the bird
- **Flap Force**: Upward velocity applied when space is pressed
- **Rotation**: Bird tilts up during ascent, down during descent
- **Collision**: Game ends when bird hits pipes or ground
- **Scoring**: Points awarded for each pipe successfully navigated

## 🔧 Development Notes

This project demonstrates several Unity development concepts:
- Component-based architecture
- Physics simulation with Rigidbody2D
- Animation state machines
- Audio management
- UI systems with TextMeshPro
- Scene management and game state handling
- Performance optimization techniques

## 📝 License

This project is for educational and demonstration purposes. Flappy Bird is originally created by Dong Nguyen.

---

*Built with ❤️ in Unity*