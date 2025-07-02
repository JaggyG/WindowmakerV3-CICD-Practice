# CI/CD Practice Project

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

## What We're Learning

1. **Basic CI/CD Pipeline**: Automatically build and test code when pushed
2. **GitHub Actions**: Microsoft's CI/CD platform
3. **Automated Testing**: Run tests on every code change
4. **Build Validation**: Ensure code compiles before merging

## How to Use

1. Push this code to a GitHub repository
2. GitHub will automatically run the CI pipeline
3. Check the "Actions" tab to see results
4. Try making changes and see the pipeline run again

## Next Steps

Once we understand these basics, we'll:
- Add deployment steps
- Add security scanning
- Add code coverage reports
- Create more complex workflows