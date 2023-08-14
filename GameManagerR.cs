using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class GameData
{

	public int Stage = 1;

	public int Coin;
	public int Energy;



	public bool BGMOn = true;
	public bool EffectSoundOn = true;

	public List<int> furniture = new List<int>();
	//ShopManager _shopManager = new ShopManager(); //손 봐야할 구간 2

	public void AddFuniture(int f)
	{
		for (int i = 0; i < furniture.Count; i++)
		{
			if (furniture[i] == f)
				return;

		}

		furniture.Add(f);
	}

	public bool FindFuniture(int f)
	{
		for (int i = 0; i < furniture.Count; i++)
		{
			if (furniture[i] == f)
				return true;


		}
		return false;


	}


}
public class GameManagerR
{
	GameData _gameData = new GameData();
	EnumManager.eStage1List _enum = new EnumManager.eStage1List();
	public GameData SaveData
	{
		get
		{
			{ return _gameData; }
		}
		set
		{
			{ _gameData = value; }
		}
	}

	#region Stage
	public int HighestStage
	{
		get { return _gameData.Stage; }
		set { _gameData.Stage = value; }

	}


	#endregion

	#region Player
	public int Coin
	{
		get { return _gameData.Coin; }
		set { _gameData.Coin = value; }
	}

	public int Energy
	{
		get { return _gameData.Energy; }
		set { _gameData.Energy = value; }
	}
	#endregion

	#region Option
	public bool BGMOn
	{
		get { return _gameData.BGMOn; }
		set { _gameData.BGMOn = value; }
	}

	public bool EffectSoundOn
	{
		get { return _gameData.EffectSoundOn; }
		set { _gameData.EffectSoundOn = value; }
	}
	#endregion

	public int CurrentStageGetCoin { get; set; }


	public void GetStageCoin(int stageReward)
	{
		Coin += CurrentStageGetCoin + stageReward;
		CurrentStageGetCoin = 0;
		SaveGame();
	}

	public bool IsLoaded = false;

	public void Init() //json 파일 생성 
	{
		_path = Application.dataPath + "/SaveData.json";
		//_path = Application.persistentDataPath + "/SaveData.json";
		if (LoadGame())
		{
			//_gameData.AddFuniture(EnumManager.eStage1List.f1_러그);
			//_gameData.AddFuniture(EnumManager.eStage1List.f1_쇼파);
			//SaveGame();


			return;
		}

		IsLoaded = true;

		SaveGame();
	}

	public event Action OnPlayerInput;

	public void PlayerInput()
	{
		OnPlayerInput?.Invoke();
	}

	public bool CheckCoin(int coin)
	{
		if (Coin >= coin)
			return true;
		else
			return false;
	}
	public bool SpendCoin(int coin)
	{
		if (CheckCoin(coin))
		{
			Coin -= coin;

			//if (Managers.UI.SceneUI is MainSceneManager)
			//{
			//	(Managers.UI.SceneUI as MainSceneManager).TopUI.Refresh();
			//}
			return true;
		}

		return false;
	}


	public void GetCoin(int coin)  //스테이지 보상 시 쓰면 되는 함수 
	{
		Coin += coin;
		//if (Managers.UI.SceneUI is MainSceneManager)
		//{
		//	(Managers.UI.SceneUI as MainSceneManager).TopUI.Refresh();
		//}
	}

	public bool CheckEnergy(int energy)
	{
		if (Energy >= energy)
			return true;
		else
			return false;
	}

	public bool SpendDia(int energy)
	{
		if (CheckEnergy(energy))
		{
			Energy -= energy;
			//if (Managers.UI.SceneUI is MainSceneManager)
			//{
			//	(Managers.UI.SceneUI as MainSceneManager).TopUI.Refresh();
			//}
			return true;
		}

		return false;
	}

	public void GetEnergy(int energy)
	{
		Energy += energy;
		//if (Managers.UI.SceneUI is MainSceneManager)
		//{
		//	(Managers.UI.SceneUI as MainSceneManager).TopUI.Refresh();
		//}

	}

	public void CheckHighestStage() // 손 볼 구간1
	{


		HighestStage++;
		SaveGame();


	}
	#region Save&Load
	string _path;

	public void SaveGame()
	{
		string jsonStr = JsonUtility.ToJson(Managers.Game.SaveData);
		File.WriteAllText(_path, jsonStr);
	}

	public bool LoadGame()
	{
		if (File.Exists(_path) == false)
			return false;

		string fileStr = File.ReadAllText(_path);
		GameData data = JsonUtility.FromJson<GameData>(fileStr);
		if (data != null)
			Managers.Game.SaveData = data;

		IsLoaded = true;
		return true;
	}
	#endregion
	
}
