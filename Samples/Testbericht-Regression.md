# Testbericht – Regressionsergebnis

**Datengrundlage:** [regressionsergebnis.csv](./regressionsergebnis.csv)  
**Build:** `2026.10.14.1`

## Testergebnis

| Kennzahl | Anzahl |
|---|---:|
| Tests insgesamt | 10 |
| Ausgeführt (ohne übersprungene Tests) | 9 |
| Bestanden | 6 |
| Fehlgeschlagen | 3 |
| Übersprungen | 1 |

**Fehlerquote:** 33,3 % der ausgeführten Tests (3 von 9). Bezogen auf alle 10 erfassten Tests sind es 30 %.

## Ergebnisse nach Modul

| Modul | Bestanden | Fehlgeschlagen | Übersprungen | Fehlercodes |
|---|---:|---:|---:|---|
| Anmeldung | 1 | 0 | 0 | – |
| Stammdaten | 1 | 1 | 0 | DATA-101 (1) |
| Abrechnung | 2 | 2 | 0 | CALC-204 (2) |
| PDF | 1 | 0 | 0 | – |
| Archivierung | 1 | 0 | 0 | – |
| Import | 0 | 0 | 1 | – |

**Fehler nach Fehlercode:** `CALC-204`: 2 Tests; `DATA-101`: 1 Test.

## Besonders langsame Tests

Als auffällig langsam gelten hier Tests mit einer Laufzeit von **mehr als 60 Sekunden**. Ein vereinbarter Grenzwert liegt nicht vor.

- `TC-007` (PDF): 140 s
- `TC-006` (Abrechnung): 92 s
- `TC-010` (Abrechnung): 90 s
- `TC-005` (Abrechnung): 88 s
- `TC-004` (Abrechnung): 83 s

## Risiken und offene Fragen

- Beide Fehler in **Abrechnung** haben denselben Fehlercode `CALC-204`; die Ursache sollte vor einer Freigabe geklärt werden.
- Der Test `TC-009` für **Import** wurde übersprungen. Damit ist dieses Modul in diesem Lauf nicht bewertet.
- Für die Laufzeiten fehlen definierte Schwellenwerte oder Vergleichswerte aus früheren Builds.
- Aus den CSV-Daten gehen weder Fehlerdetails noch Testumfang und Kritikalität der Tests hervor.

## Vorsichtige Release-Einschätzung

**Derzeit keine Freigabe empfohlen.** Zuerst sollten die drei fehlgeschlagenen Tests untersucht und der übersprungene Import-Test nachgeholt werden. Danach empfiehlt sich ein erneuter Regressionlauf; die langsamen Tests sollten anhand vereinbarter Laufzeitziele bewertet werden.
