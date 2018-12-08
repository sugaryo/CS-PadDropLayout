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
            this.dropMainH = new System.Windows.Forms.RadioButton();
            this.dropMainP = new System.Windows.Forms.RadioButton();
            this.dropMainY = new System.Windows.Forms.RadioButton();
            this.dropMainG = new System.Windows.Forms.RadioButton();
            this.dropMainB = new System.Windows.Forms.RadioButton();
            this.dropMainR = new System.Windows.Forms.RadioButton();
            this.groupDropSub = new System.Windows.Forms.GroupBox();
            this.dropSubP = new System.Windows.Forms.RadioButton();
            this.dropSubY = new System.Windows.Forms.RadioButton();
            this.dropSubG = new System.Windows.Forms.RadioButton();
            this.dropSubB = new System.Windows.Forms.RadioButton();
            this.dropSubR = new System.Windows.Forms.RadioButton();
            this.comboLayoutList = new System.Windows.Forms.ComboBox();
            this.checkReverseLR = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dropSubH = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDropLayout)).BeginInit();
            this.groupDropMain.SuspendLayout();
            this.groupDropSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureDropLayout
            // 
            this.pictureDropLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureDropLayout.Location = new System.Drawing.Point(12, 284);
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
            this.groupDropMain.Controls.Add(this.dropMainH);
            this.groupDropMain.Controls.Add(this.dropMainP);
            this.groupDropMain.Controls.Add(this.dropMainY);
            this.groupDropMain.Controls.Add(this.dropMainG);
            this.groupDropMain.Controls.Add(this.dropMainB);
            this.groupDropMain.Controls.Add(this.dropMainR);
            this.groupDropMain.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupDropMain.Location = new System.Drawing.Point(12, 12);
            this.groupDropMain.Name = "groupDropMain";
            this.groupDropMain.Padding = new System.Windows.Forms.Padding(1);
            this.groupDropMain.Size = new System.Drawing.Size(415, 110);
            this.groupDropMain.TabIndex = 0;
            this.groupDropMain.TabStop = false;
            this.groupDropMain.Text = "攻撃：主属性";
            // 
            // dropMainH
            // 
            this.dropMainH.AutoSize = true;
            this.dropMainH.BackColor = System.Drawing.Color.Black;
            this.dropMainH.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropMainH.Image = global::PadDropLayout.Properties.Resources.Heart;
            this.dropMainH.Location = new System.Drawing.Point(339, 22);
            this.dropMainH.Margin = new System.Windows.Forms.Padding(1);
            this.dropMainH.Name = "dropMainH";
            this.dropMainH.Size = new System.Drawing.Size(64, 77);
            this.dropMainH.TabIndex = 1;
            this.dropMainH.UseVisualStyleBackColor = false;
            // 
            // dropMainP
            // 
            this.dropMainP.AutoSize = true;
            this.dropMainP.BackColor = System.Drawing.Color.Black;
            this.dropMainP.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropMainP.Checked = true;
            this.dropMainP.Image = global::PadDropLayout.Properties.Resources.Purple;
            this.dropMainP.Location = new System.Drawing.Point(273, 22);
            this.dropMainP.Margin = new System.Windows.Forms.Padding(1);
            this.dropMainP.Name = "dropMainP";
            this.dropMainP.Size = new System.Drawing.Size(64, 77);
            this.dropMainP.TabIndex = 0;
            this.dropMainP.TabStop = true;
            this.dropMainP.UseVisualStyleBackColor = false;
            // 
            // dropMainY
            // 
            this.dropMainY.AutoSize = true;
            this.dropMainY.BackColor = System.Drawing.Color.Black;
            this.dropMainY.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropMainY.Image = global::PadDropLayout.Properties.Resources.Yellow;
            this.dropMainY.Location = new System.Drawing.Point(207, 22);
            this.dropMainY.Margin = new System.Windows.Forms.Padding(1);
            this.dropMainY.Name = "dropMainY";
            this.dropMainY.Size = new System.Drawing.Size(64, 77);
            this.dropMainY.TabIndex = 0;
            this.dropMainY.UseVisualStyleBackColor = false;
            // 
            // dropMainG
            // 
            this.dropMainG.AutoSize = true;
            this.dropMainG.BackColor = System.Drawing.Color.Black;
            this.dropMainG.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropMainG.Image = global::PadDropLayout.Properties.Resources.Green;
            this.dropMainG.Location = new System.Drawing.Point(141, 22);
            this.dropMainG.Margin = new System.Windows.Forms.Padding(1);
            this.dropMainG.Name = "dropMainG";
            this.dropMainG.Size = new System.Drawing.Size(64, 77);
            this.dropMainG.TabIndex = 0;
            this.dropMainG.UseVisualStyleBackColor = false;
            // 
            // dropMainB
            // 
            this.dropMainB.AutoSize = true;
            this.dropMainB.BackColor = System.Drawing.Color.Black;
            this.dropMainB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropMainB.Image = global::PadDropLayout.Properties.Resources.Blue;
            this.dropMainB.Location = new System.Drawing.Point(75, 22);
            this.dropMainB.Margin = new System.Windows.Forms.Padding(1);
            this.dropMainB.Name = "dropMainB";
            this.dropMainB.Size = new System.Drawing.Size(64, 77);
            this.dropMainB.TabIndex = 0;
            this.dropMainB.UseVisualStyleBackColor = false;
            // 
            // dropMainR
            // 
            this.dropMainR.AutoSize = true;
            this.dropMainR.BackColor = System.Drawing.Color.Black;
            this.dropMainR.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropMainR.Image = global::PadDropLayout.Properties.Resources.Red;
            this.dropMainR.Location = new System.Drawing.Point(9, 22);
            this.dropMainR.Margin = new System.Windows.Forms.Padding(1);
            this.dropMainR.Name = "dropMainR";
            this.dropMainR.Size = new System.Drawing.Size(64, 77);
            this.dropMainR.TabIndex = 0;
            this.dropMainR.UseVisualStyleBackColor = false;
            // 
            // groupDropSub
            // 
            this.groupDropSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDropSub.Controls.Add(this.dropSubH);
            this.groupDropSub.Controls.Add(this.dropSubP);
            this.groupDropSub.Controls.Add(this.dropSubY);
            this.groupDropSub.Controls.Add(this.dropSubG);
            this.groupDropSub.Controls.Add(this.dropSubB);
            this.groupDropSub.Controls.Add(this.dropSubR);
            this.groupDropSub.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupDropSub.Location = new System.Drawing.Point(12, 128);
            this.groupDropSub.Name = "groupDropSub";
            this.groupDropSub.Padding = new System.Windows.Forms.Padding(1);
            this.groupDropSub.Size = new System.Drawing.Size(415, 110);
            this.groupDropSub.TabIndex = 1;
            this.groupDropSub.TabStop = false;
            this.groupDropSub.Text = "攻撃：副属性";
            // 
            // dropSubP
            // 
            this.dropSubP.AutoSize = true;
            this.dropSubP.BackColor = System.Drawing.Color.Black;
            this.dropSubP.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSubP.Image = global::PadDropLayout.Properties.Resources.Purple;
            this.dropSubP.Location = new System.Drawing.Point(275, 22);
            this.dropSubP.Margin = new System.Windows.Forms.Padding(1);
            this.dropSubP.Name = "dropSubP";
            this.dropSubP.Size = new System.Drawing.Size(64, 77);
            this.dropSubP.TabIndex = 0;
            this.dropSubP.UseVisualStyleBackColor = false;
            // 
            // dropSubY
            // 
            this.dropSubY.AutoSize = true;
            this.dropSubY.BackColor = System.Drawing.Color.Black;
            this.dropSubY.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSubY.Checked = true;
            this.dropSubY.Image = global::PadDropLayout.Properties.Resources.Yellow;
            this.dropSubY.Location = new System.Drawing.Point(209, 22);
            this.dropSubY.Margin = new System.Windows.Forms.Padding(1);
            this.dropSubY.Name = "dropSubY";
            this.dropSubY.Size = new System.Drawing.Size(64, 77);
            this.dropSubY.TabIndex = 0;
            this.dropSubY.TabStop = true;
            this.dropSubY.UseVisualStyleBackColor = false;
            // 
            // dropSubG
            // 
            this.dropSubG.AutoSize = true;
            this.dropSubG.BackColor = System.Drawing.Color.Black;
            this.dropSubG.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSubG.Image = global::PadDropLayout.Properties.Resources.Green;
            this.dropSubG.Location = new System.Drawing.Point(143, 22);
            this.dropSubG.Margin = new System.Windows.Forms.Padding(1);
            this.dropSubG.Name = "dropSubG";
            this.dropSubG.Size = new System.Drawing.Size(64, 77);
            this.dropSubG.TabIndex = 0;
            this.dropSubG.UseVisualStyleBackColor = false;
            // 
            // dropSubB
            // 
            this.dropSubB.AutoSize = true;
            this.dropSubB.BackColor = System.Drawing.Color.Black;
            this.dropSubB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSubB.Image = global::PadDropLayout.Properties.Resources.Blue;
            this.dropSubB.Location = new System.Drawing.Point(77, 22);
            this.dropSubB.Margin = new System.Windows.Forms.Padding(1);
            this.dropSubB.Name = "dropSubB";
            this.dropSubB.Size = new System.Drawing.Size(64, 77);
            this.dropSubB.TabIndex = 0;
            this.dropSubB.UseVisualStyleBackColor = false;
            // 
            // dropSubR
            // 
            this.dropSubR.AutoSize = true;
            this.dropSubR.BackColor = System.Drawing.Color.Black;
            this.dropSubR.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSubR.Image = global::PadDropLayout.Properties.Resources.Red;
            this.dropSubR.Location = new System.Drawing.Point(9, 22);
            this.dropSubR.Margin = new System.Windows.Forms.Padding(1);
            this.dropSubR.Name = "dropSubR";
            this.dropSubR.Size = new System.Drawing.Size(64, 77);
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
            this.comboLayoutList.Location = new System.Drawing.Point(12, 248);
            this.comboLayoutList.Name = "comboLayoutList";
            this.comboLayoutList.Size = new System.Drawing.Size(276, 29);
            this.comboLayoutList.TabIndex = 2;
            // 
            // checkReverseLR
            // 
            this.checkReverseLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkReverseLR.AutoSize = true;
            this.checkReverseLR.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkReverseLR.Location = new System.Drawing.Point(334, 250);
            this.checkReverseLR.Name = "checkReverseLR";
            this.checkReverseLR.Size = new System.Drawing.Size(93, 25);
            this.checkReverseLR.TabIndex = 4;
            this.checkReverseLR.Text = "左右反転";
            this.checkReverseLR.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = global::PadDropLayout.Properties.Resources.save;
            this.btnExport.Location = new System.Drawing.Point(292, 248);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(34, 29);
            this.btnExport.TabIndex = 3;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dropSubH
            // 
            this.dropSubH.AutoSize = true;
            this.dropSubH.BackColor = System.Drawing.Color.Black;
            this.dropSubH.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSubH.Image = global::PadDropLayout.Properties.Resources.Heart;
            this.dropSubH.Location = new System.Drawing.Point(341, 22);
            this.dropSubH.Margin = new System.Windows.Forms.Padding(1);
            this.dropSubH.Name = "dropSubH";
            this.dropSubH.Size = new System.Drawing.Size(64, 77);
            this.dropSubH.TabIndex = 2;
            this.dropSubH.UseVisualStyleBackColor = false;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 616);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.checkReverseLR);
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
            this.PerformLayout();

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
		private System.Windows.Forms.CheckBox checkReverseLR;
		private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton dropMainH;
        private System.Windows.Forms.RadioButton dropSubH;
    }
}

