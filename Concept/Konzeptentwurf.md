# TextureSound: Multisensorische Wahrnehmung von identischen VR-Exponaten
## Einleitung

In immersiven VR-Umgebungen spielt die Kombination aus visuellen, auditiven und haptischen Reizen eine zentrale Rolle für das Nutzererlebnis. Dieses Projekt untersucht, wie sich geometrisch identische VR-Objekte (z. B. Holz oder Stein) in ihrer Wahrnehmung unterscheiden, wenn sie unterschiedlich modelliert, vertont und mit haptischem Feedback versehen sind. Das Projekt ist eingebettet in das Seminar Augmented and Virtual Reality (SS 2025) und basiert auf den Grundlagen aus Dörner et al. (vgl. Kapitel 2.3 Multisensorische Wahrnehmung, S. 53) sowie dem Teamkonzept von AVR2025-TextureSound.

Die Wahrnehmung von Objekten und deren Eigenschaften ist ein komplexer Prozess, der nicht nur von den Sinnen, sondern auch von deren Interaktionen abhängt. Besonders in Virtual Reality (VR) ergeben sich neue Herausforderungen und Chancen, die Art und Weise, wie wir die Welt erfahren, zu gestalten. In einer virtuellen Umgebung kommen verschiedene Sinne wie Sehen, Hören und Fühlen zusammen, was die Wahrnehmung von Objekten maßgeblich beeinflusst.

### Wieso nehmen Menschen Dinge unterschiedlich wahr?

Die Wahrnehmung ist nie objektiv – sie wird durch eine Vielzahl von Faktoren gefiltert, darunter:

Kognitive Verzerrungen: Unsere Wahrnehmung wird durch persönliche Erfahrungen, kulturelle Hintergründe und emotionale Zustände beeinflusst. So kann eine Person ein Material als glatt empfinden, während eine andere es als rau wahrnimmt.
Sinne im Zusammenspiel: Die Sinne sind eng miteinander verknüpft. Ein Geräusch kann beispielsweise die Wahrnehmung einer Textur verändern. Dieses Zusammenspiel wird als crossmodal perception bezeichnet.
Kontext: Die gleiche Information wird in verschiedenen Kontexten unterschiedlich wahrgenommen. Ein Geräusch, das in einem ruhigen Raum angenehm ist, kann in einer lärmigen Umgebung störend wirken.

## Ziel und Zweck
### Ziel

Erforschung der Wirkung von Haptik-Komplexität, Klang und Textur auf die Wahrnehmung und Immersion in VR (vgl. Dörner et al., Kapitel 2.3.1 Auditive Wahrnehmung, S. 53; Kapitel 2.3.2 Haptische Wahrnehmung, S. 54). Ziel ist es, zu verstehen, wie das Zusammenspiel dieser Sinneseindrücke das Erlebnis in einer VR-Umgebung beeinflusst und welche Erkenntnisse daraus für das Design von immersiven, realistischen Erlebnissen gewonnen werden können.

### Zweck

Ermittlung, wie realistisch Materialien in VR erlebbar sind und welche Reize am stärksten zur multisensorischen Differenzierung beitragen.

### Zielgruppe

- Studierende im Bereich UX/HCI
- VR-Designer:innen
- Forschende im Bereich Wahrnehmung

# TextureSound: Multisensorische Wahrnehmung von identischen VR-Exponaten

## Einleitung

In immersiven Virtual-Reality-Umgebungen spielt die Kombination aus visuellen, auditiven und haptischen Reizen eine zentrale Rolle für das Nutzererlebnis. Dieses Projekt untersucht, wie sich geometrisch identische VR-Objekte (z. B. Holz, Stein) in ihrer Wahrnehmung unterscheiden, wenn sie unterschiedlich modelliert, vertont und mit haptischem Feedback versehen sind.

Die Arbeit basiert auf den Grundlagen aus *Dörner et al., Virtual und Augmented Reality (2. Auflage, 2013)* und dem Teamkonzept von *AVR2025-TextureSound*.

Die Wahrnehmung von Objekten ist ein multisensorischer Prozess, der durch Sinnesüberlagerungen, kognitive Verzerrungen und Kontextfaktoren beeinflusst wird. Besonders in VR ergeben sich neue Chancen, wie wir die Welt erleben und gestalten.

---

## Hintergrund: Multisensorische Wahrnehmung in VR

### Warum nehmen Menschen Dinge unterschiedlich wahr?

- **Kognitive Verzerrungen:** Persönliche Erfahrungen, Kultur und Emotionen beeinflussen die Wahrnehmung.
- **Crossmodale Wahrnehmung:** Reize eines Sinnes (z. B. Klang) verändern die Wahrnehmung eines anderen Sinnes (z. B. Textur).
- **Kontextabhängigkeit:** Die gleiche Information wird je nach Umgebung anders interpretiert.

Diese Faktoren unterstreichen die Bedeutung eines sorgfältig abgestimmten multisensorischen Designs in VR.

---

## Ziel und Zweck

### Ziel

Erforschung der Wirkung von Haptik-Komplexität, Klang und Textur auf die Materialwahrnehmung und Immersion in VR (vgl. Dörner et al., Kapitel 2.3).

### Zweck

Ermittlung, welche Reize am stärksten zur differenzierten Wahrnehmung beitragen, und Ableitung von Empfehlungen für immersive VR-Designs.

### Zielgruppe

- Studierende (UX/HCI, VR-Design)
- Forschende im Bereich Wahrnehmungspsychologie
- Praktiker:innen der VR-Entwicklung

