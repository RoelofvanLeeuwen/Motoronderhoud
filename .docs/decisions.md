# Decisions

## Actieve keuzes

| Datum | Keuze | Reden | Impact | Status |
|-------|-------|-------|--------|--------|
| 2026-05-27 | .NET 10.0.300 als target framework | Hoogste geïnstalleerde stabiele SDK op ontwikkelmachine | Alle projecten targeten net10.0 | Actief |
| 2026-05-27 | .slnx solution-formaat | Ondersteund in .NET 10 tooling; modernere en lichtere opzet dan .sln | Solution-bestand is Motoronderhoud.slnx | Actief |
| 2026-05-27 | Clean Architecture (Core / Application / Infrastructure / Web) | Scheiding van verantwoordelijkheden, testbaarheid en uitbreidbaarheid | Vier src-projecten, twee testprojecten | Actief |
| 2026-05-27 | Server-side Blazor met Interactive Server rendering | UI-project is .Web; interactieve shell vereist InteractiveServer render mode | MainLayout en shell componenten renderen interactief | Actief |
| 2026-05-27 | DefaultTemplate.zip als verplichte designbasis voor Blazor shell | Consistente visuele basis; standaard Blazor uiterlijk is niet toegestaan | Standaard Blazor CSS vervangen door gc-* design system | Actief |
| 2026-05-27 | Handmatige mapping via extension methods in plaats van AutoMapper | Maakt de mapping-flow explicieter en beter leesbaar | Geen AutoMapper-dependency | Actief |
| 2026-05-27 | Generic IRepository<T> patroon voor persistence | Herbruikbaar CRUD-patroon; specifieke repositories alleen bij domeinspecifieke queries | IRepository<T> in Core.Interfaces | Actief |
| 2026-05-27 | DI-registraties per project via static DependencyInjection extension class | Program.cs blijft dun; iedere laag beheert eigen registraties | DependencyInjection.cs in elke laag | Actief |
| 2026-05-27 | SQLite als database voor v1 | Eenvoudig lokaal — geen aparte databaseserver nodig; geschikt voor ontwikkeling en kleine productie-omgevingen | AppDbContext target SQLite; migrations in Infrastructure | Actief |
| 2026-05-27 | ASP.NET Core Identity voor authenticatie | Standaard .NET authenticatieoplossing met ingebouwde rol- en gebruikersbeheer | ApplicationUser extends IdentityUser; AppDbContext extends IdentityDbContext | Actief |
| 2026-05-27 | E-mailadres als gebruikersnaam | Gebruiksvriendelijk en uniek per gebruiker | UserName == Email in Identity configuratie | Actief |
| 2026-05-27 | Login/logout via Razor Pages (buiten Blazor circuit) | Identity cookie-flow vereist HTTP response; kan niet via Blazor SignalR-circuit | Pages/Account/Login.cshtml en Logout.cshtml in .Web | Actief |

## Vervangen of achterhaalde keuzes

| Datum | Oude keuze | Nieuwe keuze | Reden | Impact |
|-------|-----------|--------------|-------|--------|
| — | — | — | — | — |

## Open beslispunten

| Vraag | Context | Mogelijke opties | Benodigde actie |
|-------|---------|-----------------|-----------------|
| Database provider | Nog niet bepaald — afhankelijk van applicatiescope | SQLite (lokaal eenvoudig), SQL Server (productie) | Bepalen bij eerste user story met persistence |
| .Api project nodig? | Afhankelijk van of er een externe API-koppeling of separate client nodig is | Alleen .Web (Blazor direct op services), .Web + .Api | Bepalen na vastlegging applicatiescope |
