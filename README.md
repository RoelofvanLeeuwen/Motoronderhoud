# Motoronderhoud

> Applicatiebeschrijving volgt na vastlegging van de scope.

## Technische stack

- .NET 10 — server-side Blazor (`.Web`)
- Clean Architecture (Core / Application / Infrastructure / Web)
- EF Core (database provider wordt bepaald)
- Graafschap College Blazor Template (designbaseline)

## Solution-structuur

```text
Motoronderhoud.slnx
├── src/
│   ├── Motoronderhoud.Core/
│   ├── Motoronderhoud.Application/
│   ├── Motoronderhoud.Infrastructure/
│   └── Motoronderhoud.Web/
└── tests/
    ├── Motoronderhoud.Core.Tests/
    └── Motoronderhoud.Application.Tests/
```

## Lokaal draaien

```bash
cd src/Motoronderhoud.Web
dotnet run
```

## Documentatie

Zie de `.docs/`-map:

- `development-guidelines.md` — ontwikkelrichtlijnen
- `architecture.md` — architectuurbeschrijving
- `decisions.md` — technische keuzes
- `progress.md` — voortgang
- `specification.md` — applicatiescope en user stories

## Branches

- `main` — stabiele releases
- `development` — actieve ontwikkeling
- `feature/US-xxx-*` — user-story branches

## AI-assistenten

Zie `AGENTS.md` (tool-onafhankelijk) en `CLAUDE.md` (Claude Code-specifiek).
