# Deployment

## Benodigde SDK/runtime

- .NET 10.0.300 of hoger

## Database

> Nog niet bepaald. Zie .docs/decisions.md.

## Connection strings

> Worden toegevoegd bij implementatie van persistence.

## Environment variables

> Worden toegevoegd wanneer nodig.

## Lokaal draaien

```bash
cd src/Motoronderhoud.Web
dotnet run
```

Navigeer naar `https://localhost:5001` of het poort dat verschijnt in de console.

## Poorten

> Standaard ASP.NET Core poorttoewijzing. Wordt geconfigureerd bij deployment.

## Startvolgorde

1. Database migrations uitvoeren (zodra EF Core is toegevoegd)
2. `dotnet run` in `src/Motoronderhoud.Web`

## Branches en deployment

- `development` → feature-ontwikkeling
- `main` → productie-releases (via pull request van development)
- Deployment altijd vanaf `main`

## Updateproces

1. Pull request van featurebranch naar `development`
2. Na acceptatie: pull request van `development` naar `main`
3. Deploy vanaf `main`

## Rollback

> Wordt ingevuld bij eerste productie-deployment.
