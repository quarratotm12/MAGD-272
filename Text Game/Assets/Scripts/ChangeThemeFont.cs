using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeThemeFont : MonoBehaviour {
	
	public Font sThemeFont;
	public Font hThemeFont;
	public Text themeText;
	public void smoothThemeFont(){
		//themeFont = (Font)Resources.GetBuiltinResource (typeof(Font), "BARK.ttf");
		themeText.font = sThemeFont;
	}
	

	public void hardcoreThemeFont () {
		themeText.font = hThemeFont;

	}
}
