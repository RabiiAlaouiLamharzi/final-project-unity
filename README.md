# Science Fair Unity Project (Unity, C#, Sweet Home 3D)

### Introduction :

**Welcome to Our Science Fair Unity Project!**

Our Science Fair project in Unity showcases three main exhibits: the Volcano, the Lamp, and the Magnet. Each exhibit is displayed on a table in a virtual room designed in Sweet Home 3D and exported to Unity. Visitors can navigate the environment, interact with each exhibit, reset them, and launch scripts associated with some exhibits. Below are descriptions of each exhibit and the interactive features of our environment.

### Team Members:

- Rabii Lamharzi Alaoui (rabiialaoui10@gmail.com)
- Baptiste Samoyault (bsamoyault@gmail.com)

### Exhibits:

**Volcano:**
This exhibit features a background mountain made of black-textured material with particle effects styled to resemble flowing volcanic lava. When activated, the exhibit produces a volcanic eruption sound and visual effects to simulate an active volcano experience.

**Magnet:**
The magnet exhibit is created using lots of primitive GameObjects like cubes. Several balls are placed nearby, with some being metallic and others plastic. There’s also a golden ball and a fake gold ball. Only the metallic and fake gold balls are attracted by the magnet, while the gold and plastic balls are unaffected.

**Lamp:**
This exhibit consists of three parts:
- **The Lamp (Bulb):** The bulb toggles on and off.
- **Base of the Charger:** The core of the mechanism. When the correct component is placed on it, the lamp illuminates.
- **The Charger:** Automatically connects to the base when close enough, enabling the lamp to light up.

**Exit and Reset Events**:
- **Exit Event:** Allows a natural exit from the application.
- **Reset Button:** This feature resets the scene to its original setup.

### Environment Features and Interactive Elements:

- **Virtual Navigation:** The player moves fluidly around the environment using a “gliding/flying” metaphor, controlled by the VR controller’s touchpad.
- **Object Manipulation:** Objects can be manipulated using ray-casting at a distance or with a virtual hand for close interactions.
- **Activation / Deactivation of Objects:** Exhibits and objects can be activated in VR using a reset cube. In standard mode, activation/deactivation is managed through buttons (mouse clicks).
- **Canvas and 3D TextMeshPro:** Text elements give instructions on how to interact with each exhibit.
- **Physics Integration:** Physics controls how objects interact, such as the magnet attracting specific balls.
- **Lighting Control:** For example, the lamp turns on or off when the charger is placed correctly on its base.
- **3D Audio:** 3D Sound effects are integrated, like the eruption sound that plays when the volcano exhibit is activated.
- **Countdown Timer:** A timer is added to the scene, as part of the immersive experience.
- **Object Scripting and Logic:** Each exhibit has specific behaviors, programmed to enhance interactivity and realism.

### Challenges Faced:

- **Limited VR Setup Time:** We faced issues setting up the VR headset, and troubleshooting was difficult even for mentors, limiting our interaction testing in VR. However, all interactions are accessible in standard game mode using a mouse click.
- **Unity File Sharing Issues:** Due to the large file sizes and operating system conflicts (Windows and Mac), file sharing and updates posed challenges.
- **Button Interaction in VR:** Ray-casting failed to activate buttons, so we added cubes with the same function as a workaround. Buttons work with a mouse click in normal game mode.
- **Learning Curve with Unity:** Since both of us are beginners,it was hard for us to balance learning and practicing new skills in Unity.

### Setting Up the Project:

To set up the Unity project on your laptop:
1. **Clone the Repository:** Use `git clone https://github.com/RabiiAlaouiLamharzi/final-project-unity` to download the project locally.
2. **Fetch the Latest Updates:** Run `git fetch` and `git pull` to sync with the latest version.
3. **Open in Unity:** Open Unity, select "Open Project," and navigate to the project folder.
4. **Configure VR Settings:** For VR, ensure your headset is connected, then adjust the project settings in Unity for VR compatibility.
5. **Play the Project:** Click “Build and Run” to test the exhibits using the VR headset (or click "RUN" to test with the standard mouse/keyboard controls).
