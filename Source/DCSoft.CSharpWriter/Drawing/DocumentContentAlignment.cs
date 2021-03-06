﻿/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
using System;
//using DCSoft.Common;

namespace DCSoft.Drawing
{
	/// <summary>
	///文档内容对齐方式
	/// </summary>
    //[DocumentComment()]
	public enum DocumentContentAlignment
	{
		/// <summary>
		/// 左对齐
		/// </summary>
		Left = 0 ,
		/// <summary>
		/// 居中对齐
		/// </summary>
		Center = 1 ,
		/// <summary>
		/// 右对齐
		/// </summary>
		Right = 2 , 
		/// <summary>
		/// 两边对齐
		/// </summary>
		Justify = 3 
	}//public enum DocumentContentAlignment
}