TextureSound: Multisensorische Wahrnehmung von identischen VR-Exponaten
--
Einleitung

In immersiven VR-Umgebungen spielt die Kombination aus visuellen, auditiven und haptischen Reizen eine zentrale Rolle für das Nutzererlebnis. Dieses Projekt untersucht, wie sich geometrisch identische VR-Objekte (z. B. Holz oder Stein) in ihrer Wahrnehmung unterscheiden, wenn sie unterschiedlich modelliert, vertont und mit haptischem Feedback versehen sind.
Das Projekt ist eingebettet in das Seminar *Augmented and Virtual Reality (SS 2025)* und basiert auf den Grundlagen aus Dörner et al. (vgl. Kapitel 2.3 *Multisensorische Wahrnehmung*, S. 53) sowie dem Teamkonzept von AVR2025-TextureSound.

Die Wahrnehmung von Objekten und deren Eigenschaften ist ein komplexer Prozess, der nicht nur von den Sinnen, sondern auch von deren Interaktionen abhängt. Besonders in Virtual Reality (VR) ergeben sich neue Herausforderungen und Chancen, die Art und Weise, wie wir die Welt erfahren, zu gestalten. In einer virtuellen Umgebung kommen verschiedene **Sinne** wie Sehen, Hören und Fühlen zusammen, was die Wahrnehmung von Objekten maßgeblich beeinflusst.

Wieso nehmen Menschen Dinge unterschiedlich wahr?

Die Wahrnehmung ist nie objektiv – sie wird durch eine Vielzahl von Faktoren gefiltert, darunter:

1. Kognitive Verzerrungen: Unsere Wahrnehmung wird durch persönliche Erfahrungen, kulturelle Hintergründe und emotionale Zustände beeinflusst. So kann eine Person ein Material als glatt empfinden, während eine andere es als rau wahrnimmt.
2. Sinne im Zusammenspiel: Die Sinne sind eng miteinander verknüpft. Ein Geräusch kann beispielsweise die Wahrnehmung einer Textur verändern. Dieses Zusammenspiel wird als **crossmodal perception** bezeichnet.
3. Kontext: Die gleiche Information wird in verschiedenen Kontexten unterschiedlich wahrgenommen. Ein Geräusch, das in einem ruhigen Raum angenehm ist, kann in einer lärmigen Umgebung störend wirken.

---

1. Ziel und Zweck

Ziel

Erforschung der Wirkung von Haptik-Komplexität, Klang und Textur auf die Wahrnehmung und Immersion in VR (vgl. Dörner et al., Kapitel 2.3.1 *Auditive Wahrnehmung*, S. 53; Kapitel 2.3.2 *Haptische Wahrnehmung*, S. 54). Ziel ist es, zu verstehen, wie das Zusammenspiel dieser Sinneseindrücke das Erlebnis in einer VR-Umgebung beeinflusst und welche Erkenntnisse daraus für das Design von immersiven, realistischen Erlebnissen gewonnen werden können.

Zweck

Ermittlung, wie realistisch Materialien in VR erlebbar sind und welche Reize am stärksten zur multisensorischen Differenzierung beitragen.

Zielgruppe

- Studierende im Bereich UX/HCI
- VR-Designer:innen
- Forschende im Bereich Wahrnehmung

---

2. Funktionale Anforderungen

Materialien
- Glatt: Glas, Metall  
- Rau: Holz, Sandpapier  
- Weich (optional): Moos, Stoff

Interaktionen
- Greifen, Streichen, Drücken
- Wechsel zwischen zwei Flächen zur direkten Vergleichbarkeit

Feedback
- Haptisch: Vibrationsfeedback über Controller (vgl. Dörner et al., Kapitel 5.5 *Haptische Ausgabegeräte*, S. 212)  
- Auditiv: materialspezifische Sounds (z. B. Knirschen, Klirren)  
- Visuell: Texturwechsel, Aufleuchten, Partikeleffekte

---

3. Technische Umsetzung

Tools und Frameworks
- Unity 3D + XR Interaction Toolkit
- Blender für 3D-Modelle
- Audacity für Sound-Editing
- Meta Haptics Studio für Vibrations-Feedback

