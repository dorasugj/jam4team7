using UnityEngine;
using System.Collections;

public class S_Title : BaseScene {
	
	public S_Title()
	{
		Log.d(">>S_Title()");
	}

	public override void Init()
	{
		
	}
	
	public override void Update()
	{
//		Log.d(">>S_Title : Update()");
//		if( InputManager.GetKeyUp( KeyCode.Space ) ) {
//		if( InputManager.GetMouseButtonDown( 0 ) ) {
		if( InputManager.GetKeyDown( KeyCode.Space ) ) {
			Log.d(">>GetKeyDown()");
			//ゲームシーンへ遷移;
			SceneManager.ChangeScene( E_SCENE.GAME );
		}
	}
	
	public override void Destroy()
	{
		
	}
}
