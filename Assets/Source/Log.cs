using UnityEngine;
using System.Collections;

public class Log {
	private static bool m_isDebug = true;	//ログ出力有無;
	
	/*
	 * @brief : ログ出力;
	 * @param : 出力内文言;
	 */
	public static void d( string msg )
	{
		if( !m_isDebug ) { return; }
		Debug.Log( msg );
	}
	
	/*
	 * @brief : エラーログ出力;
	 * @param : 出力文言;
	 */
	public static void e( string msg )
	{
		if( !m_isDebug ) { return; }
		Debug.LogError( msg );
	}

}
