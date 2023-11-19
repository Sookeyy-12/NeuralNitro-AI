# Neural Nitro: Racing Car Learning Environment

## Overview

Welcome to Neural Nitro, a Unity-based learning environment designed for training and evaluating reinforcement learning agents in the exciting domain of racing car simulations. Whether you're a student, researcher, or developer, Neural Nitro provides a dynamic platform to explore and experiment with state-of-the-art reinforcement learning algorithms for autonomous driving.

## Features

- **Racing Simulation:** Neural Nitro offers a realistic racing environment, complete with diverse tracks, challenging curves, and varying road conditions to provide a comprehensive learning experience.

- **Customizable Environments:** Modify the Learning environment by creating new tracks, changing physics settings, etc. Experiment with different scenarios to test the adaptability of your reinforcement learning models.

- **Reinforcement Learning Integration:** The environment is designed to seamlessly integrate with Unity's ML-Agetns toolkit, allowing you to easily train and evaluate your AI agents using algorithms like Proximal Policy Optimization (PPO), and more.

## Getting Started

Follow these steps to get started with Neural Nitro:

1. **Clone the Repository:**
   ```
   git clone https://github.com/Sookeyy-12/NeuralNitro-AI.git
   ```

2. **Install Dependencies:**
   Ensure that you have Unity installed on your machine. Open the project in Unity and install any additional packages or dependencies as specified in the documentation.
   **NOTE**: You will get an error message when you open the project in Unity. to fix this error, navigate to `Packages\manifest.json` and `Packages\packages-lock.json` and change the path of `com.unity.ml-agents` to where you have cloned the ml-agents repository.

4. **Train and Evaluate:**
   Train your reinforcement learning agents in the Neural Nitro environment and evaluate their performance. Use the visualization tools to analyze the results and iterate on your models.
   You can also load pretraind models in `Assets\Models`.

## Contribution Guidelines

We welcome contributions to Neural Nitro! If you have ideas for improvements, new features, or bug fixes.

## License

Neural Nitro is licensed under the [MIT License](LICENSE.md). Feel free to use, modify, and distribute this learning environment for your educational and research purposes.

Happy racing and happy learning with Neural Nitro! 🏎️🚀