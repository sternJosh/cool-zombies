using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public static GameController controller;
	public PlayerCharacter[] PCs;
	public Zombie[] Zs;
	public CharacterClass[] chars;
	public int turn;
	
	
	public PlayerCharacter pc;
	public Zombie z;
	public CharacterClass currentChar;
	
	public GameObject P1;
	public GameObject Z1;
	
	void Awake()
	{
		controller = this;	
	}
	
	// Use this for initialization
	void Start () {
		//controller = this;
		turn = 0;
		P1 = GameObject.Find ("P1");
		Z1 = GameObject.Find ("Z1");
		pc = P1.AddComponent("PlayerCharacter") as PlayerCharacter;
		z = Z1.AddComponent ("Zombie") as Zombie;
		PCs = new PlayerCharacter[4];
		Zs = new Zombie[4];
		chars = new CharacterClass[2];
		PCs[0] = pc;
		Zs[0] = z;
		chars[0] = pc;
		chars[1] = z;
		
		StartCoroutine (GameManager());
		
		
		
	}
	
	IEnumerator GameManager()
	{
		foreach (CharacterClass c in chars)
		{
			
		currentChar = c;
		
		StartCoroutine (characterTurn(c));
		
		}
		yield return null;
		
	}
	
	IEnumerator characterTurn(CharacterClass c)
	{
		if (c is PlayerCharacter)
		{
			print (c.getName () + "'s turn");	
			StartCoroutine(c.drawMenu());
			print ("is this getting executed?");
			yield return null;	
		}
			
		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (turn % 2 == 0) //even numbered turn, player goes
		{
			print ("even numbered turn");
			for (int i = 0; i < PCs.Length; i++)
			{
				if (PCs[i] != null)
				{	
					PCs[i].startTurn ();	
				}
			}
			turn++;
		}
		else 
		{
			print ("odd numbered turn");
			for (int i = 0; i < Zs.Length; i++)
			{
				if (Zs[i] != null)
				{
					Zs[i].startTurn();
				}
			}
			turn++;
		}
		*/
	}
	
}
