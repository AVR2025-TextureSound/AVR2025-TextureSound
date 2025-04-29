# TextureSound: Multisensorische Wahrnehmung von identischen VR-Exponaten

## Einleitung

In immersiven VR-Umgebungen spielt die Kombination aus visuellen, auditiven und haptischen Reizen eine zentrale Rolle für das Nutzererlebnis. Dieses Projekt untersucht, wie sich geometrisch identische VR-Objekte (z. B. Holz oder Stein) in ihrer Wahrnehmung unterscheiden, wenn sie unterschiedlich modelliert, vertont und mit haptischem Feedback versehen sind. Das Projekt ist eingebettet in das Seminar Augmented and Virtual Reality (SS 2025) und basiert auf den Grundlagen aus Dörner et al. (vgl. Kapitel 2.3 Multisensorische Wahrnehmung, S. 53) sowie dem Teamkonzept von AVR2025-TextureSound.

Die Wahrnehmung von Objekten und deren Eigenschaften ist ein komplexer Prozess, der nicht nur von den Sinnen, sondern auch von deren Interaktionen abhängt. Besonders in Virtual Reality (VR) ergeben sich neue Herausforderungen und Chancen, die Art und Weise, wie wir die Welt erfahren, zu gestalten. In einer virtuellen Umgebung kommen verschiedene Sinne wie Sehen, Hören und Fühlen zusammen, was die Wahrnehmung von Objekten maßgeblich beeinflusst.

### Wieso nehmen Menschen Dinge unterschiedlich wahr?

Die Wahrnehmung ist nie objektiv – sie wird durch eine Vielzahl von Faktoren gefiltert, darunter:
1. Kognitive Verzerrungen: Unsere Wahrnehmung wird durch persönliche Erfahrungen, kulturelle Hintergründe und emotionale Zustände beeinflusst. So kann eine Person ein Material als glatt empfinden, während eine andere es als rau wahrnimmt.
2. Sinne im Zusammenspiel: Die Sinne sind eng miteinander verknüpft. Ein Geräusch kann beispielsweise die Wahrnehmung einer Textur verändern. Dieses Zusammenspiel wird als crossmodal perception bezeichnet.
3. Kontext: Die gleiche Information wird in verschiedenen Kontexten unterschiedlich wahrgenommen. Ein Geräusch, das in einem ruhigen Raum angenehm ist, kann in einer lärmigen Umgebung störend wirken.



## Hintergrund: Multisensorische Wahrnehmung in VR

### Warum nehmen Menschen Dinge unterschiedlich wahr?

- **Kognitive Verzerrungen:** Persönliche Erfahrungen, Kultur und Emotionen beeinflussen die Wahrnehmung.
- **Crossmodale Wahrnehmung:** Reize eines Sinnes (z. B. Klang) verändern die Wahrnehmung eines anderen Sinnes (z. B. Textur).
- **Kontextabhängigkeit:** Die gleiche Information wird je nach Umgebung anders interpretiert.

Diese Faktoren unterstreichen die Bedeutung eines sorgfältig abgestimmten multisensorischen Designs in VR.



## Ziel und Zweck

### Ziel

Erforschung der Wirkung von Haptik-Komplexität, Klang und Textur auf die Wahrnehmung und Immersion in VR (vgl. Dörner et al., Kapitel 2.3.1 Auditive Wahrnehmung, S. 53; Kapitel 2.3.2 Haptische Wahrnehmung, S. 54). Ziel ist es, zu verstehen, wie das Zusammenspiel dieser Sinneseindrücke das Erlebnis in einer VR-Umgebung beeinflusst und welche Erkenntnisse daraus für das Design von immersiven, realistischen Erlebnissen gewonnen werden können.

### Zweck

Ermittlung, welche Reize am stärksten zur differenzierten Wahrnehmung beitragen, und Ableitung von Empfehlungen für immersive VR-Designs.

### Zielgruppe

- Studierende (UX/HCI, VR-Design)
- Forschende im Bereich Wahrnehmungspsychologie
- Praktiker:innen der VR-Entwicklung

---

## Technische Umsetzung

Basierend auf *Dörner et al., Kapitel 3D-Objekte (S.81–95)*:

