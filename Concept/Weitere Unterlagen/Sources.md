# Allgemeine Quelle zur Projektumsetzung
Ralf Dörner, Wolfgang Broll, Paul Grimm, Bernhard Jung: Virtual und Augmented Reality (VR/AR), Grundlagen und Methoden der Virtuellen und Augmentierten Realität, 2. Auflage, Berlin, Springer-Verlag GmbH, 2013

## Erstellen von 3D-Objekten (S.81)
### Unterschiedliche Modellierungstechniken:<br/>
- **3D-Modellierungswerkzeuge:**<br/> Mit Software wie z.B Blender können Objekte durch Polygon- oder NURBS-Modellierung gestaltet werden.<br/>
- **Prozedurale Modellierung:**<br/> automatischen Generierung von sehr großen oder sehr komplexen Objekten. Beispiel: automatisierte Erzeugung von 3D-Modellen von Gebäuden oder ganzen Städten<br/>
- **3D-Scans:**<br/> Scanner erfassen reale Objekte und wandeln sie in digitale Modelle um. Beispiel: Laserscanner, die Tiefeninformationen liefern, in Verbindung mit Farbkameras zur Gewinnung der Objekttexturen

Möglicher Workflow für unsere Anwendung:<br/>
- Modellierung und Texturierung der Objekte in BLENDER <br/>
- Import der Objekte in UNITY und Zuweisung von realistischen Materialeigenschaften<br/>
**Link**: Blender Material Einführung: https://www.youtube.com/watch?v=GwFJ8iJZnHU

## 3D-Objekte (S. 86)
Grundlegend lassen sich Oberflächen- und Festkörpermodelle unterscheiden.<br/>
**Oberflächenmodelle**: beschreiben die äußere Hülle (engl. Surfaces) eines Objekts<br/>
**Festkörpermodelle**: (engl. Solids) beschreiben das Volumen eines Objekts.

