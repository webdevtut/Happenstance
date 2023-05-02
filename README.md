<a name="readme-top"></a>

[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/webdevtut/MingleWebsite">
    <img src="client/src/assets/logo.png" alt="Logo" width="200" height="50">
  </a>

  <h3 align="center">Happenstance (Mingle 2.0)</h3>

  <p align="center">
    Wholesome Dating and Chat Application
    <br />
    <a href="https://github.com/webdevtut/MingleWebsite/blob/master/README.md"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://happenstance.up.railway.app/">View Demo</a>
    ·
    <a href="https://github.com/webdevtut/MingleWebsite/issues">Report Bug</a>
    ·
    <a href="https://github.com/webdevtut/MingleWebsite/issues">Request Feature</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->

## About The Project

[![Happenstance Screen Shot][product-screenshot]](https://happenstance.up.railway.app/)

Basic Dating application created from scratch for self-learning and showcase purpose.

Features :

- Sacalable image upload functionality (Cloudinary)
- Live Chat Functionality (SignalR)
- Foolproof authentication and responsive for multiple screens :smile:

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With

Following Frameworks are used to make this project

- [![Angular][Angular.io]][Angular-url]
- [![.NET][.NET.io]][.NET-url]
- [![Node][Node.io]][Node-url]
- [![Postgres][Postgres.io]][Postgres-url]
- [![Bootstrap][Bootstrap.com]][Bootstrap-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->

## Getting Started

To get a local copy up and running follow these steps.

### Prerequisites

Install Node v14+ and .NET 6 SDK

- npm
  ```sh
  npm install npm@latest -g
  ```

### Installation

1. Install Postgres and Nuget for development purpose
2. Clone the repo
   ```sh
   git clone https://github.com/webdevtut/MingleWebsite.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. In API folder create your project `API.csproj` and run following command
   ```sh
   dotnet watch run
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->

## Usage

Create an account on deployed website to see the example🤗.

_For more examples, please refer to the [Documentation](https://happenstance.up.railway.app/)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ROADMAP -->

## Roadmap

- [x] Deployment on Railway app
- [x] Responsive styling upgrade
- [x] Upgrade to .NET 6.0
- [ ] Add Features for User Accessibility
  - [ ] Camera access on device for taking and uploading straight from device
  - [ ] Map integration for future use

See the [open issues](https://github.com/webdevtut/MingleWebsite/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->

## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->

## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTACT -->

## Contact

Your Name - [@tushar-web-dev](https://linkedin.com/in/tushar-web-dev/) - tusharlookingforjob@gmail.com

Project Link: [https://github.com/webdevtut/MingleWebsite](https://github.com/webdevtut/MingleWebsite)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->

## Acknowledgments

Use this space to list resources you find helpful and would like to give credit to. I've included a few of my favorites to kick things off!

- [Alternative to Heroku for deployment](https://railway.app/)
- [Choose an Open Source License](https://choosealicense.com)
- [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
- [Img Shields](https://shields.io)
- [GitHub Pages](https://pages.github.com)
- [Font Awesome](https://fontawesome.com)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->

[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/webdevtut/MingleWebsite/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/webdevtut/MingleWebsite/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/tushar-web-dev/
[product-screenshot]: images/screenshot.png
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Postgres.io]: https://img.shields.io/badge/Postgres-12-green
[Postgres-url]: https://www.postgresql.org/
[Node.io]: https://img.shields.io/badge/node-12-brightgreen
[Node-url]: https://nodejs.org/
[.NET.io]: https://img.shields.io/badge/.NET-6-blue
[.NET-url]: https://dotnet.microsoft.com/
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com