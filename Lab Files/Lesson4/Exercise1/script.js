function pickNewColour()
{
	// find the "mostimportant" div
	var mostImportantDiv = document.getElementById("mostimportant");

	// pick a random colour
	var colours = ['orange', 'yellow', 'purple', 'green'];
	var index = Math.floor(Math.random() * 4); 
	var newColour = colours[index];

	// change the highlight colour
	mostImportantDiv.setAttribute("style", "background-color: " + newColour + ";");
	
}