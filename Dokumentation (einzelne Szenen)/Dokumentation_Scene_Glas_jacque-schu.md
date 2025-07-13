# Projektdokumentation: AuV_Reality

## Übersicht

Diese Dokumentation beschreibt die praktisch umgesetzten Schritte zur Entwicklung einer XR/VR-Szene ("Glas") in Unity mit Fokus auf physikalische Interaktion, Materialvielfalt und kontextabhängige Info-Anzeige. Sie richtet sich an Entwickler:innen, die einen vollständigen Workflow von der 3D-Modellierung bis zur Interaktion in Unity nachvollziehen oder wiederverwenden möchten.

---

## 1. Erstellung und Vorbereitung der 3D-Objekte in Blender

- **Modellierung:**  
  In Blender wurde jeweils nur **ein Glas**, **eine Flasche** und **ein Modell des zerbrochenen Glases** erstellt. Die Modelle wurden so angelegt, dass sie in Unity dupliziert und mit verschiedenen Materialien versehen werden können.

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

---

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

- **Mouse Grab (nur Desktop):**  
  Ein Script ermöglichte das Greifen per Maus. Das Script prüft beim Start, ob ein XR-Gerät aktiv ist, und deaktiviert sich automatisch im VR-Modus.
  <br/>
  *Script:* WS24_25-ProjGrp_IMTECH_AVR2025-TextureSound\Assets\Texture_Sound\Glas\Script\***MouseGrab.cs***

- **Sound- und Effektzuweisung:**  
  Bei Kollisionen (z.B. `Glas_3` mit `Flasche_3`) wird ein Sound abgespielt und ggf. das Mesh/Prefab gewechselt (z.B. zu Splittern). Nach Ablauf einer Zeit kann das Objekt automatisch in den Ursprungszustand zurückkehren.
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
