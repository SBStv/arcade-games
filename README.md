# Arcade Games

## Publish with GitHub Pages

The `main` branch automatically deploys `index.html`, `frogger.html`, and `Tadpole Hop.html` to GitHub Pages. In the repository settings, open **Pages** and select **GitHub Actions** as the build and deployment source. The workflow publishes only these HTML files; Visual Studio project files are not included.

## Run and edit in Visual Studio

Open `ArcadeGames.csproj` from this repository in Visual Studio and press **F5**. The project serves `frogger.html` and `index.html` directly from the repository root, so edit those files in place; no copies are needed. The game opens at `http://localhost:5188/frogger.html`.

The project targets the .NET 10 SDK.
