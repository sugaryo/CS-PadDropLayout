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
                this.dropMainH,
			};
			this.sub = new[] {
				this.dropSubR,
				this.dropSubB,
				this.dropSubG,
				this.dropSubY,
				this.dropSubP,
                this.dropSubH,
			};
		}
		private void ToolForm_Load( object sender, EventArgs e )
		{
			this.pictureDropLayout.Width = LAYOUT_W;
			this.pictureDropLayout.Height = LAYOUT_H;
			this.Icon = PadDropLayout.Properties.Resources.drop;


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

			this.pictureDropLayout.DoubleClick += ( s, a ) => { this.SaveImage(); };
		}
		
		#endregion

		#region DrawDrop
		private void DrawDrop() {
			Image color1 = this.MainDrop;
			Image color2 = this.SubDrop;

			Data data = this.comboLayoutList.SelectedItem as Data;


			this.pictureDropLayout.Image = null;
			this.DrawDrop( this.bmp, color1, color2, data, this.checkReverseLR.Checked );
			this.pictureDropLayout.Image = this.bmp;
		}
		private void DrawDrop( Bitmap bmp, Image color1, Image color2, Data data, bool reverse )
		{
			using ( var g = Graphics.FromImage( bmp ) )
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
		}
		#endregion

		#region SaveImage
		private void SaveImage()
		{
			Data data = this.comboLayoutList.SelectedItem as Data;
			bool reverse = this.checkReverseLR.Checked;

			using ( var dialog = new SaveFileDialog() )
			{
				dialog.FileName = data.Name
						+ ( reverse ? "_左右反転" : "_正順" )
						+ ".png";
				if ( dialog.ShowDialog() == DialogResult.OK )
				{
					string filename = dialog.FileName;

					this.bmp.Save( filename );
				}
			}
		}
		#endregion

		#region Export
		private void btnExport_Click( object sender, EventArgs e )
		{
			using ( var dialog = new FolderBrowserDialog() )
			{
				dialog.Description = "エクスポート先のフォルダを選択して下さい。";
				if ( dialog.ShowDialog() == DialogResult.OK )
				{
					try
					{
						this.Export( dialog.SelectedPath );
						MessageBox.Show( "success." );
					}
					catch ( Exception ex )
					{
						MessageBox.Show( ex.Message );
					}
				}
			}
		}
		private void Export( string folder )
		{
			Image color1 = this.MainDrop;
			Image color2 = this.SubDrop;

			bool[] reverseLR = { false, true };

			using ( Bitmap bmp = new Bitmap( LAYOUT_W, LAYOUT_H ) )
			{
				foreach ( Data data in this.dat )
				{
					foreach ( bool reverse in reverseLR )
					{
						this.DrawDrop( bmp, color1, color2, data, reverse );

						string filename = data.Name
							+ ( reverse ? "_左右反転" : "_正順" )
							+ ".png";

						string filepath = Path.Combine(folder, filename);
						bmp.Save( filepath );
					}
				}
			}
		}
		#endregion
	}
}
