﻿/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
/*
 * 
 *   DCSoft RTF DOM v1.0
 *   Author : Yuan yong fu.
 *   Email  : yyf9989@hotmail.com
 *   blog site:http://www.cnblogs.com/xdesigner.
 * 
 */


using System;

namespace DCSoft.RTF
{
	/// <summary>
	/// RTF node type
	/// </summary>
	public enum RTFNodeType
	{
		/// <summary>
		/// root
		/// </summary>
		Root ,
		/// <summary>
		/// keyword, etc /marginl
		/// </summary>
		Keyword ,
		/// <summary>
		/// external keyword node , etc. /*/keyword
		/// </summary>
		ExtKeyword ,
		/// <summary>
		/// control
		/// </summary>
		Control ,
		/// <summary>
		/// plain text
		/// </summary>
		Text ,
		/// <summary>
		/// group , etc . { }
		/// </summary>
		Group ,
		/// <summary>
		/// nothing
		/// </summary>
		None
	}
}