using UnityEngine;
using System.Collections;

public class S_Game : BaseScene {
	
	public S_Game()
	{
		Log.d(">>S_Game()");
	}

	public override void Init() {
	
	}
	
	public override void Update () {
		
		if( InputManager.GetKeyDown( KeyCode.Space ) ) {
			//リザルト画面へ遷移;
			SceneManager.ChangeScene( E_SCENE.RESULT );
		}
		
//		//ゲームオーバー画面へ遷移;
//		GameManager.ChangeScene( E_SCENE.GAMEOVER );
	}
	
	public override void Destroy()
	{
		
	}
}
