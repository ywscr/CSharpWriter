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
    /// RTF node list , this source code evolution from other software.
	/// </summary>
    [System.Diagnostics.DebuggerDisplay("Count={ Count }")]
    [System.Diagnostics.DebuggerTypeProxy(typeof(RTFInstanceDebugView))]
    public class RTFNodeList : System.Collections.CollectionBase 
	{
		/// <summary>
		/// get node special index
		/// </summary>
		public RTFNode this[ int index ]
		{
			get{ return ( RTFNode ) this.List[ index ] ;}
		}
		/// <summary>
		/// get node special keyword
		/// </summary>
		public RTFNode this[ string KeyWord ]
		{
			get
			{
				foreach( RTFNode node in this )
				{
					if( node.Keyword == KeyWord )
						return node ;
				}
				return null ;
			}
		}
		
		/// <summary>
		/// get node special type
		/// </summary>
		public RTFNode this[ Type t ]
		{
			get
			{
				foreach( RTFNode node in this )
				{
					if( t.Equals( node.GetType()))
						return node ;
				}
				return null;
			}
		}

		/// <summary>
		/// get node's parameter value special keyword, if can not find , return default value.
		/// </summary>
		/// <param name="key">keyword</param>
		/// <param name="DefaultValue">default value</param>
		/// <returns>parameter value</returns>
		public int GetParameter( string key , int DefaultValue )
		{
			foreach( RTFNode node in this )
			{
				if( node.Keyword == key && node.HasParameter )
					return node.Parameter ;
			}
			return DefaultValue ;
		}

		public string Text
		{
			get
			{
				System.Text.StringBuilder myStr = new System.Text.StringBuilder();
				foreach( RTFNode node in this )
				{
					if( node.Type == RTFNodeType.Text )
					{
						myStr.Append( node.Keyword );
					}
					else if( node is RTFNodeGroup )
					{
						string txt = node.Nodes.Text ;
						if( txt != null )
							myStr.Append( txt );
					}
				}
				return myStr.ToString();
			}
		}

		/// <summary>
		/// detect whether exist node special keyword in this list
		/// </summary>
		/// <param name="Key">keyword</param>
		/// <returns>exist or not</returns>
		public bool ContainsKey( string Key )
		{
			return this[ Key ] != null;
		}

		/// <summary>
		/// get index of node in this list
		/// </summary>
		/// <param name="node">node</param>
		/// <returns>index , if node does no in this list , return -1</returns>
		public int IndexOf( RTFNode node )
		{
			return this.List.IndexOf( node );
		}

		internal void AddRange( RTFNodeList list )
		{
			this.InnerList.AddRange( list );
		}
		/// <summary>
		/// add node
		/// </summary>
		/// <param name="node">node</param>
		internal void Add( RTFNode node )
		{
			//node.OwnerList = this ;
			this.List.Add( node );
		}
		/// <summary>
		/// remvoe node
		/// </summary>
		/// <param name="node">node</param>
		internal void Remove( RTFNode node )
		{
			this.Remove( node );
		}
		/// <summary>
		/// insert node
		/// </summary>
		/// <param name="index">index</param>
		/// <param name="node">node</param>
		internal void Insert( int index , RTFNode node )
		{
			this.List.Insert( index , node );
		}
	}
}