![GitHub language count](https://img.shields.io/github/languages/count/ClaudiaAF/VirtualPetAxolotl?colorB=317777)
![GitHub repo size](https://img.shields.io/github/repo-size/ClaudiaAF/VirtualPetAxolotl?colorB=317777)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/ClaudiaAF/VirtualPetAxolotl?colorB=317777)
![GitHub watchers](https://img.shields.io/github/watchers/ClaudiaAF/VirtualPetAxolotl?colorB=317777)



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/claudiaAF/Snappit-AF">
    <img src="https://user-images.githubusercontent.com/64257497/141085383-85119cbd-fbd4-49c6-8ff0-e2c7072d7c9b.png" width="195" alt="logo" >
  </a>

  <p align="center">
    Virtual Pet Application
    <br />
    <a href="https://github.com/claudiaAF/Snappit-AN"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/claudiaAF/Snappit-AN">View Demo</a>
    ·
    <a href="https://github.com/claudiaAF/Snappit-AN/issues">Report Bug</a>
    ·
    <a href="https://github.com/claudiaAF/Snappit-AN/issues">Request Feature</a>
  </p>
</p>


<!-- TABLE OF CONTENTS -->
<details open="open">
<summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li><a href="#getting-started">Getting Started</a>
    <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
      <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#features-and-functionality">Features and Functionality</a>
    </li>
    <li><a href="#concept-process">Concept Process</a>
    <ul>
        <li><a href="#ideation">Ideation</a></li>
      <li><a href="#user-flow">User Flow</a></li>
      <li><a href="#initial-designs">Initial Designs</a></li>
      </ul>
    </li>
    <li><a href="#development-process">Development Process</a>
    <ul>
      <li><a href="#implementation">Implementation</a>
        <ul>
        <li><a href="#resources-used">Resources Used</a></li>
        <li><a href="#highlights">Highlights</a></li>
        <li><a href="#challenges">Challenges</a></li>
        </ul>
      </li>
      <li><a href="#reviews-from-testing">Reviews from Testing</a>
         <ul>
        <li><a href="#unit-tests">Unit Tests</a></li>
        </ul>
        </li>
      <li><a href="#future-implementation">Future Implementation</a></li>
      </ul>
    </li>
    <li>
      <a href="#final-outcome">Final Outcome</a>
      <ul>
        <li><a href="#mockups">Mockups</a></li>
        <li><a href="#video-demonstration">Video Demonstration</a></li>
      </ul>
    </li>    
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>


## About The Project

Axolotl is a virtual pet app which allows the user to own their very own virtual axolotl. The user needs to take care of their pet by tending to certain needs hourly, or daily. Consider this some sort of a test-tun for in case you were thinking of casually getting an Axolotl as a pet.

### Built With
<img src="https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png" width="5%" height="5%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png" width="5%" height="5%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://static.wikia.nocookie.net/logopedia/images/6/62/Brand_Visual_Studio_Win_2019.svg/revision/latest/scale-to-width-down/340?cb=20191019024151" width="5%" height="5%">

## Getting Started

### Prerequisites
* Visual Studio
* Xamarin Forms v4.8.0 and later.
* Xamarin.CommunityToolkit NuGet Package installed.

### Installation

1. Clone the repo
```sh
git clone https://github.com/ClaudiaAF/VirtualPetAxolotl.git
```
2. Open the project

Use `Open Workspace` in Visual Studio.

## Features and Functionality

### Features

Features in the app include interactions such as:

<img width="1920" alt="Slide 2" src="https://user-images.githubusercontent.com/64257497/141087710-f621c4c3-fc9c-4387-b1da-d58d59e71d09.png">

- Giving your axolotl a name

<img width="1920" alt="Slide 3" src="https://user-images.githubusercontent.com/64257497/141087839-b5616dc7-1d71-40ef-b9e8-3f4e4a35eee0.png">

- Feeding your axolotl on a daily basis
- Cleaning your axolotls tank
- Replacing the fitler for the water to stay fresh
- Changing reactions according to whether or not your axolotl's needs are being met
- An extra two options of giving more attention to your axolotl or keeping the tank water cool allows the user to form a "level-up" bond with your pet.

<img width="1920" alt="Slide 4" src="https://user-images.githubusercontent.com/64257497/141087951-e6e01f3a-024f-4c6f-99d2-71ebdcea0692.png">

* Settings page to assist you whenever you would like to either read up about the app, or restart your pet.

### Functions

* The input name for the axolotl is saved in `local storage` and displayed on the dashboard.
* The Axolotl enters 1 of 4 different `states` which are dependent on the pets overall HP and whether the needs are being tended to.
* The level updates `dynamically` according to the amount of XP. The XP is updated by attending to needs.
* The general HP `value decrease` happens every second. The needs each have their own `states` too, when a need reaches its lowest state the overall HP decrease value speed increases.
* `Swipe`,`tap`, `double-tap`, `drag & drop` and `long press` animations were implemented with the help of `Xamarin.CommunityToolkit` to differentiate each interaction.

## Concept Process
### Ideation
![Group 5368](https://user-images.githubusercontent.com/64257497/141088894-f0fb446a-9044-403b-8603-8485bc222ee2.png)

### Initial Designs 
![Group 75](https://user-images.githubusercontent.com/64257497/141090045-0c0c7198-5c4c-4a5c-a7bb-905fe5a53b0f.png)

### User Flow
![Group 53e63](https://user-images.githubusercontent.com/64257497/141090442-e18efd0d-5af7-43eb-b097-b452451f65a8.png)

## Development Process
### Implementation
#### Resources Used
All illustrations created by **me** using `Figma` and `Adobe Illustrator`.

#### Highlights
* Making use of gamification into a mobile application using C#.
* Being able to learn about game logic and include interactive elements in the app.
* Creating my own creature for the pet allowed the process to be more personalized.

#### Challenges
* Trying to figure out the game logic for the app proved to be quite challenging.
* NUnit testing and the limitations thereof.
* At times, the device emulator would struggle. Although this was quickly solved by deploying the app to my phone instead.

### Reviews From Testing
#### Unit Tests
The following is an example of a unit test I ran in my project:

```sh
public void GetLevelFromXpTest()
        {
           
            int Xp = 1000;
            int expectedLevel = 1;


            var result = Levels.GetLevelFromXp(Xp);

           
            Assert.AreEqual(expectedLevel, result);
        }
```


</p>

### Future Implementation
* Add smoother animations for the changing states
* The option to change the pets name without having to reset everything else
* More interactive games for the user to take part in.

## Final Outcome
### Mockups
![dark-iphone-mockup](https://user-images.githubusercontent.com/64257497/141097087-65c49b9d-ce46-401e-897d-0734b0a4c3f7.png)


### Video Demonstration
[Watch the App walkthrough here!](https://drive.google.com/file/d/13VsCUFBh03-i8rR3rOD_RawSZai0w5YO/view?usp=sharing)

## Roadmap

See the [open issues](https://github.com/github_username/repo_name/issues) for a list of proposed features (and known issues).


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AwesomeFeature`)
3. Commit your Changes (`git commit -m 'Add some AwesomeFeature'`)
4. Push to the Branch (`git push origin feature/AwesomeFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

* **Claudia Ferreira** - 180181@virtualwindow.co.za
* **Project Link** - https://github.com/ClaudiaAF/VirtualPetAxolotl.git



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* My lecturer Christof Enslin
* C# Visual Studio <a href="https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2022">Documentation</a>
* <a href="https://docs.microsoft.com/en-us/xamarin/community-toolkit/">Xamarin Community Toolkit</a>
* [Plagiarism Form](term1.png)
