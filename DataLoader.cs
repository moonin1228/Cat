using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class StageData
{

	public int StageID;
	public int ClearReward;

	//public List<RespawnData> respawnData = new List<RespawnData>();
}

public class StageDataLoader 
{
	public List<StageData> stages = new List<StageData>();
	public Dictionary<int, StageData> CreateDic()
	{
		Dictionary<int, StageData> dic = new Dictionary<int, StageData>();

		foreach (StageData stage in stages)
			dic.Add(stage.StageID, stage);

		return dic;
	}

	public bool Validate()
	{
		return true;
	}
}
