[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Mutation testing badge](https://img.shields.io/endpoint?style=for-the-badge&url=https://badge-api.stryker-mutator.io/github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/main)](https://dashboard.stryker-mutator.io/reports/github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/main)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Lesson-DotNet-Test-Mutation&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=Lesson-DotNet-Test-Mutation)
[![Build and Test](https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/actions/workflows/build.yml)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=Lesson-DotNet-Test-Mutation&metric=bugs)](https://sonarcloud.io/summary/new_code?id=Lesson-DotNet-Test-Mutation)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=Lesson-DotNet-Test-Mutation&metric=coverage)](https://sonarcloud.io/summary/new_code?id=Lesson-DotNet-Test-Mutation)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=Lesson-DotNet-Test-Mutation&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=Lesson-DotNet-Test-Mutation)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=Lesson-DotNet-Test-Mutation&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=Lesson-DotNet-Test-Mutation)

## Pub Dev Store to defeat the mutants 📚🕹

this read-me still under development, We had time to develop the whole solution but not to create a good read-me 😜

<!-- ABOUT THE PROJECT -->

## About The Project

Here's why:

- .NET 6.0 is the most advanced and fast framework to develop applications using C#
- It's fun! 🚀🎉

## Adding Migrations 📚

```
Add-Migration [MigrationName] -OutputDir Configuration\Migrations
```

## Tests ✍️

```
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## Tests Mutations (Stryker) 👽

```
dotnet stryker -tp "tests/API.Tests/PubDev.Store.API.Tests.csproj"
```

<!-- ROADMAP -->

## Roadmap 👀

- Ran out of Ideas 🤣, feel free to add one

See the [open issues](https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/issues) for a full list of proposed features (and known issues).

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

<!-- CONTACT -->

## Contact

- Humberto Rodrigues - [@1bberto](https://instagram.com/1bberto) - humberto_henrique1@live.com
- Rafael Nagai - [@rafakenji23](https://instagram.com/rafakenji23) - rafakenji23@gmail.com
- Discord Server - [https://discord.com/invite/EvD6Um5Jw2](https://discord.com/invite/EvD6Um5Jw2)
- LinkedIn - [https://www.linkedin.com/company/pubdev](https://www.linkedin.com/company/pubdev)

Project Link: [https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation](https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation)

<!-- ACKNOWLEDGMENTS -->

## Acknowledgments

- [.NET 6](https://docs.microsoft.com/en-us/dotnet/api/?view=net-6.0)
- [Stryker](https://stryker-mutator.io/)
- [Dapper](https://dapperlib.github.io/Dapper/)
- [XUnit](https://xunit.net/)
- [Coverlet](https://github.com/coverlet-coverage/coverlet)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/Pub-Dev/Lesson-DotNet-Test-Mutation.svg?style=for-the-badge
[contributors-url]: https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Pub-Dev/Lesson-DotNet-Test-Mutation.svg?style=for-the-badge
[forks-url]: https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/network/members
[stars-shield]: https://img.shields.io/github/stars/Pub-Dev/Lesson-DotNet-Test-Mutation.svg?style=for-the-badge
[stars-url]: https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/stargazers
[issues-shield]: https://img.shields.io/github/issues/Pub-Dev/Lesson-DotNet-Test-Mutation.svg?style=for-the-badge
[issues-url]: https://github.com/Pub-Dev/Lesson-DotNet-Test-Mutation/issues
