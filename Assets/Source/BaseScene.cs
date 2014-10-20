using UnityEngine;
using System.Collections;

public abstract class BaseScene {
	
	public enum E_SCENE : int {
		TITLE,		// タイトル;
		GAME,		// ゲーム;
		RESULT,		// リザルト;
		GAMEOVER,	// ゲームオーバー;
		NON,
	}
	
	public abstract void Init();
	public abstract void Update();
	public abstract void Destroy();
}
