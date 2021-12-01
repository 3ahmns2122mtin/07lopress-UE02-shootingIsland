# UE02 Shooting Island 



### Projektbeschreibung: 
Es wurde ein 2D Spiel entwickelt, in dem man 10 Targets treffen muss, um zu gewinnen. In meiner Version ist im Hintergrund eine Comic-Version von Starry Nights zu sehen, und Van Gogh muss mit einem Pinsel "abgeschossen" werden. Wenn ein schlechtes Target, bei mir ein Ohr, getroffen wird, wird ein Punkt abgezogen.

### Entwicklungsplattform: 
Windows 10, Unity 2020.3.18f1, Visual Studio Version 2019 Community

### Zielplattform: 
WebGL Referenzauflösung (960x600) 

https://3ahmns2122mtin.github.io/07lopress-UE02-shootingIsland/

### Visuelle Einblicke in das Projekt: 
![shootingIsland_skizze_lopress](https://user-images.githubusercontent.com/90834282/136345643-a07cf84f-b872-4428-a32b-c0b50e925842.jpeg)
![shootingIsland_progress01](https://user-images.githubusercontent.com/90834282/136688400-93d0ca4f-03cf-4610-8e25-96b56bb52284.jpeg)
![grafik](https://user-images.githubusercontent.com/90834282/144297278-54dd5c82-0da9-4edc-92c1-f134d7b36b18.png)


### Drittmaterial: 
Pinsel: https://creazilla.com/de/nodes/48894-pinsel-clipart
Van Gogh: https://classroomclipart.com/clipart-view/Clipart/People/van_gogh_jpg.htm
Starry Night: https://pixels.com/featured/van-gogh-starry-night-balux.htm
Plop Sound: https://www.youtube.com/watch?v=oZI4QhyO5ew
Lose Sound: https://www.youtube.com/watch?v=lQ8F0MUXZkc

### Anforderungsliste:  
- [x] WebGL export/upload lauffähig/spielbar
- [x] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
- [x] In Assets Folder MyGame anlegen.
- [x] Den Ordner Scenes in Assets > MyGame ziehen
- [x] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
- [x] Ein Canvas GameObject anlegen.
- [x] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, 
das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
- [x] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
- [x] In Asstets > MyGame den Folder Sprites anlegen. 
- [x] Ein Hintergrund Sprite reinladen.
- [x] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
- [x] Das Image ggf. positionieren und größentechnisch anpassen.
- [x] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen. 
- [x] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag. 
- [x] Das empty GameObject umbenennen in ParentTargets.
- [x] in Assets > MyGame > Prefabs Folder anlegen.
- [x] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
- [x] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen. 
- [x] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die 
- [x] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen. 
- [x] In Assets > MyGame einen neuen Ordner anlegen Scripts
- [x] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio (https://github.com/HTL-SBG/FAQIssuesUnityVSGitGitHub/issues/2).
- [x] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop). 
- [x] Einen 2D Collider als Komponente dem Target hinzufügen. 
- [x] Dem Script Target eine Methode OnMouseDown() hinzufügen. 
- [x] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
- [x] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen. 
- [x] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen. 
- [x] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
- [x] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.
:
- [x] Upload auf GitHub von Assets und ProjectSettings Folder (Version vom 25.11)
- [x] WebGL Build machen in docs Ordner von dem Projektstand 25.11 
- [x] docs Ordner auf GitHub laden
- [x] Eine funktionale Änderung einbauen (zusätzliches Audio, hit Bad Targets --> Decrement by 1, etc.) 
- [x] WebGL Build machen in docs Ordner 
- [x] docs Ordner auf GitHub laden
:
- [x] Readme aktualisieren
- [x] Projekt etwas aufhüpschen


Copyright by lopress
