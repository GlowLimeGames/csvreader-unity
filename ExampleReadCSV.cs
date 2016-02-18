/*
* Author: Isaiah Mann
* Description: Reads in a text file as though it was CSV
*/

public class ExampleReadCSV:MonoBehaviour {

	public TextAsset theCSV;
	
	// Reads CSV into a jagged array of strings
	public string[][] Read (TextAsset csvFile) {
		
		string [][] allStringsByWord;
		string [] allStringsByLine = theCSV.text.split(‘\n’);

		allStringsByWord = new string [allStringsByLine.Length][];

		for (int i = 0; i < allStringsByLine.Length; i++)  { 
			allStringsByWord[i] = allStringsByLine.split(',');
		}

		return allStringsByWord;
	}

}