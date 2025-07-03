# WindowmakerV3 CI/CD Practice

[![CI](https://github.com/JaggyG/WindowmakerV3-CICD-Practice/actions/workflows/ci.yml/badge.svg)](https://github.com/JaggyG/WindowmakerV3-CICD-Practice/actions/workflows/ci.yml)
![Coverage](https://img.shields.io/badge/Code%20Coverage-0%25-red.svg)

This is a practice project to learn CI/CD concepts before implementing them in WindowmakerV3.

## Project Structure

```
├── src/
│   └── TestApi/           # Simple .NET 8 Web API
│       ├── Controllers/
│       └── TestApi.csproj
├── tests/
│   └── TestApi.Tests/     # Unit and integration tests
├── .github/
│   └── workflows/
│       └── ci.yml         # GitHub Actions CI/CD pipeline
└── README.md
```

## Features

- ✅ Basic CI pipeline with GitHub Actions
- ✅ Automated testing on push/PR
- ✅ Code coverage reporting
- 🚧 Code quality checks (coming soon)
- 🚧 Multi-environment testing (coming soon)
- 🚧 Deployment pipeline (coming soon)

## Running Locally

```bash
# Build the project
dotnet build

# Run tests
dotnet test

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## CI/CD Pipeline

The CI pipeline runs automatically on:
- Push to `main` or `develop` branches
- Pull requests to `main` branch

### Pipeline Steps

1. **Setup**: Configure .NET 8.0 environment
2. **Restore**: Download NuGet packages
3. **Build**: Compile in Release mode
4. **Test**: Run all unit and integration tests with coverage
5. **Coverage**: Generate coverage reports
6. **Artifacts**: Upload build outputs and coverage reports