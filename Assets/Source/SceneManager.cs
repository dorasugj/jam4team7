using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	private static BaseScene.E_SCENE m_sceneState;	//シーン状態;
	private static BaseScene m_sceneObject;			//シーンオブジェクト;
	
	// Use this for initialization
	void Start () {
		m_sceneState = BaseScene.E_SCENE.TITLE;
		m_sceneObject = new S_Title();				//タイトル画面;
	}
	
	// Update is called once per frame
	void Update () {
		if( m_sceneObject == null ) {
			Log.e(">>Update() : m_sceneOjbect not instance");
			return;
		}
		m_sceneObject.Update();
	}
	
	/*
	 * @brief : 破棄;
	 */
	public static void Destroy()
	{
		m_sceneObject.Destroy();
		m_sceneObject = null;
	}
	
	/*
	 * @brief : シーン切り替え;
	 * @param : シーン情報;
	 */
	public static void ChangeScene( BaseScene.E_SCENE scene )
	{
		if( scene == BaseScene.E_SCENE.NON ) { Log.e(">>ChangeScene() : value faild!!"); }
		
		//シーン削除;
		Destroy();
		
		m_sceneState = scene;
		CreateScene();
	}
	
	/*
	 * @brief : シーン作成;
	 */
	private static void CreateScene()
	{
		if( m_sceneObject != null ) { return; }
		switch( m_sceneState )
		{
			case BaseScene.E_SCENE.TITLE:
				m_sceneObject = new S_Title();
				break;
			case BaseScene.E_SCENE.GAME:
				m_sceneObject = new S_Game();
				break;
			case BaseScene.E_SCENE.RESULT:
				m_sceneObject = new S_Result();
				break;
			case BaseScene.E_SCENE.GAMEOVER:
				m_sceneObject = new S_GameOver();
				break;	
		}
	}
	
	/*
	 * @brief : 破棄;
	 */
	public void Destory()
	{
		if( m_sceneObject == null ) { return; }
		m_sceneObject.Destroy();
		m_sceneObject = null;
	}
	
	/*
	 * @brief : シーン取得;
	 */
	public BaseScene.E_SCENE getScene()
	{
		return m_sceneState;
	}
}
