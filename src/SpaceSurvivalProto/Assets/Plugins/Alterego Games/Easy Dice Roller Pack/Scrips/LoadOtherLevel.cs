using UnityEngine;
using System.Collections;

public class LoadOtherLevel : MonoBehaviour {

	public void OnLoadLevel() {
		if(Application.loadedLevel == 0){
			Application.LoadLevel("DiceExample2");
		}else{
			Application.LoadLevel("DiceExample1");
		}
	}
}
