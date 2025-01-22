# Oppsummering av prosjektstatus

## Hva vi har gjort
- [x] Definert prosjektets idé og mål.
- [x] Valgt teknologistack:
    - **Frontend**: React, React Router, Zustand, ShadCN.
    - **Backend**: .NET 9 (Minimal API).
    - **Database**: PostgreSQL.
- [x] Opprettet SQL-migreringsfil for `Users`- og `Products`-tabeller.
- [x] Opprettet `DbContext`-klassen for å koble til databasen.
- [x] Implementert CRUD-endepunkter for `Users` og `Products`.

---

## Hva som gjenstår

### Database og backend
- [ ] Validering:
    - [ ] Legg til validering i endepunktene for `Users` og `Products`.
- [ ] Autentisering:
    - [ ] Sett opp autentisering med OAuth2 eller JWT.
- [ ] Filter og søkefunksjonalitet:
    - [ ] Implementer filtre (kategori, pris) og søk i API-et.

### Frontend-utvikling
- [ ] Sett opp grunnleggende React-prosjekt med:
    - [ ] Navigasjon.
    - [ ] Opprettelse av annonse.
    - [ ] Bla gjennom annonser.
    - [ ] Produktdetaljside.

### Hosting og deploy
- [ ] Sett opp hosting for backend (f.eks. AWS Lambda eller Azure).
- [ ] Deploy frontend (f.eks. Vercel eller Netlify).
- [ ] Konfigurer CI/CD-pipelines for automatisert testing og deploy.

### Langsiktige mål
- [ ] **Utvidelse**:
    - [ ] Inkluder komponenter som egne annonser.
- [ ] **Brukerprofiler**:
    - [ ] La selgere opprette profiler med historikk og rating.
- [ ] **Betalingsløsning**:
    - [ ] Integrer Stripe eller Vipps for kjøp og betaling.

---

## Neste steg (prioritert liste)
1. **Backend**:
    - [ ] Legg til validering i eksisterende endepunkter.
    - [ ] Sett opp autentisering.
    - [ ] Implementer filter og søkefunksjonalitet.
2. **Frontend**:
    - [ ] Sett opp prosjektet og integrer API-et.
    - [ ] Lag grunnleggende brukergrensesnitt.
3. **Hosting**:
    - [ ] Sett opp hosting for backend og frontend.
4. **Testing**:
    - [ ] Test funksjonaliteten og koblingen mellom frontend og backend.

---