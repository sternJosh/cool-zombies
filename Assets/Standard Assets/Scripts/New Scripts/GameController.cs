using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public Transform mapTile;
	public Transform PC;
	public Transform Z;
	public static GameController controller;
	public PlayerCharacter[] PCs;
	public Zombie[] Zs;
	public CharacterClass[] chars;
	public int turn;
	public Tile[,] map;
	public int numChars;
	
	//for now, the indeces of these should correspond to the indeces of the chars array
	//thus, if a PlayerCharacter is at chars[0], its corresponding prefab should be at PCsPrefabs[0]
	//if a zombie is at chars[1], its corresponding prefab should be at ZsPrefabs[1]
	//this may not be the correct way to handle this, but it should work for now.
	public Transform[] PCsPrefabs;
	public Transform[] ZsPrefabs;
	
	//the dimensions
	public int mapX;   
	public int mapY;
	
	public PlayerCharacter pc;
	public Zombie z;
	public CharacterClass currentChar;
	
//	public GameObject P1;
//	public GameObject Z1;
	
	void Awake()
	{
		controller = this;	
	}
	
	// Use this for initialization
	void Start () {
		
		//load(map, "mapLocationGoesHere");
		//i think eventually we'll load this from a file and generate the map from the array
		mapX = 10; 
		mapY = 10;
		map = new Tile[mapX, mapY];
		for (int i = 0; i < mapX; i++)
		{
			for(int j = 0; j < mapY; j++)
			{
				
				print ("before instantiation");
				mapTile = (Transform)Instantiate (mapTile, new Vector3(i, 0, j), Quaternion.identity);
				Tile theTile = mapTile.GetComponent ("Tile") as Tile;
				theTile.x = i;
				theTile.y = j;
				theTile.transform.renderer.material.color = Color.white;
				map[i, j] = theTile;
				print ("after instantiation");
			}
		}
		
		turn = 0;
		/*
		P1 = GameObject.Find ("P1");
		Z1 = GameObject.Find ("Z1");
		pc = P1.AddComponent("PlayerCharacter") as PlayerCharacter;
		z = Z1.AddComponent ("Zombie") as Zombie;
		*/
		
		PC = (Transform)Instantiate (PC, new Vector3(0, 1, 0), Quaternion.identity);
		PlayerCharacter P1 = PC.GetComponent ("PlayerCharacter") as PlayerCharacter;
		Z = (Transform)Instantiate (Z, new Vector3(4, 1, 4), Quaternion.identity);
		Zombie Z1 = Z.GetComponent ("Zombie") as Zombie;
		//you wouldn't normally hard code these, of course
		P1.setLocation (map[0, 0]);
		Z1.setLocation (map[4,4]);
		map[0,0].setOccupied (P1);
		map[4,4].setOccupied (Z1);

		Gun g = new Gun();
		P1.setWeapon (g);
		
		PCs = new PlayerCharacter[4];
		Zs = new Zombie[4];
		chars = new CharacterClass[2];
		PCs[0] = P1;
		Zs[0] = Z1;
		chars[0] = P1;
		chars[1] = Z1;
		numChars = 2;
		PCsPrefabs = new Transform[numChars];
		ZsPrefabs = new Transform[numChars];
		PCsPrefabs[0] = PC;
		ZsPrefabs[1] = Z;
		
		StartCoroutine (GameManager());
		
		
		
	}
	
	IEnumerator GameManager()
	{
		foreach (CharacterClass c in chars)
		{
			
		currentChar = c;
		print (currentChar.getName () + " is the currentChar");
		yield return StartCoroutine (characterTurn(c));
		
		}
		turn++;
		
		
	}
	
	IEnumerator characterTurn(CharacterClass c)
	{
		
		//actually, this shouldn't be an if statement. just override the functions differently for enemies and PCs
		if (c is PlayerCharacter)
		{
			print (c.getName () + "'s turn");	
			yield return StartCoroutine(c.drawMenu());
				
		}
			
		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void removeCharacter(CharacterClass theChar)
	{
		print(chars.Length + " is the length of chars");
		print (theChar.getName () + " is the name of the char");
		for (int i = 0; i < chars.Length; i++)
		{
			print ("i is: "+ i);
			if (chars[i] == theChar)
			{
				print (chars[i].getName () + " is the name of chars[i]");
				print ("found the char");
				chars[i] = null;	
				//move shit to the left
				for (int j = i + 1; j < chars.Length; j++)
				{
					print ("j is: " + j);
					if (chars[j] != null)
					{
						print ("moving shit left");
						chars[j - 1] = chars[j];	
					}
					else
					{
						print ("no more characters");	
					}
				}
				if (theChar is PlayerCharacter)
				{
					print ("destroying a pc");
					Destroy (PCsPrefabs[i].gameObject);	
				}
				else if (theChar is Zombie)
				{
					print ("destroying a zombie");
					Destroy (ZsPrefabs[i].gameObject);	
				}
				return;
			}
			
			
		}
	}
}
