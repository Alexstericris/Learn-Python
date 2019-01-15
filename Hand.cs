using System.Collections;
using System.Collections.Generic;
using UnitySystem;
[RequireComponent(typeof(Controller))]
public class Hand:MonoBehaviour{

GameObject heldObject;
Controller controller;

void Start(){
controller=GetComponent<Controller>();
}
void Update(){
if(heldObject){

if(controller.controller.GetPressUp(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger)){
heldObject.transform.parent=null;
heldObject.GetComponent<Rigidbody>().isKinematic=true;
heldObject.GetComponent<HeldObject>().parent=null;
heldObject=null;
}

}else{
if(controller.controller.GetPress(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger))){
Collider[] cols=Physics.OverlapSphere(transform.position,o.1f);

foreach(Collider col in cols){
if(heldObject==null&&col.GetComponent<HeldObject>()&&col.GetComponent<HeldObject>().parent==null){
heldObject=col.gameObject;
heldObject.transform.parent=transform;
heldObject.transform.localPosition=Vector3.zero;
heldObject.transform.localRotation=Quaternion.identity;
heldObject.GetComponent<Rigidbod>().isKinematic=true;
heldObject.GetComponent<HeldObject>().parent=controller,
}
}
}
}


}
}
