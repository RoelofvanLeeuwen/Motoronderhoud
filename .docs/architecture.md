# Architecture

## Doel van de applicatie

> Wordt ingevuld na vastlegging van de applicatiebeschrijving in specification.md.

## Huidige solution-structuur

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

## Projectlagen

### Core
Domeinentities, interfaces, enums, value objects, domeinexceptions. Geen externe afhankelijkheden.

### Application
Services, DTO's, service-interfaces, mapping extensions, use cases. Afhankelijk van Core, niet van Infrastructure of Web.

### Infrastructure
EF Core DbContext, repository-implementaties, migraties, externe services. Afhankelijk van Application en Core.

### Web
Server-side Blazor UI. Afhankelijk van Application en Infrastructure. Shell gebaseerd op `.docs/DefaultTemplate.zip`.

### Tests
- `Motoronderhoud.Core.Tests` — unit tests voor domeinlogica
- `Motoronderhoud.Application.Tests` — unit tests voor applicatieservices

## Dependency rules

```
Web
 └─► Application ─► Core
Infrastructure ─► Application ─► Core
```

- Core heeft geen uitgaande afhankelijkheden.
- Application heeft geen afhankelijkheid op Infrastructure of Web.
- Web en Infrastructure kennen Application en Core.

## Belangrijkste domeinconcepten

> Wordt ingevuld na vastlegging van de applicatiebeschrijving.

## Belangrijkste datastromen

> Wordt ingevuld na implementatie van de eerste user story.

## Externe koppelingen

> Geen op dit moment.

## Database en persistence

> Wordt bepaald bij eerste user story met persistence. Standaardkeuze: SQLite voor lokale ontwikkeling.

## Security en autorisatie

> Wordt bepaald bij user stories met authenticatie/autorisatie-eisen.

## Deploymentarchitectuur

> Zie .docs/deployment.md.

## Blazor shell

- `.Web` is server-side Blazor met Interactive Server rendering.
- Shell is gebaseerd op `.docs/DefaultTemplate.zip` (Graafschap College Blazor Template).
- `MainLayout.razor` implementeert gc-shell, gc-appbar, mobile drawer en gc-main.
- CSS uit het template is vertaald naar `wwwroot/css/app.css`.
- React/JSX is alleen als referentie gebruikt; geen React/npm/Babel/Vite in het project.
- `App.razor` rendert `<Routes>` en `<HeadOutlet>` met `@rendermode="InteractiveServer"`.

## Bekende technische beperkingen

> Geen op dit moment.

## Open architectuurvragen

> Worden ingevuld zodra de applicatiescope bekend is.
