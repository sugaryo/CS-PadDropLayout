namespace PadDropLayout
{
	partial class ToolForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureDropLayout = new System.Windows.Forms.PictureBox();
			this.groupDropMain = new System.Windows.Forms.GroupBox();
			this.dropMainR = new System.Windows.Forms.RadioButton();
			this.dropMainB = new System.Windows.Forms.RadioButton();
			this.dropMainG = new System.Windows.Forms.RadioButton();
			this.dropMainY = new System.Windows.Forms.RadioButton();
			this.dropMainP = new System.Windows.Forms.RadioButton();
			this.groupDropSub = new System.Windows.Forms.GroupBox();
			this.dropSubP = new System.Windows.Forms.RadioButton();
			this.dropSubY = new System.Windows.Forms.RadioButton();
			this.dropSubG = new System.Windows.Forms.RadioButton();
			this.dropSubB = new System.Windows.Forms.RadioButton();
			this.dropSubR = new System.Windows.Forms.RadioButton();
			this.comboLayoutList = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureDropLayout)).BeginInit();
			this.groupDropMain.SuspendLayout();
			this.groupDropSub.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureDropLayout
			// 
			this.pictureDropLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureDropLayout.Location = new System.Drawing.Point(12, 273);
			this.pictureDropLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureDropLayout.Name = "pictureDropLayout";
			this.pictureDropLayout.Size = new System.Drawing.Size(200, 200);
			this.pictureDropLayout.TabIndex = 0;
			this.pictureDropLayout.TabStop = false;
			// 
			// groupDropMain
			// 
			this.groupDropMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupDropMain.Controls.Add(this.dropMainP);
			this.groupDropMain.Controls.Add(this.dropMainY);
			this.groupDropMain.Controls.Add(this.dropMainG);
			this.groupDropMain.Controls.Add(this.dropMainB);
			this.groupDropMain.Controls.Add(this.dropMainR);
			this.groupDropMain.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupDropMain.Location = new System.Drawing.Point(14, 16);
			this.groupDropMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupDropMain.Name = "groupDropMain";
			this.groupDropMain.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupDropMain.Size = new System.Drawing.Size(448, 103);
			this.groupDropMain.TabIndex = 1;
			this.groupDropMain.TabStop = false;
			this.groupDropMain.Text = "攻撃：主属性";
			// 
			// dropMainR
			// 
			this.dropMainR.AutoSize = true;
			this.dropMainR.BackColor = System.Drawing.Color.Black;
			this.dropMainR.Image = global::PadDropLayout.Properties.Resources.Red;
			this.dropMainR.Location = new System.Drawing.Point(16, 25);
			this.dropMainR.Name = "dropMainR";
			this.dropMainR.Size = new System.Drawing.Size(78, 64);
			this.dropMainR.TabIndex = 0;
			this.dropMainR.UseVisualStyleBackColor = false;
			// 
			// dropMainB
			// 
			this.dropMainB.AutoSize = true;
			this.dropMainB.BackColor = System.Drawing.Color.Black;
			this.dropMainB.Image = global::PadDropLayout.Properties.Resources.Blue;
			this.dropMainB.Location = new System.Drawing.Point(100, 25);
			this.dropMainB.Name = "dropMainB";
			this.dropMainB.Size = new System.Drawing.Size(78, 64);
			this.dropMainB.TabIndex = 0;
			this.dropMainB.UseVisualStyleBackColor = false;
			// 
			// dropMainG
			// 
			this.dropMainG.AutoSize = true;
			this.dropMainG.BackColor = System.Drawing.Color.Black;
			this.dropMainG.Image = global::PadDropLayout.Properties.Resources.Green;
			this.dropMainG.Location = new System.Drawing.Point(184, 25);
			this.dropMainG.Name = "dropMainG";
			this.dropMainG.Size = new System.Drawing.Size(78, 64);
			this.dropMainG.TabIndex = 0;
			this.dropMainG.UseVisualStyleBackColor = false;
			// 
			// dropMainY
			// 
			this.dropMainY.AutoSize = true;
			this.dropMainY.BackColor = System.Drawing.Color.Black;
			this.dropMainY.Image = global::PadDropLayout.Properties.Resources.Yellow;
			this.dropMainY.Location = new System.Drawing.Point(268, 25);
			this.dropMainY.Name = "dropMainY";
			this.dropMainY.Size = new System.Drawing.Size(78, 64);
			this.dropMainY.TabIndex = 0;
			this.dropMainY.UseVisualStyleBackColor = false;
			// 
			// dropMainP
			// 
			this.dropMainP.AutoSize = true;
			this.dropMainP.BackColor = System.Drawing.Color.Black;
			this.dropMainP.Checked = true;
			this.dropMainP.Image = global::PadDropLayout.Properties.Resources.Purple;
			this.dropMainP.Location = new System.Drawing.Point(352, 25);
			this.dropMainP.Name = "dropMainP";
			this.dropMainP.Size = new System.Drawing.Size(78, 64);
			this.dropMainP.TabIndex = 0;
			this.dropMainP.TabStop = true;
			this.dropMainP.UseVisualStyleBackColor = false;
			// 
			// groupDropSub
			// 
			this.groupDropSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupDropSub.Controls.Add(this.dropSubP);
			this.groupDropSub.Controls.Add(this.dropSubY);
			this.groupDropSub.Controls.Add(this.dropSubG);
			this.groupDropSub.Controls.Add(this.dropSubB);
			this.groupDropSub.Controls.Add(this.dropSubR);
			this.groupDropSub.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupDropSub.Location = new System.Drawing.Point(12, 127);
			this.groupDropSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupDropSub.Name = "groupDropSub";
			this.groupDropSub.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupDropSub.Size = new System.Drawing.Size(450, 103);
			this.groupDropSub.TabIndex = 1;
			this.groupDropSub.TabStop = false;
			this.groupDropSub.Text = "攻撃：副属性";
			// 
			// dropSubP
			// 
			this.dropSubP.AutoSize = true;
			this.dropSubP.BackColor = System.Drawing.Color.Black;
			this.dropSubP.Image = global::PadDropLayout.Properties.Resources.Purple;
			this.dropSubP.Location = new System.Drawing.Point(352, 25);
			this.dropSubP.Name = "dropSubP";
			this.dropSubP.Size = new System.Drawing.Size(78, 64);
			this.dropSubP.TabIndex = 0;
			this.dropSubP.UseVisualStyleBackColor = false;
			// 
			// dropSubY
			// 
			this.dropSubY.AutoSize = true;
			this.dropSubY.BackColor = System.Drawing.Color.Black;
			this.dropSubY.Checked = true;
			this.dropSubY.Image = global::PadDropLayout.Properties.Resources.Yellow;
			this.dropSubY.Location = new System.Drawing.Point(268, 25);
			this.dropSubY.Name = "dropSubY";
			this.dropSubY.Size = new System.Drawing.Size(78, 64);
			this.dropSubY.TabIndex = 0;
			this.dropSubY.TabStop = true;
			this.dropSubY.UseVisualStyleBackColor = false;
			// 
			// dropSubG
			// 
			this.dropSubG.AutoSize = true;
			this.dropSubG.BackColor = System.Drawing.Color.Black;
			this.dropSubG.Image = global::PadDropLayout.Properties.Resources.Green;
			this.dropSubG.Location = new System.Drawing.Point(184, 25);
			this.dropSubG.Name = "dropSubG";
			this.dropSubG.Size = new System.Drawing.Size(78, 64);
			this.dropSubG.TabIndex = 0;
			this.dropSubG.UseVisualStyleBackColor = false;
			// 
			// dropSubB
			// 
			this.dropSubB.AutoSize = true;
			this.dropSubB.BackColor = System.Drawing.Color.Black;
			this.dropSubB.Image = global::PadDropLayout.Properties.Resources.Blue;
			this.dropSubB.Location = new System.Drawing.Point(100, 25);
			this.dropSubB.Name = "dropSubB";
			this.dropSubB.Size = new System.Drawing.Size(78, 64);
			this.dropSubB.TabIndex = 0;
			this.dropSubB.UseVisualStyleBackColor = false;
			// 
			// dropSubR
			// 
			this.dropSubR.AutoSize = true;
			this.dropSubR.BackColor = System.Drawing.Color.Black;
			this.dropSubR.Image = global::PadDropLayout.Properties.Resources.Red;
			this.dropSubR.Location = new System.Drawing.Point(16, 25);
			this.dropSubR.Name = "dropSubR";
			this.dropSubR.Size = new System.Drawing.Size(78, 64);
			this.dropSubR.TabIndex = 0;
			this.dropSubR.UseVisualStyleBackColor = false;
			// 
			// comboLayoutList
			// 
			this.comboLayoutList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboLayoutList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLayoutList.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.comboLayoutList.FormattingEnabled = true;
			this.comboLayoutList.Location = new System.Drawing.Point(12, 237);
			this.comboLayoutList.Name = "comboLayoutList";
			this.comboLayoutList.Size = new System.Drawing.Size(450, 29);
			this.comboLayoutList.TabIndex = 2;
			// 
			// ToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 641);
			this.Controls.Add(this.comboLayoutList);
			this.Controls.Add(this.groupDropSub);
			this.Controls.Add(this.groupDropMain);
			this.Controls.Add(this.pictureDropLayout);
			this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ToolForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "二色陣配置確認";
			this.Load += new System.EventHandler(this.ToolForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureDropLayout)).EndInit();
			this.groupDropMain.ResumeLayout(false);
			this.groupDropMain.PerformLayout();
			this.groupDropSub.ResumeLayout(false);
			this.groupDropSub.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureDropLayout;
		private System.Windows.Forms.GroupBox groupDropMain;
		private System.Windows.Forms.RadioButton dropMainR;
		private System.Windows.Forms.RadioButton dropMainP;
		private System.Windows.Forms.RadioButton dropMainY;
		private System.Windows.Forms.RadioButton dropMainG;
		private System.Windows.Forms.RadioButton dropMainB;
		private System.Windows.Forms.GroupBox groupDropSub;
		private System.Windows.Forms.RadioButton dropSubP;
		private System.Windows.Forms.RadioButton dropSubY;
		private System.Windows.Forms.RadioButton dropSubG;
		private System.Windows.Forms.RadioButton dropSubB;
		private System.Windows.Forms.RadioButton dropSubR;
		private System.Windows.Forms.ComboBox comboLayoutList;
	}
}

