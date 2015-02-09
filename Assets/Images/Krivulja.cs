﻿using UnityEngine;
using System.Collections;

public class Krivulja : MonoBehaviour {
	
	public Transform root;
	public Transform rootDaljice, rootDaljiceDesno;
	public GameObject tockaPot;
	public GameObject tockaPotIzbrana;
	Pot vseTocke, kopijaTock;
	int spominPoti;

	void Start(){					//pozicija na krivulji, 0 - 1 0=zacPoint, 1=konPoint
		vseTocke = new Pot (root);	//zgradimo pot
		vseTocke = new Pot (rootDaljice, rootDaljiceDesno, vseTocke);	//v pot dodamo daljico s konstruktorjem ki delo opravi za nas
		vseTocke.narisiVsePoti (tockaPot);
	}

	// Update is called once per frame
	void Update () {

		//bomo dal to v novo skripto za input (ker pač keys, touch...)
		if(Input.GetKeyDown("a")){
			vseTocke.flipKrizisce(1); //flipa prvega
			vseTocke.narisiPot (tockaPotIzbrana);
		}
		else if(Input.GetKeyDown("i")){
			vseTocke.flipKrizisce(2);	//flipa gornjega
			vseTocke.narisiPot (tockaPotIzbrana);
		}
		else if(Input.GetKeyDown("j")){
			vseTocke.flipKrizisce(3);	//flipa spodnjega
			vseTocke.narisiPot (tockaPotIzbrana);
		}
	}
}
