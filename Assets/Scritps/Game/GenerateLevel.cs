using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    [SerializeField] int mapLength;
    [SerializeField] int mapHeight; 
    [SerializeField] GameObject unbreakableBlock;
    [SerializeField] GameObject emptyBlock;
    const float blockSize = 10f;
    float xPosition;
    float zPosition;
    GameObject[,] instancias;
    void Awake()
    {
        instancias = new GameObject[mapLength, mapHeight];
    }

    void Start()
    {
        GenerateBlocks();
    }

    void Update()
    {
        
    }

    public void GenerateBlocks()
    {
        for(int i = 0; i < mapLength; i++)
        {
            for(int j = 0; j < mapHeight; j++)
            {
                if(i == 0 || i == (mapLength - 1) || j == 0 || j == (mapHeight - 1))
                {
                    instancias[ i, j ] = Instantiate(unbreakableBlock, new Vector3(xPosition, 0f, zPosition), Quaternion.identity, transform);
                }
                else 
                {
                    instancias[ i, j ] = Instantiate(emptyBlock, new Vector3(xPosition, 0f, zPosition), Quaternion.identity, transform);
                }
                xPosition += blockSize;
            }
            zPosition += blockSize;
            xPosition = 0f;
        }
    }
}