- **Modellierung:** Erstellung von Oberflächen- und Festkörpermodellen in **Blender**.
- **Texturierung:** Einsatz von Texturen für realistische Oberflächen (z. B. Bump-, Normal- oder Displacement-Maps).
- **Shader:** Anwendung von Physically Based Rendering (PBR) im Unity-Editor zur realistischen Lichtsimulation.

**Workflow:**
1. Modellierung und Texturierung in Blender
2. Export als `.fbx` oder `.glb`
3. Import in Unity
4. Materialzuweisung mit PBR-Materialien (Albedo, Normal, Metallic etc.)

### 1. 3D-Objekt-Erstellung

3D-Objekte (S. 86)
Grundlegend lassen sich Oberflächen- und Festkörpermodelle unterscheiden.
Oberflächenmodelle: beschreiben die äußere Hülle (engl. Surfaces) eines Objekts
Festkörpermodelle: (engl. Solids) beschreiben das Volumen eines Objekts.

Beispiele:

- Ein Glas wird als hohles Polygonnetz modelliert (z. B. Zylinder mit extrudiertem Inneren). [Glas-Material in Blender 2.8 erstellen – Tutorial 03](https://www.youtube.com/watch?v=GwFJ8iJZnHU)
- Ein Schwamm wird als Low-Poly-Mesh modelliert, um die poröse Struktur zu simulieren.
- Ein Holzbrett wird als Triangle Strip dargestellt, das Texturen (Albedo, Normal) nutzt, um Maserungseffekte zu erzeugen. [Blender 3D Tutorial – Holz zersplittern – Teil 2 (deutsch)](https://www.youtube.com/watch?v=GwFJ8iJZnHU)


## Erscheinungsbild Materialien (S.90)
“Das äußere Erscheinungsbild von Objekten wird vor allem durch deren Materialeigenschaften bzgl. Reflexion und Durchlässigkeit (Transparenz und Transluzenz) von einfallendem Licht charakterisiert.”

### Physikbasiertes Rendering (engl. Physically Based Rendering, PBR)
-**Vorteil:** Realistische und konsistente Ergebnisse.
-**Nachteil:** Hoher Rechenaufwand.

### Beleuchtungsmodell von Phong
- **Vorteil:** Einfach und ressourcenschonend
- **Nachteil:** Unrealistische Darstellung

Der Unity-Editor verwendet Physically Based Rendering (PBR), um realistische Beleuchtungsszenarien präziser zu simulieren.
[Creating Physically Based Materials – Unity Learn](https://learn.unity.com/tutorial/creating-pbr-materials)

### Erscheinungsbild Texturen (S.93)
“Um Oberflächenstrukturen wie Stein, Holz usw. nachzubilden, ohne jedes Detail geometrisch modellieren zu müssen, bedient man sich des „Tricks“ der Texturierung. Texturen sind Rasterbilder, die auf die Objektoberflächen gelegt werden.”

## Realistische Oberflächenstrukturen lassen sich durch folgende Verfahren erzeugen:

### Bump-Mapping:
Simuliert Unebenheiten durch Licht- und Schatteneffekte, ohne die Geometrie des Objekts zu verändern.

### Normal-Mapping:
Manipuliert die Oberflächennormalen mit Hilfe von RGB-Texturen, was eine realistischere Lichtinteraktion ermöglicht.

### Displacement-Mapping:
Verändert die tatsächliche Geometrie des Objekts, wodurch auch die Silhouette beeinflusst wird und höchste Detailgenauigkeit erreicht wird.

Blender ist für alle drei Mapping-Techniken umfassend ausgestattet und ermöglicht deren Anwendung sowohl im Materialsystem als auch direkt auf der Geometrie.
[Understanding Bump Maps and Normal Maps in Blender | Blender Render farm]([https://learn.unity.com/tutorial/introduction-to-shader-graph](https://irendering.net/understanding-bump-maps-and-normal-maps-in-blender/))

### Erscheinungsbild Shader (S.94)
Shader sind Programme, die auf der GPU ausgeführt werden und für die visuelle Darstellung von 3D-Grafiken verantwortlich sind. Sie berechnen Effekte wie Beleuchtung, Texturierung und Schatten in Echtzeit. Es gibt verschiedene Arten von Shadern, darunter Vertex-Shader, die geometrische Transformationen durchführen, und Fragment-Shader, die die Farbe jedes Pixels bestimmen. Shader sind essentiell für die Erstellung realistischer und interaktiver Grafiken in Spielen und Anwendungen.

## Beispiele der Realisierung:

### Displacement-Mapping auf Basis eines Vertex-Shaders
### Bump-Mapping auf Basis eines Fragment-Shaders
Die Unity-Standard-Shader sind speziell darauf ausgelegt, PBR-Materialien darzustellen, indem sie verschiedene Textur-Maps wie Albedo, Normal, Metallic, Smoothness und Ambient Occlusion nutzen.
[Experimentieren mit Shader Graph: Mit weniger mehr erreichen](https://learn.unity.com/tutorial/introduction-to-shader-graph)


## Optimierungstechniken für 3D-Objekte (S.95)
Verbesserung der Rendering-Effizienz durch die Vereinfachung komplexer Objektgeometrien.

### Vereinfachung von Polygonnetzen
- Reduktion der Zahl der Polygone durch Entfernen von Eckpunkten
- Intuitiv an Stellen, an denen die Oberfläche relativ „flach“ ist

### Darstellung unterschiedlicher Detailgrade
- 3D-Objekt in mehreren Detailgraden (Level of Detail, LOD) ablegen
- Abhängig von der Distanz zum Betrachter wird durch das VR-System ein geeigneter Detailgrad ausgewählt z.B. durch schrittweise Vereinfachung eines Polygonnetzes

### Texture Baking
- z.B. wird die Farbinformation der beleuchteten Oberfläche eines hochauflösenden 3D-Modells in eine Textur gespeichert
- „gebackene“ Textur wird dann auf die niedrig aufgelöste, polygonreduzierte Modellversion übertragen

### Billboards (dt. Plakatwand)
- sehr einfache Geometrien wie texturierte Vierecke
- z.B. ein Billboard mit einer Textur eines Baumes und transparentem Hintergrund wird verwendet, um ein detailliertes geometrisches Modell des Baumes zu ersetzen -und so Ressourcen zu sparen

## Objektverhalten (S. 100)
Objekte können ihren Zustand ändern, wenn ein bestimmtes Ereignis eintritt.

### Beispiele:

### Glas
- Fallen und Zerbrechen
- Zustände: Intakt / Zerbrochen
- Ereignis: Das Glas fällt aus einer bestimmten Höhe auf den Boden
- Umsetzung: Wenn das Glas-Objekt mit dem „Boden“-Objekt kollidiert (OnCollisionEnter in Unity), wird das intakte Glas deaktiviert und ein vorgefertigtes „zerbrochenes Glas“-Modell an derselben Stelle aktiviert
- Zustandsautomat: Intakt → [Kollision mit Boden] → Zerbrochen

### Holz
- Aufheben und Ablegen
- Zustände: Liegt auf dem Tisch / Wird gehalten
- Ereignis: Der Nutzer greift das Holzstück (z. B. mit VR-Controller).
- Umsetzung: Beim Drücken des Greif-Buttons wird das Holzstück dem Controller „angeheftet“ (Parenting in Unity). Beim Loslassen wird das Holzstück wieder auf dem Tisch platziert.
- Zustandsautomat: Liegt auf dem Tisch → [Greifen] → Wird gehalten / Wird gehalten → [Loslassen] → Liegt auf dem Tisch

### Schwamm
- Drücken und Loslassen
- Zustände: Entspannt / Komprimiert
- Ereignis: Der Nutzer drückt den Schwamm (z. B. mit Trigger-Button).
- Umsetzung: Beim Drücken des Buttons wird die Skalierung des Schwamm-Objekts in einer Achse reduziert (z. B. y-Achse halbieren). Beim Loslassen des Buttons kehrt die - - Skalierung wieder zur Ausgangsgröße zurück.
- Zustandsautomat: Entspannt → [Drücken] → Komprimiert / Komprimiert → [Loslassen] → Entspannt

## Beleuchtung (S.102)

Um 3D-Objekte überhaupt sehen zu können, sind Lichtquellen unabdingbar.

**Geplante Beleuchtungin unserem Projekt**
- Directional Light (Sonne)
- Point Light (Lampe)
- Spot Light (Scheinwerfer)

> Link: [Create 3D Sound Effects – Unity](https://learn.unity.com/pathway/creative-core/unit/creative-core-audio/tutorial/create-3d-sound-effects-3)

## Theoretische Grundlage:
### Direktionales Licht (engl. Directional Light)
- Simuliert Sonnen- oder Mondlicht
- Beleuchtet alle Objekte aus einer Richtung, unabhängig von deren Entfernung.
- Die Lichtintensität nimmt nicht mit der Entfernung ab.
- *Beispiel:*
Glasobjekte reflektieren und brechen das Sonnenlicht konsistent; Holz und Schwamm erhalten gleichmäßige Schattierungen, die Materialdetails betonen

### Punktlicht (engl. Point Light)
- lokale Lichtquellen wie Lampen, Kerzen oder Glühbirnen
- Lichtquelle befindet sich an einem Punkt im Raum und strahlt in alle Richtungen ab.
- Die Lichtintensität nimmt mit der Entfernung ab (inverse quadratische Abschwächung).
- *Beispiel:*
Ein Glasobjekt nahe einer Lampe wirft Lichtreflexe und Schatten auf die Umgebung

### Scheinwerferlicht (engl. Spot Light)
- Lichtquelle mit definierter Richtung und Kegelwinkel (Lichtkegel)
- Lichtintensität nimmt mit Entfernung und seitlichem Abstand vom Zentrum ab.
- *Beispiel:*
Ein Spot Light auf einen Schwamm hebt die Oberflächenstruktur gezielt hervor
[Unity 3D Lights Tutorial (DIRECTIONAL, SPOT, POINT, AND AREA LIGHTS)](https://www.youtube.com/watch?v=upEt2kQ10fM)

## Sound (S. 103)

**Geplante Soundgestaltung in unserem Projekt:**
- Glas: Klirren
- Holz: Knacken
- Schwamm: Quietschen

## Theoretische Grundlage:
### Sound (S. 103)
Nutzung von Klängen, um Immersion zu fördern, Orientierung zu erleichtern und Emotionen zu verstärken. Sound ist ein essenzieller Bestandteil, um virtuelle Umgebungen realistischer und interaktiver zu gestalten.

### Glas:
Zerbrechen: Klirren oder Splittern bei Kollision mit hoher Geschwindigkeit

### Holz:
Aufprall: Dumpfes "Knacken" oder "Klopfen", abhängig von Masse und Härte.

### Schwamm:
Komprimieren: Quietschen oder gedämpftes "Plop" beim Zusammendrücken

[Create 3D Sound Effects – Unity Learn](https://learn.unity.com/pathway/creative-core/unit/creative-core-audio/tutorial/create-3d-sound-effects-3)


**Vertiefung:**
- [Blender Material Einführung](https://www.youtube.com/watch?v=GwFJ8iJZnHU)
- [Unity Creating Physically Based Materials](https://learn.unity.com/tutorial/creating-pbr-materials)



### Geplante Materialien, Interaktionen und Feedback in unserem Projekt

**Materialien:**
- Glatt: Glas, Metall
- Rau: Holz, Sandpapier
- Weich (optional): Moos, Stoff

**Interaktionen:**
- Greifen, Streichen, Drücken
- Wechsel zwischen zwei Flächen zur direkten Vergleichbarkeit

**Feedback:**
- **Haptisch:** Vibrationsfeedback (einfach vs. komplex) via Unity XR Toolkit und Meta Haptics Studio (vgl. Dörner et al., 2013, S. 212)
- **Auditiv:** materialspezifische Sounds (z. B. Klirren, Knirschen, dumpfe Töne)
- **Visuell:** Texturwechsel, Aufleuchten, Partikeleffekte


### Performanceoptimierung

Basierend auf *Dörner et al., Optimierungstechniken (S.95)*:

- **Polygonreduktion**
- **Level of Detail (LOD)**
- **Texture Baking**
- **Billboards**



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
