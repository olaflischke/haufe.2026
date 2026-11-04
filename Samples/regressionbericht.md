# Regressionstestbericht

**Build:** `2026.10.14.1`  
**Datenquelle:** [regressionsergebnis.csv](./regressionsergebnis.csv)  
**Berichtsdatum:** 04.11.2026

## Ergebnisübersicht

| Kennzahl | Anzahl |
|---|---:|
| Erfasste Tests | 10 |
| Ausgeführt (ohne übersprungene Tests) | 9 |
| Bestanden | 6 |
| Fehlgeschlagen | 3 |
| Übersprungen | 1 |
| Fehlerquote unter den ausgeführten Tests | 33,3 % (3/9) |

Die Fehlerquote zählt nur ausgeführte Tests; der übersprungene Test ist nicht im Nenner enthalten.

## Gruppierung nach Modul

| Modul | Bestanden | Fehlgeschlagen | Übersprungen | Fehlercodes |
|---|---:|---:|---:|---|
| Anmeldung | 1 | 0 | 0 | – |
| Stammdaten | 1 | 1 | 0 | `DATA-101` (1) |
| Abrechnung | 2 | 2 | 0 | `CALC-204` (2) |
| PDF | 1 | 0 | 0 | – |
| Archivierung | 1 | 0 | 0 | – |
| Import | 0 | 0 | 1 | – |

## Gruppierung nach Fehlercode

| Fehlercode | Modul | Anzahl fehlgeschlagener Tests | Test-IDs |
|---|---|---:|---|
| `CALC-204` | Abrechnung | 2 | `TC-005`, `TC-006` |
| `DATA-101` | Stammdaten | 1* | `TC-003`* |

## Besonders langsame Tests

Als auffällig langsam gelten hier Tests mit einer Laufzeit von **mehr als 80 Sekunden**.

| Test-ID | Modul | Laufzeit |
|---|---|---:|
| `TC-007` | PDF | 140 s |
| `TC-006` | Abrechnung | 92 s |
| `TC-010` | Abrechnung | 90 s |
| `TC-005` | Abrechnung | 88 s |
| `TC-004` | Abrechnung | 83 s |

## Risiken und offene Fragen

- **Datenformatfehler bei `TC-003`:** Die CSV-Zeile enthält `Failed;51` im Ergebnisfeld; dadurch sind die Spalten gegenüber dem Kopf verschoben. `51` könnte die Laufzeit in Sekunden sein, `2026.10.14.1` steht dann im Build-Feld und `DATA-101` im Fehlercode-Feld. Die Zuordnung von Fehlerstatus, Modul, Build und Fehlercode ist plausibel, aber nicht verlässlich bestätigt. Die obige Zuordnung zählt `TC-003` deshalb vorläufig als fehlgeschlagen mit `DATA-101`; die Laufzeit wurde nicht in die Liste langsamer Tests aufgenommen.
- **Fehlerkonzentration in Abrechnung:** Zwei fehlgeschlagene Tests tragen denselben Fehlercode `CALC-204`; Ursache und Auswirkung sind aus der CSV nicht ersichtlich.
- **Übersprungener Import-Test:** Für `TC-009` sind weder Übersprunggrund noch Testabdeckung dokumentiert.
- **Performance:** Fünf Tests überschreiten den hier verwendeten 80-Sekunden-Schwellenwert. Ob dies eine Regression darstellt, lässt sich ohne Referenzlauf oder vereinbarte Laufzeitgrenzen nicht beurteilen.
- Es liegen nur Ergebnisse eines Builds vor; Trends und Reproduzierbarkeit sind nicht bewertbar.

## Vorsichtige Release-Einschätzung

**Freigabe derzeit nicht vorbehaltlos empfohlen.** Die beobachtete Fehlerquote von 33,3 % ist hoch genug, um vor einer Freigabe mindestens `CALC-204` zu untersuchen und den Status bzw. die Fehlerursache von `TC-003` anhand der Quelldaten zu bestätigen. Zusätzlich sollte der Grund für den übersprungenen Import-Test geklärt werden. Eine Freigabeentscheidung sollte erst nach Bewertung der Fehlerauswirkungen und gegebenenfalls einem bestätigenden Regressionstest getroffen werden.
