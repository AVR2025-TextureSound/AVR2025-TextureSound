# Haptik- und Sounderstellung am Beispiel Metall

## Übersicht
Um die Wechselwirkung von Haptik und Klang am Beispiel von Metall zu untersuchen, wurden im Unity-Projekt TextureSound drei unterschiedliche Objekte erstellt: zwei Metallstangen – eine rostig und rau mit niedriger Smoothness, die andere glatt und glänzend mit hoher Smoothness – sowie eine spiegelnde Triangel mit maximaler Glätte. Um physikalische Interaktionen zu ermöglichen, wurden den Objekten Layer, Box Collider und Rigidbody-Komponenten zugewiesen. Beim Zusammenstoß lösen diese Komponenten spezifische Sounds aus. Dadurch soll die auditive Wahrnehmung angeregt und untersucht werden.


## Modellierung und Materialien
- Erstellung der Modelle als bloßes physikalisches Objekt ohne Materialzuweisung im **Blender**
- Export als `.fbx`-Dateien - diese sind von Unity lesbar und können dort dann weiter bearbeitet werden
- Import in **Unity** und anschließender Ausrichtung, Skalierung und Materialzuweisung
- Anwendung realistischer Texturen von [ambientCG.com](https://ambientcg.com/):
  - **Base Map (Albedo)**, **Metallic Map (Roughness)**, **Normal Map**, **Height Map**


| Objekt          | Oberfläche          | Smoothness | Layer        | Besonderheit                |
|----------------|---------------------|------------|--------------|-----------------------------|
| Metallstange 1 | Rau, rostig         | 0.1        | Metall rough | Realistische Rost-Textur    |
| Metallstange 2 | Glatt, metallisch   | 0.9        | Metall smooth| Metallischer Glanz          |
| Triangel       | Spiegelnd, glatt    | 1.0        | Triangel     | Klangobjekt, reflektierend  |
| Triangelstick  | Spiegelnd, glatt    | 1.0        | Stick        | Klangobjekt, reflektierend  |


## Spezifische Materialangaben: 
## Metallstange rostig: 
[Metall 025](https://ambientcg.com/view?id=Metal025)

| Textur-Datei                   | Unity Slot              | Funktion/Vorteil                                                           |
|-------------------------------|-------------------------|----------------------------------------------------------------------------|
| Eigenes Bild (rostiges Metall) | Albedo/Base Map         | Grundfarbe mit realistischem Rostbild                                     |
| `Metal025_2K-PNG_Displacement` | Height Map              | Erzeugt Oberflächenrelief, simuliert Tiefe ohne zusätzliche Geometrie     |
| `Metal025_2K-PNG_Metalness`    | Metallic Map            | Steuert metallische Lichtreflexion                                        |
| `Metal025_2K-PNG_NormalGL`     | Normal Map              | Simuliert Oberflächenstruktur und Mikrokonturen                           |
| `Metal025_2K-PNG_Roughness`    | Smoothness (invertiert) | Raues Material (Smoothness ≈ 0.1)                                          |


### Metallstange (glatt)
[Metall 049](https://ambientcg.com/view?id=Metal049A)

| Textur-Datei                    | Unity Slot              | Funktion/Vorteil                                                           |
|--------------------------------|-------------------------|----------------------------------------------------------------------------|
| Eigenes Bild (graues Metall)   | Albedo/Base Map         | Neutrale, realistische Metallfarbe                                         |
| `Metal049A_2K-PNG_Displacement`| Height Map (optional)   | Feine Tiefenstruktur                                                       |
| `Metal049A_2K-PNG_Metalness`   | Metallic Map            | Reflektierende metallische Oberfläche                                      |
| `Metal049A_2K-PNG_NormalGL`    | Normal Map              | Mikrodetails für Lichtreflexion                                            |
| `Metal049A_2K-PNG_Roughness`   | Smoothness (invertiert) | Glatte Oberfläche (Smoothness ≈ 0.9)                                       |


### Triangel und Triangelstick
[Metall 049](https://ambientcg.com/view?id=Metal049A)

| Textur-Datei                    | Unity Slot              | Funktion/Vorteil                                                           |
|--------------------------------|-------------------------|----------------------------------------------------------------------------|
| Einfarbig weiß (manuell)       | Albedo/Base Map         | Neutral, ideal für spiegelnden Effekt                                      |
| `Metal049A_2K-PNG_Displacement`| Height Map (optional)   | Leichte Oberflächenstruktur zur Lichtverteilung                           |
| `Metal049A_2K-PNG_Metalness`   | Metallic Map            | Maximaler metallischer Glanz                                               |
| `Metal049A_2K-PNG_NormalGL`    | Normal Map              | Lichtreflexion durch Oberflächenstruktur                                  |
| `Metal049A_2K-PNG_Roughness`   | Smoothness (invertiert) | Spiegelnde Oberfläche (Smoothness = 1.0)                                   |


## Soundauswahl und -zuordnung
Um die Unterschiede in der Klangwahrnehmung beim Zusammenstoß metallischer Objekte zu untersuchen, wurden jedem Objekt spezifische Sounds zugewiesen. Diese werden gezielt über Skripte ausgelöst, die Kollisionen erkennen und die jeweils passende Audiodatei abspielen.
Zur Unterscheidung der Kollisionstypen wurden die Objekte zudem verschiedenen **Layern** zugeordnet. Dadurch lässt sich im Code gezielt festlegen, welche Objektkombinationen wie miteinander interagieren und welcher Sound dabei abgespielt wird.

| Objekt 1          | Objekt 2          | Beschreibung des Sounds                                   |
|------------------|------------------|-----------------------------------------------------------|
| Metallstange     | Metallstange     | Metallisch, laut, leicht scheppernd                       |
| Metallstange     | Triangel         | Dumpfer, hoher metallischer Ton                           |
| Triangel         | Metallstange     | Dumpfer, hoher metallischer Ton (wie oben, umkehrbar)     |
| Triangel         | Triangelstick    | Zarter, vibrierender Triangelsound mit hohem Klang        |


## Reflexion der Umsetzung und Mehrwert
Die Simulation der Haptik erfolgt primär über die Height Map. Diese simuliert Höhenunterschiede auf der Objektoberfläche und erzeugt so ein Gefühl von Tiefe und Struktur – allerdings bleibt dies rein visuell.
Bei Materialien wie Metall, das in der Realität meist relativ glatt ist und nur geringe Unebenheiten aufweist, stößt die Height Map an ihre Grenzen. Um dennoch deutlich unterscheidbare haptische Eindrücke zu erzeugen, wurde entschieden, verschiedene Metallobjekte zu gestalten – mit klar abgesetzten Texturen und Sounds:

- Glatt vs. rau, glänzend vs. matt
- Klanglich hoch, zart vs. laut, scheppernd

Diese Entscheidung ermöglichte es, die Subtilität der Haptik-Wahrnehmung auch in einem visuell und akustisch differenzierten VR-Szenario zu erforschen, ohne unrealistische Materialverzerrungen vorzunehmen.


## Physikalische Interaktion und Steuerung

Um eine glaubwürdige und interaktive VR-Erfahrung zu ermöglichen, wurden allen Objekten im Projekt gezielt physikalische Komponenten und Steuerungsskripte zugewiesen.

### Collider-Komponenten

Jedes Objekt erhielt einen passenden **Collider** (Box-Collider), um die **physische Präsenz im Raum** sicherzustellen. Collider sind notwendig, damit:
- Objekt-Kollisionen erkennen können (z. B. zur Soundauslösung),
- sie sich gegenseitig abstoßen oder blockieren,
- sie gegriffen oder gestoßen werden können.

Ohne Collider wären die Objekte „durchlässig“ und könnten nicht mit der Umgebung interagieren.

### Rigidbody-Komponenten

Alle physikalisch reagierenden Objekte wurden mit einem **Rigidbody** ausgestattet. Dieser ermöglicht es Unity, auf die Objekte physikalische Kräfte (wie Gravitation, Impuls oder Reibung) anzuwenden.

**Verwendete Einstellungen:**
- `Use Gravity`: **Aktiviert**, damit Objekte natürlich nach unten fallen
- `Is Kinematic`: **Deaktiviert**, damit sie vollständig vom Physiksystem gesteuert werden
- `Drag`: verlangsamt lineare Bewegung (z. B. nach einem Wurf)
- `Angular Drag`: reduziert übermäßige Drehbewegungen nach Kollisionen

Diese Konfiguration sorgt für ein **stabiles und realistisches Verhalten** aller interaktiven Objekte im Raum.

### XR Grab Interactable (für VR/XR)

Alle interaktiven Objekte erhielten eine **XR Grab Interactable**-Komponente, um das **Greifen, Bewegen und Werfen** in VR zu ermöglichen.


### Mouse Grab (Desktop-Modus)

Da die **Meta Quest 3** nicht mit dem verwendeten Rechner verbunden werden konnte, wurde ein alternatives Eingabesystem per Maus eingerichtet.

- Script: `MouseGrab.cs`  
  *Pfad: `Assets/Texture_Sound/Glas/Script/MouseGrab.cs`*
- Prüft beim Start automatisch, ob ein XR-Gerät aktiv ist
- Deaktiviert sich im VR-Modus, aktiv nur im Editor/Desktop

**Hintergrund zur Einschränkung:**
Beim Übertragen des Projekts auf die Meta Quest 2 trat ein technischer Fehler auf, der sich nicht beheben ließ. Nach dem Start wurde die Szene zunächst für etwa 1–2 Sekunden korrekt dargestellt, bevor es zu einem Absturz mit grafischen Fehlern kam: Das Bild fror schief ein, Bewegungen waren nicht mehr möglich und die Darstellung blieb unbrauchbar.