**Beispiele:**
- Ein Glas wird als hohles Polygonnetz modelliert (z. B. Zylinder mit extrudiertem Inneren).<br/> 
**Link:** [Glas-Material in Blender 2.8 erstellen - Tutorial 03](https://www.youtube.com/watch?v=FwtTcgXgqFI)
- Ein Schwamm wird als Low-Poly-Mesh modelliert, um die poröse Struktur zu simulieren.
- Ein Holzbrett wird als Triangle Strip dargestellt, das Texturen (Albedo, Normal) nutzt, um Maserungseffekte zu erzeugen. <br/>
**Link:** [Blender 3D Tutorial - Holz zersplittern - Teil 2 (deutsch)](https://www.youtube.com/watch?v=DZ_P2xQIqx0)

## Erscheinungsbild Materialien (S.90)
“Das äußere Erscheinungsbild von Objekten wird vor allem durch deren Materialeigenschaften bzgl. Reflexion und Durchlässigkeit (Transparenz und Transluzenz) von einfallendem Licht charakterisiert.”

### Physikbasiertes Rendering (engl. Physically Based Rendering, PBR)<br/> 
- Vorteil: Realistische und konsistente Ergebnisse.<br/> 
- Nachteil: Hoher Rechenaufwand.<br/> 
### Beleuchtungsmodell von Phong<br/> 
- Vorteil: Einfach und ressourcenschonend<br/> 
- Nachteil: Unrealistische Darstellung<br/> 

Der Unity-Editor verwendet Physically Based Rendering (PBR), um realistische Beleuchtungsszenarien präziser zu simulieren.<br/> 
**Link:** [Creating Physically Based Materials - Unity Learn](https://learn.unity.com/tutorial/creating-physically-based-materials#)

## Erscheinungsbild Texturen (S.93)<br/> 
“Um Oberflächenstrukturen wie Stein, Holz usw. nachzubilden, ohne jedes Detail geometrisch modellieren zu müssen, bedient man sich des „Tricks“ der Texturierung. Texturen sind Rasterbilder, die auf die Objektoberflächen gelegt werden.”<br/>  

Realistische Oberflächenstrukturen lassen sich durch folgende Verfahren erzeugen:
### Bump-Mapping: <br/> 
Simuliert Unebenheiten durch Licht- und Schatteneffekte, ohne die Geometrie des Objekts zu verändern.  
### Normal-Mapping: <br/> 
Manipuliert die Oberflächennormalen mit Hilfe von RGB-Texturen, was eine realistischere Lichtinteraktion ermöglicht.  
### Displacement-Mapping:<br/> 
Verändert die tatsächliche Geometrie des Objekts, wodurch auch die Silhouette beeinflusst wird und höchste Detailgenauigkeit erreicht wird.  

Blender ist für alle drei Mapping-Techniken umfassend ausgestattet und ermöglicht deren Anwendung sowohl im Materialsystem als auch direkt auf der Geometrie.<br/> 
**Link:** [Understanding Bump Maps and Normal Maps in Blender | Blender Render farm](https://irendering.net/understanding-bump-maps-and-normal-maps-in-blender/)

## Erscheinungsbild Shader (S.94)<br/> 
Shader sind Programme, die auf der GPU ausgeführt werden und für die visuelle Darstellung von 3D-Grafiken verantwortlich sind. Sie berechnen Effekte wie Beleuchtung, Texturierung und Schatten in Echtzeit. Es gibt verschiedene Arten von Shadern, darunter Vertex-Shader, die geometrische Transformationen durchführen, und Fragment-Shader, die die Farbe jedes Pixels bestimmen. Shader sind essentiell für die Erstellung realistischer und interaktiver Grafiken in Spielen und Anwendungen.

**Beispiele der Realisierung:**<br/> 
- Displacement-Mapping auf Basis eines Vertex-Shaders
- Bump-Mapping auf Basis eines Fragment-Shaders

Die Unity-Standard-Shader sind speziell darauf ausgelegt, PBR-Materialien darzustellen, indem sie verschiedene Textur-Maps wie Albedo, Normal, Metallic, Smoothness und Ambient Occlusion nutzen.<br/> 
**Link:** [Experimentieren mit Shader Graph: Mit weniger mehr erreichen](https://unity.com/de/blog/engine-platform/experimenting-with-shader-graph-doing-more-with-less)

## Optimierungstechniken für 3D-Objekte (S.95)<br/> 
Verbesserung der Rendering-Effizienz durch die Vereinfachung komplexer Objektgeometrien.
### Vereinfachung von Polygonnetzen<br/> 
- Reduktion der Zahl der Polygone durch Entfernen von Eckpunkten
- Intuitiv an Stellen, an denen die Oberfläche relativ „flach“ ist
### Darstellung unterschiedlicher Detailgrade<br/> 
- 3D-Objekt in mehreren Detailgraden (Level of Detail, LOD) ablegen
- Abhängig von der Distanz zum Betrachter wird durch das VR-System ein geeigneter Detailgrad ausgewählt z.B. durch schrittweise Vereinfachung eines Polygonnetzes
### Texture Baking<br/> 
- z.B. wird die Farbinformation der beleuchteten Oberfläche eines hochauflösenden 3D-Modells in eine Textur gespeichert
- „gebackene“ Textur wird dann auf die niedrig aufgelöste, polygonreduzierte Modellversion übertragen
### Billboards (dt. Plakatwand)<br/> 
- sehr einfache Geometrien wie texturierte Vierecke
- z.B. ein Billboard mit einer Textur eines Baumes und transparentem Hintergrund wird verwendet, um ein detailliertes geometrisches Modell des Baumes zu ersetzen -und so Ressourcen zu sparen

## Objektverhalten (S. 100)<br/> 
Objekte können ihren Zustand ändern, wenn ein bestimmtes Ereignis eintritt.

Beispiele:
### Glas<br/> 
- Fallen und Zerbrechen
- Zustände: Intakt / Zerbrochen
- Ereignis: Das Glas fällt aus einer bestimmten Höhe auf den Boden
- Umsetzung: Wenn das Glas-Objekt mit dem „Boden“-Objekt kollidiert (OnCollisionEnter in Unity), wird das intakte Glas deaktiviert und ein vorgefertigtes „zerbrochenes Glas“-Modell an derselben Stelle aktiviert
- Zustandsautomat: Intakt → [Kollision mit Boden] → Zerbrochen
### Holz<br/> 
- Aufheben und Ablegen
- Zustände: Liegt auf dem Tisch / Wird gehalten
- Ereignis: Der Nutzer greift das Holzstück (z. B. mit VR-Controller).
- Umsetzung: Beim Drücken des Greif-Buttons wird das Holzstück dem Controller „angeheftet“ (Parenting in Unity). Beim Loslassen wird das Holzstück wieder auf dem Tisch platziert.
- Zustandsautomat: Liegt auf dem Tisch → [Greifen] → Wird gehalten  / Wird gehalten → [Loslassen] → Liegt auf dem Tisch
### Schwamm<br/> 
- Drücken und Loslassen
- Zustände: Entspannt / Komprimiert
- Ereignis: Der Nutzer drückt den Schwamm (z. B. mit Trigger-Button).
- Umsetzung: Beim Drücken des Buttons wird die Skalierung des Schwamm-Objekts in einer Achse reduziert (z. B. y-Achse halbieren). Beim Loslassen des Buttons kehrt die Skalierung wieder zur Ausgangsgröße zurück.
- Zustandsautomat: Entspannt → [Drücken] → Komprimiert  / Komprimiert → [Loslassen] → Entspannt

## Beleuchtung (S.102)<br/> 
Um 3D-Objekte überhaupt sehen zu können, sind Lichtquellen unabdingbar. <br/> 

### Direktionales Licht (engl. Directional Light)<br/> 
- Simuliert Sonnen- oder Mondlicht
- Beleuchtet alle Objekte aus einer Richtung, unabhängig von deren Entfernung.
- Die Lichtintensität nimmt nicht mit der Entfernung ab.
- **Beispiel:** <br/>Glasobjekte reflektieren und brechen das Sonnenlicht konsistent; Holz und Schwamm erhalten gleichmäßige Schattierungen, die Materialdetails betonen

### Punktlicht (engl. Point Light)<br/> 
- lokale Lichtquellen wie Lampen, Kerzen oder Glühbirnen
- Lichtquelle befindet sich an einem Punkt im Raum und strahlt in alle Richtungen ab.
- Die Lichtintensität nimmt mit der Entfernung ab (inverse quadratische Abschwächung).
- **Beispiel:** <br/>Ein Glasobjekt nahe einer Lampe wirft Lichtreflexe und Schatten auf die Umgebung

### Scheinwerferlicht (engl. Spot Light)<br/> 
- Lichtquelle mit definierter Richtung und Kegelwinkel (Lichtkegel)
- Lichtintensität nimmt mit Entfernung und seitlichem Abstand vom Zentrum ab.
- **Beispiel:** <br/>Ein Spot Light auf einen Schwamm hebt die Oberflächenstruktur gezielt hervor

**Link:** Unity 3D Lights Tutorial (DIRECTIONAL, SPOT, POINT, AND AREA LIGHTS) https://www.youtube.com/watch?v=upEt2kQ10fM

## Sound (S. 103)<br/> 
Nutzung von Klängen, um Immersion zu fördern, Orientierung zu erleichtern und Emotionen zu verstärken. Sound ist ein essenzieller Bestandteil, um virtuelle Umgebungen realistischer und interaktiver zu gestalten.
### Glas:<br/> 
Zerbrechen: Klirren oder Splittern bei Kollision mit hoher Geschwindigkeit
### Holz:<br/> 
Aufprall: Dumpfes "Knacken" oder "Klopfen", abhängig von Masse und Härte.
### Schwamm:<br/>  
Komprimieren: Quietschen oder gedämpftes "Plop" beim Zusammendrücken

**Link:** https://learn.unity.com/pathway/creative-core/unit/creative-core-audio/tutorial/create-3d-sound-effects-3


