using UnityEngine;
using System.Collections;

public class S_GameOver : BaseScene {
	
	public S_GameOver()
	{
		Log.d(">>S_GameOver()");
	}
	
	public override void Init()
	{
	
	}
	
	public override void Update()
	{
		//タイトル画面へ遷移;
		SceneManager.ChangeScene( E_SCENE.TITLE );
	}
	
	public override void Destroy()
	{
		
	}
}
