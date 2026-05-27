# Progress

## Huidige status

US-001 (Authenticatie) gereed. Login, logout en seeding functioneel getest. Klaar voor merge naar development.

## Actieve branch

`feature/US-001-authenticatie`

## Laatste werkende situatie

`dotnet build` slaagt zonder fouten of waarschuwingen. App start op, SQLite-database wordt aangemaakt, eigenaar-account wordt geseeed, login/logout werken correct.

## Afgeronde onderdelen

| Datum | Onderdeel | Resultaat | Teststatus |
|-------|-----------|-----------|------------|
| 2026-05-27 | Documentatiestructuur | Aangemaakt (.docs/*.md, README.md) | N.v.t. |
| 2026-05-27 | Git-repository | Geïnitialiseerd, main gepusht naar GitHub | N.v.t. |
| 2026-05-27 | Clean Architecture solution | Motoronderhoud.slnx, Core/Application/Infrastructure/Web/Tests op development | dotnet build: 0 errors, 0 warnings |
| 2026-05-27 | Blazor designbaseline | DefaultTemplate.zip vertaald naar MainLayout.razor, Icon.razor, app.css | dotnet build: 0 errors, 0 warnings |
| 2026-05-27 | US-001 Authenticatie | ASP.NET Core Identity + SQLite, login/logout via Razor Pages, seeder eigenaar-account | Alle acceptatietesten geslaagd |

## Lopende onderdelen

| Onderdeel | Status | Volgende stap | Blokkades |
|----------|--------|---------------|-----------|
| — | — | — | — |

## Nog te doen

| Prioriteit | Onderdeel | Reden |
|-----------|-----------|-------|
| 1 | PR feature/US-001-authenticatie → development mergen | US-001 klaar voor review |
| 2 | Volgende user story (US-002) bespreken en verfijnen | Na merge US-001 |

## Bekende problemen

| Probleem | Impact | Mogelijke oplossing |
|---------|--------|---------------------|
| — | — | — |

## Laatste acceptatietesten

| Datum | Test | Resultaat |
|-------|------|-----------|
| 2026-05-27 | GET / ongeauthenticeerd → 200 (geen globale auth-guard) | Verwacht; login-redirect geldt per component |
| 2026-05-27 | GET /account/login → 200, formulier zichtbaar | Geslaagd |
| 2026-05-27 | POST /account/login juiste credentials → 302 redirect naar / | Geslaagd |
| 2026-05-27 | POST /account/login fout wachtwoord → 200, foutmelding zichtbaar | Geslaagd |
| 2026-05-27 | POST /account/logout → 302 redirect naar /account/login | Geslaagd |

## Volgende logische stap

PR aanmaken feature/US-001-authenticatie → development, daarna US-002 bespreken.
