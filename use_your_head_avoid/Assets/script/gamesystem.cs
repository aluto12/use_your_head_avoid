using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamesystem : MonoBehaviour
{
	public GameObject stageselect;
	public GameObject title;

	//�@�X�^�[�g�{�^��������������s����
	public void StartGame()
	{
		title.SetActive(false);
		stageselect.SetActive(true);
		
	}
	//�@�Q�[���I���{�^��������������s����
	public void EndGame()
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_WEBPLAYER
			Application.OpenURL("http://www.yahoo.co.jp/");
		#else
			Application.Quit();
		#endif
	}
	public void returntitle()
	{
		title.SetActive(true);
		stageselect.SetActive(false);

	}
}
