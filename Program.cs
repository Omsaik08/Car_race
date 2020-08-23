/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 20/07/2020
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Demo
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	/// [System.ComponentModel.Browsable(false)]
	
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
