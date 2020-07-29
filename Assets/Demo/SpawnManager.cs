using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// demo使用，分配大量的活动的角色
/// </summary>
public class SpawnManager : MonoBehaviour {

    #region 字段

    public GameObject spawnPrefab;
    public int gridWidth;
    public int gridHeight;

    #endregion


    #region 方法


    void Start()
    {
        var material = Resources.Load<Material>("Zombie1/Zombie1_AttackZombi.animMap");

        var random = new System.Random(100);

        
        Debug.Log($"material:{material.name}");
        for (int i = 0; i < gridWidth; i++)
        {
            for (int j = 0; j < gridHeight; j++)
            {
                var randi = (float)random.NextDouble() / 2 + 0.5f;
                var randj = (float)random.NextDouble() / 2 + 0.5f;
                GameObject obj = Instantiate<GameObject>(spawnPrefab, new Vector3(i *1+ randi, 0, j *1+ randj), Quaternion.identity);

                if (j == gridHeight - 1)
                {
                    var render = obj.GetComponent<MeshRenderer>();
                    //  Debug.Log($"render.materials[0]:{render.materials[0].name}");
                    render.materials = new Material[1] { material };
                    //  Debug.Log($"render.materials[0]1:{render.materials[0].name}");
                }

            }
        }
    }


    #endregion

}
