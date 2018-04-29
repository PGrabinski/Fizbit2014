var customSkin : GUISkin;

function OnGUI () {
	GUI.skin=customSkin;
	GUILayout.Box("Symulator DLA");
	GUILayout.TextArea("DLA(ang. diffusion-limited aggregation) jest idealizacją procesu,\n w którym materia w sposób nieodwracalny łączy się\ni formuje kurz, sadzę, dendryty lub inne losowe kształty,\n w przypadku gdy ograniczeniem jest dyfuzja osadzającej się materii.");
	GUILayout.TextArea("Na przedstawionej animacji oglądać możemy tworzący się, \nz identycznych sferycznych cząsteczek, zlepek DLA.");
}