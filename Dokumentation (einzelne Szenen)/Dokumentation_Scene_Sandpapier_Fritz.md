## Haptik am Beispiel Sandpapier

Um eine Untersuchung der haptischen Wahrnehmung von Sandpapier zu ermöglichen, wurden drei unterschiedliche Objektgeometrien entwickelt:  
- **Primitive Modellierung**  
- **Polygonale Modellierung in Low-Poly (mit Reduktionen)**
- **Polygonale Modellierung in High-Poly (mit Reduktionen)**

Jede dieser Geometrien wurde mit **vier verschiedenen Textur- bzw. Materialvarianten** kombiniert:
- Einfarbige Materialien
- Fotografische Texturen
- Materialien mit Texture Baking
- Prozedurale Materialien

Diese systematische Kombination erlaubt die gezielte Analyse des Einflusses von Geometrie und Oberflächengestaltung auf die haptische Wahrnehmung im virtuellen Raum.

Weiterhin wurden alle Varianten zusätzlich mit **zwei individuellen Audiospuren** versehen, die durch das reale Schleifen von Sandpapier aufgenommen wurden. Diese akustischen Rückmeldungen unterstützen die multisensorische Erfahrung und fördern die Immersion.

Ergänzend wurde (exemplarisch) ein **interaktiver, informativer Tooltip** implementiert, der beim Auswählen eines Sandpapier-Objekts erscheint und kontextbezogene Informationen zur jeweiligen Variante bereitstellt.

Durch die Kombination aus variabler Geometrie, diverser Materialität, auditiver Rückmeldung und kontextsensitiver Information wird eine differenzierte und wissenschaftlich fundierte Untersuchung der Haptik von Sandpapier in einer virtuellen Umgebung ermöglicht.

---

## Vorbereitung der Komponenten

### Objektgeometrien

Zur Untersuchung der Haptik von Sandpapier wurden drei verschiedene 3D-Objektgeometrien in Blender modelliert und anschließend als **FBX-Dateien** in Unity importiert. Diese Auswahl umfasst sowohl primitive als auch polygonale Modellierungsansätze, um unterschiedliche Detailgrade und Speicheranforderungen abzubilden.

#### Primitive Modellierung (`Sandpapier/Objekte/Sandpapier`)

Das erste Modell basiert auf einer einfachen Rechteck-Grundform (Plane). Diese Geometrie ist extrem speichereffizient (26 KB) und eignet sich als Low-Poly-Variante oder Platzhalter für Prototyping-Zwecke.  
Während der Implementierung in Unity zeigte sich jedoch, dass die Plane sich physikalisch anders verhält als ein Grid:  
- Der Collider musste mit einer Dicke versehen werden, damit das Objekt greifbar ist.  
- Für eine zuverlässige Soundauslösung bei Kollisionen mit anderen Objekten reichte dies nicht aus.  
- Daher wurde letztlich ein **flacher Cube** verwendet, um das gewünschte Interaktionsverhalten zu gewährleisten.

#### Polygonale Modellierung (`Sandpapier/Objekte/Sandpapier_10`)

Die zweite Geometrie ist eine polygonale Modellierung mit erhöhter Komplexität.  
- Ausgangspunkt war eine Plane mit **10 x 10 Vertices**, die anschließend mit einem Randomisierungswert (`Amount: 0,01`) leicht verzerrt wurden, um Unregelmäßigkeiten zu simulieren.  
- Zusätzlich wurden die Kanten leicht durch „proportional editing“ bearbeitet.  
- Das Modell umfasst 100 Vertices und benötigt 31 KB Speicherplatz.  
- Durch diese Modifikation wird eine realistischere Haptik und Optik erzielt, ohne die Performance wesentlich zu beeinträchtigen.

#### High-Poly-Modellierung und Reduktion (`Sandpapier/Objekte/Sandpapier_250_decimate_10_UV`)