Assets & Hardware
- Assets: Polyhaven, CGTrader, Pixabay
- Hardware: Meta Quest 2/3 + Controller
- Laptop: mind. 8 GB RAM

Performanceoptimierung
- Low-Poly-Modelle
- einfache Shader
- Vibration nur bei aktiver Interaktion
- regelmäßiges Testing auf Zielplattform

---

4. Interaktionsdesign & UX

Interaktionsprinzipien
- Greifen per Controller oder optional Handtracking  
- Visuelle Hinweise: Leuchtflächen, Pfeile  
- Direktes Feedback bei Berührung

UX-Features
- Kurzes Onboarding mit Tooltips
- Konsistente Rückmeldungen (Textur, Klang, Vibration)  
- Usability-Tests, A/B-Vergleiche, Likert-Skalen

Fallbacks
- Handtracking optional  
- Feedback individuell deaktivierbar

---

5. Projektmanagement

Meilensteine

Meilensteine:


| Woche | Aufgabe                                | Datum     |
|-------|----------------------------------------|-----------|
| 1     | Konzept & Tool-Einrichtung             | 30.04.2025 |
| 2–3   | Erste Prototypen in Unity              | 14.05.2025 |
| 4–6   | Integration von Sound & Haptik         | 04.06.2025 |
| 7–9   | Usability-Tests & Feinschliff          | 25.06.2025 |
| 10    | Abgabe & Abschlusspräsentation         | 07.07.2025 |

Team & Aufgabenverteilung

- A: 3D-Modellierung (Objekt 1, Szene 1), Szene 1 Gesamtverantwortung  
- B: 3D-Modellierung (Objekt 2, Szene 1), Szene 2 Gesamtverantwortung  
- C: Haptik-Feedback, UI/UX, Modellierung (Szene 2)  
- D: Sounddesign, UI/UX, Modellierung (Szene 2)  
- Alle: GitHub, Dokumentation, Testing

Risiken & Lösungen

| Risiko                      | Lösung                                                      |
|----------------------------|-------------------------------------------------------------|
| Asset-Verzögerung          | Nutzung freier Quellen, Notfall: Eigenmodellierung         |
| Performance-Probleme       | Low-Poly-Assets, Lichtquellen reduzieren, regelmäßiges Testen |
| Unsynchrones Feedback      | Exakte Trigger-Logik, Debugging                             |
| Zeitverzug                 | Pufferzeiten einplanen, Kernfunktionen priorisieren         |

---

6. Wahrnehmungskategorien (Beispielübersicht)

| Material | Textur (visuell) | Sound (auditiv) | Vibration (haptisch) | Typische Assoziation     |
|----------|------------------|-----------------|-----------------------|---------------------------|
| Holz     | rau, gemasert    | knarzend        | weich, kurz           | warm, natürlich           |
| Stein    | körnig, matt     | dumpf, trocken  | stark, stoßartig      | schwer, kühl              |
| Metall   | glatt, glänzend  | metallisch, hell| vibrierend, lang      | kalt, industriell         |
| Stoff    | weich, diffus    | kaum hörbar     | sanft, kontinuierlich | gemütlich, organisch      |

---

7. Weiterführende Perspektiven

- Vertiefung der Cybersickness-Forschung bei inkongruenten Reizen (vgl. Dörner et al., Kapitel 2.4.7 *Cybersickness*, S. 67)
- Vergleich der Einflüsse einzelner Sinne auf Materialerkennung
- Integration von künstlicher Intelligenz zur adaptiven Feedbacksteuerung
- Multimodales Design für Barrierefreiheit in VR-Anwendungen

---

8. Fazit

Dieses Projekt zeigt auf, wie durch die gezielte Kombination von Klang, Textur und Haptik eine realitätsnahe und differenzierte Materialwahrnehmung in VR möglich wird. Dabei liegt der Fokus klar auf intuitiver Interaktion, technischer Effizienz und multisensorischer Authentizität.

> Viele Ideen lassen sich durch das modulare Design schrittweise realisieren – das Experimentieren steht im Zentrum.
