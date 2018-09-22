using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PadDropLayout
{
	public partial class ToolForm : Form
	{
		private const int DROP_SIZE = 64;
		private const int LAYOUT_W = 6 * DROP_SIZE;
		private const int LAYOUT_H = 5 * DROP_SIZE;

		private readonly Bitmap bmp = new Bitmap( LAYOUT_W, LAYOUT_H );
		
		private readonly Data[] dat;
		private readonly RadioButton[] main;
		private readonly RadioButton[] sub;

		public Image MainDrop {
			get {
				return main.First( x => x.Checked ).Image;
			}
		}
		public Image SubDrop {
			get {
				return sub.First( x => x.Checked ).Image;
			}
		}
		
		#region ctor / Load

		public ToolForm()
		{
			InitializeComponent();

			if ( this.DesignMode )
			{
				this.dat = null;
			}
			else
			{
				string json = File.ReadAllText("dat/layout.dat");
				this.dat = JsonConvert.DeserializeObject<Data[]>( json );

				this.comboLayoutList.DataSource = this.dat;
				this.comboLayoutList.DisplayMember = "Name";
			}

			this.main = new[] {
				this.dropMainR,
				this.dropMainB,
				this.dropMainG,
				this.dropMainY,
				this.dropMainP,
			};
			this.sub = new[] {
				this.dropSubR,
				this.dropSubB,
				this.dropSubG,
				this.dropSubY,
				this.dropSubP,
			};
		}
		private void ToolForm_Load( object sender, EventArgs e )
		{
			this.pictureDropLayout.Width = LAYOUT_W;
			this.pictureDropLayout.Height = LAYOUT_H;


			EventHandler draw = ( s, a ) => { this.DrawDrop(); };

			foreach ( var m in this.main )
			{
				m.CheckedChanged += draw;
			}
			foreach ( var s in this.sub )
			{
				s.CheckedChanged += draw;
			}
			this.comboLayoutList.SelectedIndexChanged += draw; 
			this.checkReverseLR.CheckedChanged += draw;
			this.Shown += draw;
		}
		
		#endregion

		#region DrawDrop
		private void DrawDrop() {
			Image color1 = this.MainDrop;
			Image color2 = this.SubDrop;

			Data data = this.comboLayoutList.SelectedItem as Data;

			DrawDrop( color1, color2, data, this.checkReverseLR.Checked );
		}
		private void DrawDrop( Image color1, Image color2, Data data, bool reverse )
		{
			this.pictureDropLayout.Image = null;

			using ( var g = Graphics.FromImage( this.bmp ) )
			{
				g.Clear( Color.Black );

				string[] lines = data.Layout;
				for ( int y = 0; y < lines.Length; y++ )
				{
					char[] chars = reverse
						? lines[y].Reverse().ToArray()
						: lines[y].ToCharArray();

					for ( int x = 0; x < chars.Length; x++ )
					{
						char c = chars[x];

						Image drop = c == '1'
							? color1
							: color2;

						g.DrawImage( drop, x * DROP_SIZE, y * DROP_SIZE );
					}
				}
			}
			
			this.pictureDropLayout.Image = this.bmp;
		}
		#endregion
	}
}
