/*
* Author: Isaiah Mann
* Description: Reads in a text file as though it was CSV
*/

using UnityEngine;

public class ExampleReadCSV : MonoBehaviour {

	// Reads CSV into a jagged array of strings
	public string[][] Read (TextAsset csvFile) {
		string [][] allStringsByWord;
		string [] allStringsByLine = csvFile.text.Split('\n');
		allStringsByWord = new string [allStringsByLine.Length][];
		for (int i = 0; i < allStringsByLine.Length; i++)  { 
			allStringsByWord[i] = allStringsByLine[i].Split(',');
		}
		return allStringsByWord;
	}

}
