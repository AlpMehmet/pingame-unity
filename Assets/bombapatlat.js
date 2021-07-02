#pragma strict
var yazim : GameObject;
var yazi : GameObject;
var obje:GameObject;
public static var kontrol:int=0;


function Start () {


	
}

function Update () {

if(kontrol==1)
{


Destroy(obje);
yazim = GameObject.Instantiate (yazi as GameObject, new Vector3 ((gameObject.transform.localPosition.x)+0.2, (gameObject.transform.localPosition.y)+0.7,-0.3), transform.rotation) as GameObject;

Destroy(yazim,1);
kontrol=0;

Destroy(gameObject);

fuzeolustur.kontrol=1;



}




	
}
