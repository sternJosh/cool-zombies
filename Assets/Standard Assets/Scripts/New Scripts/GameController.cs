using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public Transform mapTile;
	public static GameController controller;
	public PlayerCharacter[] PCs;
	public Zombie[] Zs;
	public CharacterClass[] chars;
	public int turn;
	public Tile[,] map;
	public int numChars;
	
	//the dimensions
	public int mapX;   
	public int mapY;
	
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
				map[i, j] = theTile;
				print ("after instantiation");
			}
		}
		
		turn = 0;
		
		P1 = GameObject.Find ("P1");
		Z1 = GameObject.Find ("Z1");
		pc = P1.AddComponent("PlayerCharacter") as PlayerCharacter;
		z = Z1.AddComponent ("Zombie") as Zombie;
		
		//you wouldn't normally hard code these, of course
		pc.setX (0);
		pc.setY (0);
		z.setX (3);
		z.setY (3);
		Gun g = new Gun();
		pc.setWeapon (g);
		
		PCs = new PlayerCharacter[4];
		Zs = new Zombie[4];
		chars = new CharacterClass[2];
		PCs[0] = pc;
		Zs[0] = z;
		chars[0] = pc;
		chars[1] = z;
		numChars = 2;
		
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
		
		
	}
	
	IEnumerator characterTurn(CharacterClass c)
	{
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
	
}
