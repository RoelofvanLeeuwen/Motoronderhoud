# Specification

## Applicatiebeschrijving

Motoronderhoud is een webapplicatie voor een motoronderhoudsbedrijf waarmee medewerkers en de eigenaar de volledige onderhoudsgeschiedenis van klanten en hun voertuigen kunnen vastleggen en beheren. De applicatie ondersteunt het plannen van aankomende onderhoudsbeurten en het loggen van uitgevoerd onderhoud.

## Doel van de applicatie

Het digitaal bijhouden van onderhoudshistorie per klant en voertuig, zodat het bedrijf snel kan zien wat er wanneer gedaan is, wat er gepland staat en wie welk onderhoud heeft uitgevoerd.

## Doelgroep en gebruikers

Interne gebruikers van het motoronderhoudsbedrijf:
- **Eigenaar** — volledige toegang inclusief gebruikersbeheer
- **Medewerker** — plannen en loggen van onderhoud

Klanten gebruiken de applicatie in versie 1 niet zelf.

## Probleem dat wordt opgelost

Zonder de applicatie wordt onderhoudshistorie bijgehouden op papier of in losse bestanden. Dit maakt het lastig om snel te zien wat er gedaan is, wie het gedaan heeft en wanneer een volgende beurt gepland staat.

## Belangrijkste processen

1. Klant registreren en beheren
2. Voertuig (motor) koppelen aan klant en beheren
3. Aankomend onderhoud inplannen per voertuig
4. Uitgevoerd onderhoud vastleggen (type + omschrijving + kilometerstand + medewerker)
5. Onderhoudsgeschiedenis per voertuig raadplegen
6. Medewerkers beheren (eigenaar)

## Grove scope

### Must haves

- Authenticatie met rollen: eigenaar en medewerker
- Klantenbeheer: aanmaken, bekijken, bewerken (naam, contactgegevens)
- Voertuigbeheer: motor per klant registreren (merk, model, kenteken, bouwjaar, kilometerstand)
- Onderhoudsregistratie: vastleggen wat gedaan is (datum, standaardtype + vrije omschrijving, kilometerstand, medewerker)
- Onderhoud plannen: aankomende beurten inplannen per voertuig
- Onderhoudsgeschiedenis: historieoverzicht per voertuig bekijken
- Gebruikersbeheer: eigenaar kan medewerkers aanmaken en beheren

### Should haves

- Werklijst/dashboard met aankomend gepland onderhoud
- Zoeken en filteren op klant of voertuig

### Could haves

- Rapportages per voertuig of periode
- Wachtwoord wijzigen via eigen profiel

### Won't haves voor deze fase

- Notificaties naar klanten (gepland voor toekomstige versie)
- Klantenportaal — klant logt zelf in
- Facturatie of koppeling met boekhoudpakket
- Voorraadbeheer onderdelen

## Rollen / actoren

| Rol | Omschrijving | Rechten |
|-----|-------------|---------|
| Eigenaar | Bedrijfseigenaar | Volledig: klanten, voertuigen, onderhoud, gebruikersbeheer |
| Medewerker | Monteur of baliemedewerker | Onderhoud plannen en loggen; klanten en voertuigen bekijken |

## Randvoorwaarden

- Applicatie draait als server-side Blazor webapplicatie
- Authenticatie is verplicht; geen anonieme toegang
- Onderhoudstypen zijn een combinatie van vaste standaardtypen en een vrij tekstveld

## Externe koppelingen

Geen voor versie 1.

## Security, privacy en autorisatie

- Alle functies vereisen authenticatie
- Eigenaar heeft toegang tot gebruikersbeheer; medewerkers niet
- Klant- en voertuiggegevens zijn alleen zichtbaar voor ingelogde gebruikers

## Definitie van succes voor de eerste versie

Een medewerker kan inloggen, een klant met bijbehorende motor opzoeken of aanmaken, een onderhoudsbeurt plannen en na uitvoering vastleggen wat er gedaan is. De eigenaar kan de volledige geschiedenis raadplegen en medewerkers beheren.

## User stories

### US-001 — Inloggen en uitloggen

Als eigenaar of medewerker  
wil ik kunnen inloggen met e-mailadres en wachtwoord  
zodat ik toegang heb tot de applicatie en anderen geen ongeautoriseerde toegang hebben.

#### Acceptatiecriteria

- [ ] Er is een loginpagina met velden voor e-mailadres en wachtwoord
- [ ] Bij correcte gegevens wordt de gebruiker doorgestuurd naar de homepagina
- [ ] Bij onjuiste gegevens verschijnt een foutmelding (zonder te vermelden wat fout is)
- [ ] Niet-ingelogde gebruikers worden automatisch doorgestuurd naar de loginpagina
- [ ] Een eigenaar-account heeft de rol `Eigenaar`
- [ ] Een medewerker-account heeft de rol `Medewerker`
- [ ] Pagina's die alleen voor de eigenaar zijn, zijn niet bereikbaar voor medewerkers
- [ ] Er is een uitlogknop zichtbaar voor ingelogde gebruikers in de navigatie
- [ ] Na uitloggen wordt de gebruiker doorgestuurd naar de loginpagina
- [ ] Na uitloggen werkt de terugknop niet meer terug naar beveiligde pagina's
- [ ] Bij het eerste opstarten bestaat er een standaard eigenaar-account (e-mail + tijdelijk wachtwoord, vastgelegd in documentatie)

#### Technische notities

- ASP.NET Core Identity met cookie-authenticatie
- SQLite als database (via EF Core in Infrastructure)
- Rollen: `Eigenaar` en `Medewerker` (constanten in Application.Constants)
- Login/logout via Razor Pages (buiten Blazor circuit — vereist voor Identity cookie-flow)
- Seed-data: één eigenaar-account bij eerste start
- `AddCascadingAuthenticationState()` + `AuthorizeView` in Blazor shell

#### Status

In ontwikkeling

## Niet-functionele eisen

- Responsive: werkt op desktop en tablet (primair) en mobiel (secundair)
- Nederlandse interface

## Open vragen

- Welke standaard onderhoudstypen zijn er? (bijv. grote beurt, kleine beurt, bandenwissel, ketenonderhoud, APK-keuring — te bevestigen bij US over onderhoudsregistratie)
- Hoeveel medewerkers heeft het bedrijf typisch? (relevant voor schaalbaarheid)

## Wijzigingshistorie

| Datum | Wijziging |
|-------|-----------|
| 2026-05-27 | Initieel aangemaakt |
| 2026-05-27 | Applicatiescope vastgelegd op basis van gebruikersbeschrijving |
