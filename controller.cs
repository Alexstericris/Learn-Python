using System.Collenctions;
using System.Collections.Generic;
using UnityEngine;

public class Controller:MonoBehaviour{
public SteamVR_Controller.Device controller{
get{
return SteamVR_Controller.Input(GetComponent<SteamVR_TrackedObject>().index);
}
}
}
