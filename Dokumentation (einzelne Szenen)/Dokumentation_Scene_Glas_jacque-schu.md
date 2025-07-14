# Projektdokumentation: AuV_Reality

## Übersicht

Diese Dokumentation beschreibt die praktisch umgesetzten Schritte zur Entwicklung einer XR/VR-Szene ("Glas") in Unity mit Fokus auf physikalische Interaktion, Materialvielfalt und kontextabhängige Info-Anzeige. Sie richtet sich an Entwickler:innen, die einen vollständigen Workflow von der 3D-Modellierung bis zur Interaktion in Unity nachvollziehen oder wiederverwenden möchten.

---

## 1. Erstellung und Vorbereitung der 3D-Objekte in Blender

- **Modellierung:**  
  In Blender wurde jeweils **ein Glas**, **eine Flasche** und **ein Modell des zerbrochenen Glases** erstellt. Die Modelle wurden so angelegt, dass sie in Unity dupliziert und mit verschiedenen Materialien versehen werden können.

- **Export:**  
  Export der Objekte als `.fbx`-Dateien für den problemlosen Import in Unity. Materialeigenschaften aus Blender waren lediglich die Principle BDSF Einstellungen, da UNITY Schwierigkeiten hat, die Eigenschaften aus Blender korrekt umzusetzen.

- **Tutorials (Sources):**
  https://www.youtube.com/watch?v=SReQoIKGgcI
  
---

## 2. Recherche und Auswahl von Texturen & Sounds

- **Texturen:**  
  Für jede Materialvariante (z.B. Glas, Keramik) wurden passende Texturen recherchiert und importiert:
    - Base Color/Albedo
    - Normal Map
    - Roughness/Metallic
    - Ambient Occlusion
    - Height/Displacement (wo sinnvoll)

- **Texturen (Sources):** 
  https://www.cgtrader.com/

- **Sounds:**  
  Für jede Interaktion (z.B. Klirren, dumpfer Aufprall, Splittern) wurden passende Audiodateien recherchiert, bearbeitet und als AudioClips importiert.
  https://pixabay.com/sound-effects/

---

## 3. Import in Unity, Duplizieren und Materialzuweisung

- **Import:**  
  Die `.fbx`-Dateien wurden in Unity importiert und in der Szene platziert.

- **Duplizieren:**  
  Die importierten Grundmodelle wurden in Unity dupliziert, um verschiedene Varianten zu erzeugen:
    - **Glas_1**, **Glas_2**, **Glas_3**
    - **Flasche_1**, **Flasche_2**, **Flasche_3**
  So konnten an jedem Duplikat unterschiedliche Materialien (z.B. Glas, Keramik) und Eigenschaften getestet werden.

- **Materialzuweisung:**  
  Jedem Duplikat wurde das gewünschte Material mit den recherchierten Texturen zugewiesen.
  
### Glas_3 & Flasche_3 (Glas-Material: Glass_Frosted_001)

| Textur-Map                        | Unity Slot (Standard Shader/URP Lit)      | Funktion/Vorteil                                                                                           |
|------------------------------------|-------------------------------------------|------------------------------------------------------------------------------------------------------------|
| Glass_Frosted_001_ambientOcclusion | Occlusion Map                             | Simuliert Schattierung in Vertiefungen, sorgt für mehr Tiefenwirkung und realistischere Lichtverteilung.   |
| Glass_Frosted_001_basecolor        | Albedo/Main Map/Base Map                  | Definiert die Grundfarbe ohne Lichteffekte, sorgt für realistische Farbwiedergabe.                         |
| Glass_Frosted_001_height           | Height Map/Displacement Map (optional)    | Simuliert Oberflächenrelief, erzeugt Tiefe und Details ohne zusätzliche Geometrie.                         |
| Glass_Frosted_001_normal           | Normal Map                                | Täuscht Oberflächenstruktur vor, erzeugt realistische Lichtreflexe und Mikrodetails.                       |

### Glas_2 & Flasche_2 (Keramik-Material: Poliigon_ClayCeramicGlossy_5212)

| Textur-Map                                     | Unity Slot (Standard Shader/URP Lit)      | Funktion/Vorteil                                                                                           |
|------------------------------------------------|-------------------------------------------|------------------------------------------------------------------------------------------------------------|
| Poliigon_ClayCeramicGlossy_5212_BaseColor      | Albedo/Main Map/Base Map                  | Grundfarbe der Keramik, realistische Farbdarstellung.                                                      |
| Poliigon_ClayCeramicGlossy_5212_Displacement   | Height Map/Displacement Map (optional)    | Simuliert Höhenunterschiede, erzeugt mehr Tiefe und Detailreichtum.                                        |
| Poliigon_ClayCeramicGlossy_5212_Metallic       | Metallic Map                              | Steuert Metallanteil, für realistische Reflexionen auf Keramik-Glasur.                                     |
| Poliigon_ClayCeramicGlossy_5212_Normal         | Normal Map                                | Simuliert feine Oberflächenstruktur, sorgt für realistische Lichtbrechung.                                 |
| Poliigon_ClayCeramicGlossy_5212_Roughness      | Smoothness/Roughness Map                  | Steuert Glanz und Rauheit der Oberfläche, beeinflusst Spiegelungen und Lichtverhalten.                     |

