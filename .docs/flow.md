# Flow

## Datastromen

> Wordt ingevuld na implementatie van de eerste user story.

## Navigatieflow (shell)

```
Gebruiker opent applicatie
  └─► App.razor laadt MainLayout (InteractiveServer)
        ├─► gc-appbar (sticky header)
        │     ├─► Desktop: horizontale nav (NavLink-items)
        │     └─► Mobile: hamburgerknop
        ├─► gc-drawer (mobile, bij openMobile=true)
        │     └─► NavLink-items met iconen
        └─► gc-main (@Body — pagina-inhoud)
```

## Authenticatieflow

> Wordt ingevuld wanneer authenticatie wordt toegevoegd.

## Deployment-flow

> Zie .docs/deployment.md.