Das dritte Modell ist ein exemplarisches **High-Poly-Modell** mit 250 x 250 Stützpunkten (insgesamt 62.500 Vertices).  
- Ziel war die möglichst realistische Nachbildung einer Sandpapieroberfläche.  
- Die hohe Detailtiefe führt zu einer Dateigröße von 697 MB, was für reale Anwendungen zu ressourcenintensiv ist.  
- Zur Optimierung wurden verschiedene Reduktionsalgorithmen eingesetzt:
  - **Subdivision Modifier** (Viewport: 4, Render: 5) und „Shape Smooth“ zur Verfeinerung der Oberfläche.
  - **Decimate Modifier** mit Ratio 0,1 reduzierte die Polygonanzahl auf 10 % des Originals (91 MB).
  - **Smart UV-Unwrapping** (66°, Island Margin 0.03, Correct Aspect: yes) ermöglichte ein effizientes Mapping der Texturen.

Diese Reduktionsschritte machen das Modell vergleichbar und analysierbar, sind aber für den produktiven Einsatz aufgrund der Dateigröße weiterhin nur eingeschränkt praktikabel.

##### Übersichtstabelle der Geometrien

| Name (Blend + FBX)         | Typ                       | Vertices | UV-Unwrapping | Besonderheiten / Modifier                                  | Dateigröße |
|----------------------------|---------------------------|----------|---------------|------------------------------------------------------------|------------|
| Sandpapier                 | Primitive Modellierung    | 4        | -             | Plane, später flacher Cube                                 | 26 KB      |
| Sandpapier_10              | Polygonale Modellierung   | 100      | ja            | Randomisiert (Amount: 0,01), Proportional Editing          | 31 KB      |
| Sandpapier_250             | High-Poly Modellierung    | 62.500   | -             | Randomisiert (Amount: 0,01), Subdivision, Shape Smooth     | 697 MB     |
| Sandpapier_250_decimate_50 | Low-Poly Reduktion        | -        | -             | Decimate (Ratio 0,5)                                       | 407 MB     |
| Sandpapier_250_decimate_10 | Low-Poly Reduktion        | -        | -             | Decimate (Ratio 0,1)                                       | 91 MB      |
| Sandpapier_250_decimate_10_UV | Low-Poly Reduktion    | -        | ja            | Decimate (Ratio 0,1), Smart UV-Unwrapping                  | 91 MB      |

---

### Material und Texturen

Jedes der drei 3D-Objekte wurde im Haptik-Labor mit **vier unterschiedlichen Textur- und Materialvarianten** ausgestattet, um eine systematische Vergleichbarkeit aller Kombinationen zu gewährleisten.

#### 1. Einfache Textur: Farbe

Dem Objekt wird ausschließlich eine einfarbige, braune Materialfarbe zugewiesen.  
Dies bildet die Baseline für den Vergleich und ermöglicht die Untersuchung der reinen Geometrie- und Farbwirkung ohne zusätzliche Oberflächenstruktur.

#### 2. Einfache Textur: Foto  
*(Sandpapier/Materials/Foto_Sandpapier)*

Für diese Variante wurde ein Foto eines realen Sandpapiers (6 MB) aufgenommen und als Basemap auf das 3D-Objekt projiziert.  
Die fotorealistische Texturierung erlaubt die Analyse, wie stark reale Bildinformationen die visuelle und haptische Wahrnehmung beeinflussen.

#### 3. Texture Baking  
*(Sandpapier/Materials/Baked_Sandpapier)*

Hier wurde mittels Texture Baking in Blender eine Textur generiert, die die Oberflächendetails des High-Poly-Modells simuliert.  
- **Low-Poly-Objekt:** UV-unwrapped `Sandpapier_10.fbx`
- **High-Poly-Objekt:** `Sandpapier_250.fbx`
- **Ergebnis:** 3 MB großes PNG, im Shader als non-color-Map eingebunden

Texture Baking ermöglicht es, komplexe Geometrieinformationen auf eine flache Textur zu übertragen und so eine hohe Detailwirkung bei geringem Speicherbedarf zu erzielen.

