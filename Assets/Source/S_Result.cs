using UnityEngine;
using System.Collections;

public class S_Result : BaseScene {
	
	public S_Result()
	{
		Log.d(">>S_Result()");
	}
	
	public override void Init()
	{
	
	}
	
	public override void Update()
	{
		if( InputManager.GetKeyDown( KeyCode.Space ) ) {
			//タイトル画面へ遷移;
			SceneManager.ChangeScene( E_SCENE.TITLE );
		}
	}
	
	public override void Destroy()
	{
		
	}
}