### Glas_1 & Flasche_1 (Vorgefertigtes Asset)

| Textur-Map/Slot        | Unity Slot (Standard Shader/URP Lit)      | Funktion/Vorteil                                                                                           |
|------------------------|-------------------------------------------|------------------------------------------------------------------------------------------------------------|
| Surface Options        | Material Inspector                        | Nur Grundparameter wie Farbe, Metallic, Smoothness – keine Detailmaps, weniger Realismus, schneller Setup. |

## **Mehrwert dieser Vorgehensweise**

- **Realismus:** Durch die Nutzung mehrerer Maps (Albedo, Normal, Roughness, etc.) wird das Material deutlich realistischer, da Licht, Farbe, Glanz und Struktur differenziert simuliert werden.
- **Flexibilität:** Einzelne Eigenschaften der Oberfläche lassen sich gezielt anpassen, z. B. nur die Rauheit oder die Farbe, ohne das ganze Material zu verändern.
- **Effizienz:** Detailreiche Oberflächen werden ohne zusätzliche Geometrie möglich (z. B. durch Normal- und Height-Maps), was Performance spart.
- **Physikalische Korrektheit:** Die Maps orientieren sich an PBR-Standards und sorgen für konsistente Darstellung unter verschiedenen Lichtbedingungen.
- **Vergleich:** Vorgefertigte Assets ohne Maps bieten nur einfache Einstellungen und weniger visuelle Tiefe – sie sind schneller einzurichten, aber weniger flexibel und realistisch.

## 4. Zuweisung von Tags und Layers

- **Tags:**  
  Jedes Objekt erhielt einen eindeutigen Tag:
    - `Glas_1`, `Flasche_1`, `Glas_2`, `Flasche_2`, `Glas_3`, `Flasche_3`
  Diese Tags sind zentral für die Steuerung der Interaktionslogik (z.B. Info-Panel, Kollisionserkennung).

- **Layers:**  
  Für jedes Objekt wurde ein gleichnamiger Layer angelegt und zugewiesen:
    - `Glas_1`, `Flasche_1`, `Glas_2`, `Flasche_2`, `Glas_3`, `Flasche_3`
  Dies ist Voraussetzung, um die Kollisionen gezielt über die Layer Collision Matrix zu steuern.

---

## 5. Einstellung der Layer Collision Matrix

- **Öffnen:**  
  Im Menü **Edit > Project Settings > Physics** wurde die **Layer Collision Matrix** bearbeitet.

- **Konfiguration:**  
  Die Matrix wurde so eingestellt, dass **nur die zugehörigen Paare miteinander kollidieren können**:
    - `Glas_1` ↔ `Flasche_1`
    - `Glas_2` ↔ `Flasche_2`
    - `Glas_3` ↔ `Flasche_3`
  Alle anderen Kombinationen wurden deaktiviert.  
  So ist garantiert, dass z.B. `Glas_2` nicht mit `Flasche_3` kollidiert, sondern nur mit `Flasche_2`.

- **Wichtig:**  
  Diese gezielte Kollisionssteuerung funktioniert nur, weil zuvor **Tags und Layer** sauber vergeben wurden.

---

## 6. Physikalische Eigenschaften: Collider & Rigidbody

- **Collider:**  
  - Jedes Objekt erhielt einen passenden Collider (meist BoxCollider).

- **Rigidbody:**  
  - Jedes interaktive Objekt erhielt eine Rigidbody-Komponente, damit physikalische Kräfte und Kollisionen korrekt simuliert werden.
  - **Maßeinstellungen:**  
    - **Mass:** Realistische Werte für Glas und Flasche, um glaubwürdiges Verhalten zu erreichen.
    - **Drag & Angular Drag:** Erhöhte Werte (z.B. Drag 1–3, Angular Drag 1–2), um das schnelle „Wegfliegen“ oder unkontrolliertes Rotieren nach Kollisionen zu verhindern.
    - **Use Gravity:** Aktiviert, damit Objekte natürlich fallen.
    - **Constraints:** Je nach Bedarf einzelne Achsen für Position oder Rotation eingefroren, um z.B. ein Umkippen zu verhindern.
    - **Collision Detection:** Bei schnellen Objekten „Continuous“ eingestellt, um das Durchdringen zu vermeiden.
  - **Is Kinematic:**  
    - **Deaktiviert**, damit das Objekt von der Physik-Engine beeinflusst wird, also auf Kräfte, Kollisionen und Gravitation reagiert.  
    - Ist „Is Kinematic“ aktiviert, ignoriert das Objekt physikalische Kräfte und wird nur noch per Script oder Animation bewegt – es nimmt nicht mehr an der echten Physik-Simulation teil und löst keine Kollisionen aus.  
    - Für realistische Interaktion (Greifen, Werfen, Kollision, Sound) ist deshalb „Is Kinematic“ **ausgeschaltet**.

