using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XeApp.Game;

static class FileSystemProxy
{
	private static RuntimeSettings m_currentSettings;
	private static Dictionary<string, string> serverFileList;

	static RuntimeSettings CurrentSettings {
		get
		{
			if(m_currentSettings == null)
			{
				m_currentSettings = Resources.Load<RuntimeSettings>("EditorRuntimeSettings");
			}
			return m_currentSettings;
		}
	}

	static public string ConvertPath(string path)
	{
		path = path.Replace("\\", "/");
		if (File.Exists(path))
			return path;
		if (CurrentSettings == null)
			return path;
		InitServerFileList();
		if (path.Contains(UnityEngine.Application.persistentDataPath + "/data") && Directory.Exists(CurrentSettings.DataDirectory))
		{
			path = path.Replace(UnityEngine.Application.persistentDataPath + "/data", CurrentSettings.DataDirectory);
			if (File.Exists(path))
				return path;
		}
		return path;
	}

	public static bool FileExists(string path)
	{
		return File.Exists(ConvertPath(path));
	}

	public static void TryInstallFile(string path, Action<string> onDone)
	{
		string existingPath = ConvertPath(path);
		if (File.Exists(existingPath))
		{
			if (onDone != null)
				onDone(existingPath);
			return;
		}
		if (CurrentSettings != null)
		{
			if(!string.IsNullOrEmpty(CurrentSettings.DataWebServerURL))
			{
				GameManager.Instance.StartCoroutine(TryInstallFileCoroutine(path, onDone));
				return;
			}
		}
		if (onDone != null)
			onDone(path);
	}

	static void InitServerFileList()
	{
		if (serverFileList == null)
		{
			serverFileList = new Dictionary<string, string>();
			string fileList = System.Text.Encoding.UTF8.GetString(System.IO.File.ReadAllBytes(UnityEngine.Application.dataPath + "/../../Data/RequestGetFiles.json"));
			EDOHBJAPLPF_JsonData jsonData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(fileList);
			EDOHBJAPLPF_JsonData fileL = jsonData["files"];
			for (int i = 0; i < fileL.HNBFOAJIIAL_Count; i++)
			{
				string fileName = (string)fileL[i]["file"];
				string localName = GCGNICILKLD.NOCCMAKNLLD.Replace(fileName, "");
				UnityEngine.Debug.Log("Ad file " + localName + " to remote name " + fileName);
				serverFileList.Add(localName, fileName);
			}
		}
	}

	static IEnumerator TryInstallFileCoroutine(string path, Action<string> onDone)
	{
		InitServerFileList();
		path = path.Replace("\\", "/");
		string relativePath = path;
		int pos = path.IndexOf("/android/");
		if (pos >= 0)
			relativePath = path.Substring(pos);
		UnityEngine.Debug.Log("Try install relative path : " + relativePath);
		if (serverFileList.ContainsKey(relativePath))
		{
			string url = CurrentSettings.DataWebServerURL + serverFileList[relativePath];
			UnityEngine.Debug.Log("Try dld from server at " + url);
			WWW dldData = new WWW(url);
			while (!dldData.isDone)
				yield return null;
			if (string.IsNullOrEmpty(dldData.error))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(path));
				File.WriteAllBytes(path, dldData.bytes);
			}
			else
			{
				UnityEngine.Debug.LogError("Dld Error : "+dldData.error);
			}
		}
		if (onDone != null)
			onDone(path);
	}
}
