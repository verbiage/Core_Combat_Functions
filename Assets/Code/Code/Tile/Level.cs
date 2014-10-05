using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	private int levelWidth;
	private int levelHeight;

	public Transform grassTile;
	public Transform wallTile;
	public Transform enemy;


	private Color[] tileColors;

	public Color grassColor;
	public Color stoneBrickColor;
	public Color spawnPointColor;
	public Color enemyPointColor;

	public Texture2D levelTexture;

	public Entities Player;

	public Entities[] friendlyEntities;

	void Start () {
		levelWidth = levelTexture.width;
		levelHeight = levelTexture.height;
		loadLevel();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void loadLevel()
	{
		tileColors = new Color [levelWidth * levelHeight];
		tileColors = levelTexture.GetPixels();
		for(int y = 0; y < levelHeight; y++)
		{
			for(int x = 0; x < levelWidth; x++)
			{
				if(tileColors[x+y*levelWidth] == stoneBrickColor)
				{
					Instantiate (wallTile, new Vector3(x,y), Quaternion.identity);
				}
				if(tileColors[x+y*levelWidth] == grassColor)
				{
					Instantiate (grassTile,new Vector3(x,y), Quaternion.identity);
				}
				if(tileColors[x+y*levelWidth] == spawnPointColor)
				{
					Instantiate (grassTile,new Vector3(x,y), Quaternion.identity);
					Vector2 pos = new Vector2(x, y);
					Player.transform.position = pos;
					for(int i = 0; 1 < friendlyEntities.Length; i++)
					{
						Vector2 npos = pos;
						npos.x += i + 1;
						friendlyEntities[i].transform.position = npos;
					}

				
				}
				if(tileColors[x+y*levelWidth] == enemyPointColor)
				{
					Instantiate (grassTile,new Vector3(x,y), Quaternion.identity);
					Instantiate (enemy, new Vector3(x,y), Quaternion.identity);
				}
		}
	}
}
}