#### 4. Prozedurales Material  
*(Sandpapier/Materials/Materialien/GroundSand005)*

Für diese Variante wurde ein prozedurales Material aus einer Online-Bibliothek ([ambientCG](https://ambientcg.com/)) verwendet.  
Das Material besteht aus mehreren Maps (Base, Metallic, Normal, Height, Occlusion), die im Unity-Shader kombiniert werden:

- `GroundSand005_AO_2K` (Ambient Occlusion)
- `GroundSand005_BUMP16_2K` (Bump/Normal)
- `GroundSand005_COL_2K` (Color)
- `GroundSand005_DISP16_2K` (Displacement/Height)
- `GroundSand005_NRM_2K` (Normal)
- `GroundSand005_REFL_2K` (Reflection)

Prozedurale Materialien ermöglichen eine besonders flexible und realistische Darstellung von Oberflächen, da sie algorithmisch erzeugt und beliebig skaliert werden können.

---

### Sound

Um die haptische Interaktion mit auditivem Feedback anzureichern, wurden zwei eigene Audioaufnahmen mit Schleifpapier erstellt:  
- **schleifen_kurz.mp3**
- **schleifen_lang.mp3**

Beide Sounds wurden unter realen Bedingungen aufgenommen. Die beiden Audiodateien unterscheiden sich hinsichtlich der Dauer und Intensität des Schleifgeräuschs und werden in der Anwendung nach Dauer der Interaktion eingesetzt, um unterschiedliche Interaktionsarten (z. B. kurzes Antippen vs. längeres Schleifen) realistisch zu simulieren.

---

## Umsetzung in Unity

Die erstellten Komponenten wurden in Unity in einer Szene kombiniert und präsentiert. Um eine möglichst realitätsnahe und wissenschaftlich fundierte Versuchsumgebung zu schaffen, wurden folgende Punkte berücksichtigt.

### Physikalische Komponenten

**Collider (Sandpapier/Script/Collider.cs):**  
Jedem Sandpapierobjekt wurde durch ein eigenes Script ein Collider zugewiesen. Das Script prüft zunächst, ob bereits ein Collider vorhanden ist; falls nicht, wird automatisch ein Box-Collider erzeugt. Diese Vorgehensweise stellt sicher, dass alle Objekte korrekt mit der Physik-Engine von Unity interagieren können und Kollisionen zuverlässig erkannt werden.

**Rigidbody:**  
Zur Simulation physikalischer Eigenschaften wurde jedem Objekt ein Rigidbody hinzugefügt. Die Parameter wurden gezielt auf die Charakteristika von Papier abgestimmt:  
- **Mass:** 0.05 (geringes Gewicht für realistische Fallbewegung)
- **Drag:** 3 (schnelles Abbremsen)
- **Angular Drag:** 2 (verhindert endloses Rotieren)
- **Use Gravity:** aktiviert (Papier wird von Schwerkraft beeinflusst)
- **Interpolate:** Interpolate (flüssige Bewegung)
- **Collision Detection:** Discrete (verhindert Durchrutschen)
- **Constraints:** X/Z-Achsen auf Freeze gesetzt (verhindert unrealistisches Kippen oder Hochklappen)

Diese Einstellungen orientieren sich an bewährten Methoden zur Simulation leichter, dünner Materialien in Echtzeitumgebungen.

### Auditive Komponenten

**Sound (Sandpapier/Script/sound_and_grab.cs):**  
Die beiden aufgenommenen Audiodateien („schleifen_kurz“ und „schleifen_lang“) werden über ein Sound-Script den jeweiligen Objekten zugeordnet. Das Script differenziert zwischen kurzen und langen Kollisionen und spielt die entsprechende Sounddatei ab.  
- Die Schwelle für die Unterscheidung wurde als Variable (0.3 Sekunden) implementiert.
- Eine Audio Source wird zugewiesen, bleibt jedoch initial leer; die Zuweisung und Steuerung erfolgt vollständig über das Script.
- Über einen Tag („Paper“) wird festgelegt, mit welchen Objekten das Schleifgeräusch ausgelöst werden kann.

### Interaktive Komponenten

**Greifen (Sandpapier/Script/sound_and_grab.cs):**  
Das Greifen der Objekte wird über Raycasting und Mausklick realisiert.  
- Beim Mausklick prüft ein Raycast, ob ein Papierobjekt selektiert wurde.
- Bei erfolgreicher Selektion wird ein Flag gesetzt und die gewünschte Zielposition berechnet.
- Während die Maustaste gehalten wird, folgt das Papierobjekt per `Rigidbody.MovePosition` der aktuellen Mausposition und bleibt dabei physikalisch korrekt eingebettet.

### Informationen über das Objekt (Sandpapier/Script/Sandpapier_info.cs)

Um dem Anwender beim Testen der Materialien die Möglichkeit zu geben, die definierten Parameter des Papiers einzusehen, wurde den Objekten des ersten Blocks exemplarisch das Script `Sandpapier_info` zugewiesen. Dieses Script enthält den Informationstext zum jeweiligen Objekt.

Ein leeres Canvas-Element wurde erstellt und mit einem UI-Textfeld ergänzt, in dem das Aussehen des Tooltips definiert wird. Dem Papierobjekt wird das Script sowie der zugehörige Infotext zugewiesen.

Für die Interaktion wurde das XR Grab Interactable aktiviert. Um die physikalischen Eigenschaften nicht zu überschreiben und ein unnatürliches, schräges Stehen des Papiers zu verhindern, wurde der Movement Type auf „Velocity Tracking“ gesetzt.

---

## Weiterentwicklung, Herausforderungen

### Weiterentwicklung

- Für eine realistischere Schleifbewegung kann der lange Sound als Schleife abgespielt und beim Ende der Bewegung gestoppt werden. Aktuell läuft der Sound auch bei Berührung ohne Bewegung zu Ende, was nicht natürlich ist.
- Collider besser definieren, damit der Sound nicht bei "Nähe" ausgeführt wird.
- Das Papier könnte sich leicht biegen beim hochheben.
- Die Implementierung von Tooltips für alle Objekte ist vorgesehen, um die Informationsvermittlung weiter zu verbessern.
  
### Offene Punkte / Fehler
- Einige Papiere sinken nach dem Werfen in den Tisch ein.

### Besondere Herausforderungen

Das Einrichten der VR-Brille stellte eine Herausforderung dar. Im Projekt Sandpapier konntre die Brille eingerichtet werden, jedoch war das freie Laufen oder Fliegen trotz verschiedener Ansätze (z. B. FlyVertical/FlyMovement.cs) nicht möglich. Daher musste der Startpunkt mit Brille direkt vor den Labortisch gelegt werden.

Da die Kameraposition der Brille von der Unity-Startposition abweicht, wurde der Camera Offset individuell angepasst:

- **Sandpapier:** X 6.2, Y 6, Z 5.3
- **Glas:** X 2
- **Metall und Holz:** X -6.7

Diese Anpassungen waren notwendig, um für alle Teammitglieder die VR-Funktionalitäten testen zu können.

---

## Fazit

Die im Projekt eingesetzten Komponenten – bestehend aus unterschiedlichen Objektgeometrien, Texturen und Materialien, Soundelementen sowie UI-Skripten – bilden eine solide Grundlage für die wissenschaftliche Untersuchung haptischer Wahrnehmung in virtuellen Umgebungen. Für eine belastbare und praxisnahe Studie sollten jedoch alle Komponenten hinsichtlich Qualität, Funktionalität und Realismus weiter optimiert werden, um valide und übertragbare Ergebnisse zu erzielen.

Aus persönlicher Sicht zeigt sich, dass insbesondere die Kombination aus gebackener Textur und Low-Poly-Modellierung ein hervorragendes Verhältnis von Darstellungsqualität zu Ressourcenaufwand bietet.