---

## 7. Interaktion und Haptik

- **XR Grab Interactable:**  
  Jedes Objekt erhielt eine XR Grab Interactable-Komponente, um Greifen, Bewegen und Werfen in VR/XR zu ermöglichen.

  Durch den Wechsel des Movement Types von Instantaneous zu Velocity Tracking in den XR Grab Interactables wurde gezielt das physikalische Verhalten der Objekte    verbessert. Während „Instantaneous“ die Position und Rotation des Objekts direkt und ohne Rücksicht auf die Physik setzt (das Objekt kann dadurch durch andere    Collider hindurchgehen), sorgt „Velocity Tracking“ dafür, dass das Objekt über die Geschwindigkeit und Drehgeschwindigkeit des Rigidbody bewegt wird. Dadurch     bleibt es in vollem Umfang Teil des Physiksystems und kann nicht mehr unnatürlich durch andere Objekte hindurchgleiten

- **Mouse Grab (nur Desktop):**  
  Ein Script ermöglichte das Greifen per Maus. Das Script prüft beim Start, ob ein XR-Gerät aktiv ist, und deaktiviert sich automatisch im VR-Modus.
  <br/>
  *Script:* WS24_25-ProjGrp_IMTECH_AVR2025-TextureSound\Assets\Texture_Sound\Glas\Script\***MouseGrab.cs***

  Da die MetaQuest am Rechner nicht angebunden werden konnte, war das Mouse Grab für die Tests notwendig. Die Ursache lag bei der verwendeten Grafikkarte, die      von MetaQuest nicht unterstützt wurde. Für die Verbindung der Meta Quest 3 mit dem PC werden mindestens eine Nvidia RTX 20-Serie oder eine AMD Radeon RX 6000-    Serie vorausgesetzt. Ältere oder nicht unterstützte GPUs, wie viele Laptop-Grafikkarten oder Intel Arc ohne spezielle Workarounds, verhindern die Nutzung von     Meta Quest Link oder SteamVR. Daher musste das Greifen und Interagieren in der Desktop-Umgebung simuliert werden.

- **Sound- und Effektzuweisung:**  
  Bei Kollisionen (z.B. `Glas_3` mit `Flasche_3`) wird ein Sound abgespielt und ggf. das Mesh/Prefab gewechselt (z.B. zu Splittern). Nach Ablauf einer Zeit kann    das Objekt automatisch in den Ursprungszustand zurückkehren.
  <br/>
  *Script:* WS24_25-ProjGrp_IMTECH_AVR2025-TextureSound\Assets\Texture_Sound\Glas\Script\***GlassCollisionSound.cs***
  <br/>
  *Sounddateien:*
  WS24_25-ProjGrp_IMTECH_AVR2025-TextureSound\Assets\Texture_Sound\Glas\Sound\
  <br/>
  20170101-big-wine-bottle-on-ceramic-floor-14-80677.mp3
  <br/>
  broken-glass-40016.mp3
  <br/>
  glass-clinking-92385.mp3

- **Info-Panel:**  
  Ein Panel mit TextMeshPro zeigt kontextabhängige Informationen an.  
  Die Logik prüft per Raycast (Maus) oder XR-Hover-Event (über die XR Grab Interactable Events), welches Objekt aktuell „gehovered“ wird, und zeigt den passenden   Text an (Zuweisung zentral im Script über Tags).
  <br/>
  *Script:* WS24_25-ProjGrp_IMTECH_AVR2025-TextureSound\Assets\Texture_Sound\Glas\Script\***TooltipByMouse.cs***

---

## 8. Fazit

Die Umsetzung zeigt eine umfassende Auseinandersetzung mit allen Aspekten von 3D-Workflow, Materialsystem, Physik, Interaktion, Tags/Layers, der Layer Collision Matrix und den Besonderheiten von Collider/Rigidbody in Unity.  
Alle Einstellungen und Workflows wurden praktisch erprobt und gezielt so angepasst, dass sie für VR/XR-Interaktionen und realistische Physik in Unity optimal funktionieren.
