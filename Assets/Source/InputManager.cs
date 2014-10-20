using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	
	void Start()
	{	
	}
	
	void Update()
	{
	}
	
	/*
	 * @brief  : マウス情報取得(押下中);
	 * @param  : ボタン情報;
	 * @return : true	押下中;
	 * 			 false	非押下中;
	 */
	public static bool GetMouseButton( int button )
	{
		return Input.GetMouseButton( button );
	}
	
	/*
	 * @brief  : マウス情報取得(押下時);
	 * @param  : ボタン情報;
	 * @return : true	押下時;	
	 * 			 false	非押下時;
	 */
	public static bool GetMouseButtonDown( int button )
	{
		return Input.GetMouseButtonDown( button );
	}
	
	/*
	 * @brief  : マウス情報取得(離した時);
	 * @param  : ボタン情報;
	 * @return : true	離した時;
	 * 			 false	非離した時;
	 */
	public static bool GetMouseButtonUp( int button )
	{
		return Input.GetMouseButtonUp( button );		
	}

	/*
	 * @brief  : キー情報取得(押下中);
	 * @param  : キー情報;
	 * @return : true	押下中;
	 * 			 false	非押下中;
	 */
	public static bool GetKey( KeyCode key )
	{
		return Input.GetKey( key );
	}
	
	/*
	 * @brief  : キー情報取得(押下時);
	 * @param  : キー情報;
	 * @return : true	押下時;
	 * 			 false	非押下時;
	 */
	public static bool GetKeyDown( KeyCode key )
	{
		return Input.GetKeyDown( key );
	}
	
	/*
	 * @brief  : キー情報取得(離した時);
	 * @param  : キー情報;
	 * @return : true	離した時;
	 * 			 false	非離した時;
	 */
	public static bool GetKeyUp( KeyCode key )
	{
		return Input.GetKeyDown( key );
	}
}