---

## Technische Umsetzung

### 1. 3D-Objekt-Erstellung

Basierend auf *Dörner et al., Kapitel 3D-Objekte (S.81–95)*:

- **Modellierung:** Erstellung von Oberflächen- und Festkörpermodellen in **Blender**.
- **Texturierung:** Einsatz von Texturen für realistische Oberflächen.
- **Shader:** Anwendung von Physically Based Rendering (PBR) im Unity-Editor.

**Workflow:**
- Modellierung und Texturierung in **Blender**
- Export als `.fbx` oder `.glb`
- Import in **Unity**
- Materialzuweisung mit Unity Standard Shadern

**Links zur Vertiefung:**
- [Blender Material Einführung](https://www.youtube.com/watch?v=GwFJ8iJZnHU)
- [Unity Creating Physically Based Materials](https://learn.unity.com/tutorial/creating-pbr-materials)

---

### 2. Materialien, Interaktionen und Feedback

**Materialien:**
- Glatt: Glas, Metall
- Rau: Holz, Sandpapier
- Weich (optional): Moos, Stoff

**Interaktionen:**
- Greifen, Streichen, Drücken
- Wechsel zwischen zwei Flächen für direkten Vergleich

**Feedback:**
- **Haptisch:** Vibrationsfeedback über Controller
- **Auditiv:** Materialspezifische Sounds
- **Visuell:** Texturwechsel, Aufleuchten, Partikeleffekte

---

### 3. Performanceoptimierung

Basierend auf *Dörner et al., Optimierungstechniken (S.95)*:

- **Polygonreduktion**
- **Level of Detail (LOD)**
- **Texture Baking**
- **Billboards**

---

### 4. Beleuchtung und Sound

**Beleuchtung:**
- Directional Light (Sonne)
- Point Light (Lampe)
- Spot Light (Scheinwerfer)

**Soundgestaltung:**
- Glas: Klirren
- Holz: Knacken
- Schwamm: Quietschen

> Link: [Create 3D Sound Effects – Unity](https://learn.unity.com/pathway/creative-core/unit/creative-core-audio/tutorial/create-3d-sound-effects-3)

---

## Interaktionsdesign & UX

- **Visuelle Hinweise:** Leuchtflächen und Pfeile
- **Direktes Feedback:** Sofortige haptische und visuelle Reaktion
- **Onboarding:** Kurze Einführungsszene mit Tooltips
- **UX-Testing:** A/B-Tests, Likert-Skalen, Beobachtungen

**Fallbacks:**
- Handtracking optional
- Controllersteuerung als Standard

---

## Projektmanagement

| Woche | Aufgabe | Termin |
|:-----|:--------|:------|
| 1 | Konzept & Tool-Einrichtung | 30.04.2025 |
| 2–3 | Erste Prototypen in Unity | 14.05.2025 |
| 4–6 | Integration von Sound & Haptik | 04.06.2025 |
| 7–9 | Usability-Tests & Feinschliff | 25.06.2025 |
| 10 | Abgabe & Abschlusspräsentation | 07.07.2025 |

**Teamaufteilung:**
**Teamaufteilung:**
- A: 3D-Modellierung & Texturierung (Objekt 1, Szene 1), Verantwortung und Lichtgestaltung Szene 1
- B: 3D-Modellierung & Texturierung (Objekt 1, Szene 2), Verantwortung und Lichtgestaltung Szene 2
- C: 3D-Modellierung & Texturierung (Objekt 2, Szene 1), Haptik-Feedback, UI/UX-Design
- D: 3D-Modellierung & Texturierung (Objekt 2, Szene 2), Sound-Design, UI/UX-Design
- A, B, C, D: GitHub-Pflege, Dokumentation, Tests

---

## Risiken & Gegenmaßnahmen

| Risiko | Lösung |
|:------|:-------|
| Asset-Verzögerung | Nutzung freier Quellen, Notfall: Eigenmodellierung |
| Performance-Probleme | Low-Poly-Assets, Beleuchtung optimieren, Testing |
| Unsynchrones Feedback | Exakte Trigger-Logik, Debugging |
| Zeitverzug | Pufferzeiten einplanen, Fokus auf Kernfunktionen |

---

## Wahrnehmungskategorien (Beispiele)

| Material | Textur | Sound | Vibration | Assoziation |
|:--------|:------|:------|:----------|:-----------|
| Holz | rau, gemasert | knarzend | weich, kurz | warm, natürlich |
| Stein | körnig, matt | dumpf, trocken | stark, stoßartig | schwer, kühl |
| Metall | glatt, glänzend | metallisch, hell | vibrierend, lang | kalt, industriell |
| Stoff | weich, diffus | leise, diffus | sanft, kontinuierlich | gemütlich, organisch |

---

## Weiterführende Perspektiven

- Einfluss einzelner Sinne auf Materialerkennung untersuchen
- Einsatz von KI zur adaptiven Feedbacksteuerung
- Gestaltung multimodaler VR-Erfahrungen für Barrierefreiheit
- Vertiefung der Cybersickness-Forschung bei inkongruenten Reizen (vgl. Dörner et al., Kapitel 2.4.7)

---

## Quellen

- Ralf Dörner, Wolfgang Broll, Paul Grimm, Bernhard Jung: *Virtual und Augmented Reality (VR/AR), Grundlagen und Methoden der Virtuellen und Augmentierten Realität*, 2. Auflage, Springer-Verlag, Berlin, 2013.
