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

Die Unity-Standard-Shader sind speziell darauf ausgelegt, PBR-Materialien darzustellen, indem sie verschiedene Textur-Maps wie Albedo, Normal, Metallic, Smoothness und Ambient Occlusion nutzen.<br/> 
**Link:** [Experimentieren mit Shader Graph: Mit weniger mehr erreichen](https://unity.com/de/blog/engine-platform/experimenting-with-shader-graph-doing-more-with-less)

## Erscheinungsbild Texturen (S.93)<br/> 
“Um Oberflächenstrukturen wie Stein, Holz usw. nachzubilden, ohne jedes Detail geometrisch modellieren zu müssen, bedient man sich des „Tricks“ der Texturierung. Texturen sind Rasterbilder, die auf die Objektoberflächen gelegt werden.”<br/>  

Realistische Oberflächenstrukturen lassen sich durch folgende Verfahren erzeugen:

### Bump-Mapping: <br/> 
Simuliert Unebenheiten durch Licht- und Schatteneffekte, ohne die Geometrie des Objekts zu verändern.  
### Normal-Mapping: <br/> 
Manipuliert die Oberflächennormalen mit Hilfe von RGB-Texturen, was eine realistischere Lichtinteraktion ermöglicht.  
### Displacement-Mapping:<br/> 
Verändert die tatsächliche Geometrie des Objekts, wodurch auch die Silhouette beeinflusst wird und höchste Detailgenauigkeit erreicht wird.  

Blender ist für alle drei Mapping-Techniken umfassend ausgestattet und ermöglicht deren Anwendung sowohl im Materialsystem als auch direkt auf der Geometrie.
**Link:** [Understanding Bump Maps and Normal Maps in Blender | Blender Render farm](https://irendering.net/understanding-bump-maps-and-normal-maps-in-blender/)





