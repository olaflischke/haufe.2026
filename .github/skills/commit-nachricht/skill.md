---
name: commit-nachricht
description: Schreibt eine Commit-Nachricht nach dem Team-Format aus den bereitgestellten Änderungen. Nutze diesen Skill, wenn der Nutzer eine Commit-Nachricht oder einen Commit-Text verlangt.
---

# Commit-Nachricht schreiben

1. Lies die bereitgestellten Änderungen (git diff --staged). Gibt es keine, sage Bescheid und stoppe.
2. Wähle einen Typ aus 'references/format.md': feat, fix, refactor, test oder docs.
3. Schreibe eine Betreffzeile mit höchstens 72 Zeichen im Format: typ(bereich): kurze Aussage.
4. Schreibe im Textteil, warum die Änderung nötig war. Ein bis drei Sätze.
5. Gib nur die Nachricht aus. Committe nichts selbst.