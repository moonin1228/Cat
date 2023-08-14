using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = UnityEngine.Object;

public class ResourcePoolManager : MonoBehaviour
{
    static ResourcePoolManager _uniqueInstance;
    [SerializeField] GameObject[] _uiPrefabs;
    [SerializeField] GameObject[] _stage1;
    Dictionary<int, EnumManager.stStageInfo> _StageInfoList;

    [SerializeField] AudioClip[] _bgmClips;
    [SerializeField] AudioClip[] _sfxClips;
    [SerializeField] Sprite[] volumeimgs;

    // ���� �ε��� ���ҽ�.
    Dictionary<string, UnityEngine.Object> _resources = new Dictionary<string, UnityEngine.Object>();

    // �񵿱� ���ҽ� ���� ��Ȳ.
    Dictionary<string, AsyncOperationHandle> _handles = new Dictionary<string, AsyncOperationHandle>();
  


    public static ResourcePoolManager _instance
    {
        get 
        { 
            if(_uniqueInstance == null)
            {
               
                GameObject obj = Instantiate(Resources.Load<GameObject>("Prefabs/ResourcesPoolManager"));
                _uniqueInstance = obj.GetComponent<ResourcePoolManager>();
                DontDestroyOnLoad(obj);
                _uniqueInstance.DummyData();

            }
            return _uniqueInstance; 
        }

    }
    public GameObject GetUIPrefabFromType(EnumManager.eUIWindowType wndType)
    {
        return _uiPrefabs[(int)wndType];
    }

    public EnumManager.stStageInfo GetStageInfo(int index)
    {
        return _StageInfoList[index];
    }

    public GameObject GetStage1Furniture(EnumManager.eStage1List funiType)
    {
        return _stage1[(int)funiType];
    }

    public AudioClip GetBgmClipFromType(EnumManager.eBGMClipType type)
    {
        return _bgmClips[(int)type];
    }

    public AudioClip GetSFXClipFromType(EnumManager.eSFXClipType type)
    {
        return _sfxClips[(int)type];
    }
    public Sprite GetSoundImg(EnumManager.eMuteType type)
    {
        return volumeimgs[(int)type];
    }
    public void DummyData() //public�̸� �ȵ� �� 
    {
        _StageInfoList = new Dictionary<int, EnumManager.stStageInfo>();
        // 1.
        EnumManager.stStageInfo info = new EnumManager.stStageInfo("�������� 1", 0 , 3);
        _StageInfoList.Add(1, info);
        // 2.
        info = new EnumManager.stStageInfo("�������� 2", 0, 3);
        _StageInfoList.Add(2, info);
        // 3.
        info = new EnumManager.stStageInfo("�������� 3", 0, 3);
        _StageInfoList.Add(3, info);
        // 4.
        info = new EnumManager.stStageInfo("�������� 4", 0, 3);
        _StageInfoList.Add(4, info);
        // 5.
        info = new EnumManager.stStageInfo("�������� 5", 1, 4);
        _StageInfoList.Add(5, info);

    }


    #region ���ҽ�
    public void LoadAsync<T>(string key, Action<T> callback = null) where T : UnityEngine.Object
    {
        // ĳ�� Ȯ��.
        if (_resources.TryGetValue(key, out Object resource))
        {
            callback?.Invoke(resource as T);
            return;
        }

        // �ε��� ���������� �Ϸ���� �ʾҴٸ�, �ݹ鸸 �߰�.
        if (_handles.ContainsKey(key))
        {
            _handles[key].Completed += (op) => { callback?.Invoke(op.Result as T); };
            return;
        }

        // ���ҽ� �񵿱� �ε� ����.
        _handles.Add(key, Addressables.LoadAssetAsync<T>(key));
      
        _handles[key].Completed += (op) =>
        {
            _resources.Add(key, op.Result as UnityEngine.Object);
            callback?.Invoke(op.Result as T);
            
        };
    }
    #endregion
}
