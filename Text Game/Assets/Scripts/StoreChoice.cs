using UnityEngine;
using System.Collections;

public class StoreChoice : MonoBehaviour {

	public void storeChoice(int choice){
		if (choice == 10) 
			StatsManager.pickDoor = false;
		else if (choice == 11)
			StatsManager.pickDoor = true;
		else if (choice == 12)
			StatsManager.empCamera = true;
		else if (choice == 13)
			StatsManager.shootCamera = true;
		else if (choice == 14)
			StatsManager.empCamera = StatsManager.shootCamera = false;
		else if (choice == 15)
			StatsManager.saveData = false;
		else if (choice == 16)
			StatsManager.saveData = true;
		else if (choice == 17)
			StatsManager.killMan = true;
		else if (choice == 18)
			StatsManager.knockOutMan = true;
		else if (choice == 19)
			StatsManager.killMan = StatsManager.knockOutMan = false;
		else if (choice == 20)
			StatsManager.footEscape = true;
		else if (choice == 21)
			StatsManager.swimEscape = StatsManager.footEscape = false;
		else if (choice == 22)
			StatsManager.swimEscape = true;
	}

}
