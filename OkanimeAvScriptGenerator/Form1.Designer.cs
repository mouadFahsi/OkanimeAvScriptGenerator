namespace OkanimeAvScriptGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Space = new System.Windows.Forms.Label();
            this.btIntro = new System.Windows.Forms.Button();
            this.btLogo = new System.Windows.Forms.Button();
            this.AnimeTitle = new System.Windows.Forms.TextBox();
            this.Uploader = new System.Windows.Forms.TextBox();
            this.Fansub = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btSub = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.EpisodesTree = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.flowLayoutPanel1.Controls.Add(this.Space);
            this.flowLayoutPanel1.Controls.Add(this.btIntro);
            this.flowLayoutPanel1.Controls.Add(this.btLogo);
            this.flowLayoutPanel1.Controls.Add(this.AnimeTitle);
            this.flowLayoutPanel1.Controls.Add(this.Uploader);
            this.flowLayoutPanel1.Controls.Add(this.Fansub);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 73);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(23)))), ((int)(((byte)(59)))));
            this.pictureBox1.Image = global::OkanimeAvScriptGenerator.Properties.Resources.okanimelogo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Space
            // 
            this.Space.Location = new System.Drawing.Point(3, 0);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(138, 73);
            this.Space.TabIndex = 0;
            // 
            // btIntro
            // 
            this.btIntro.FlatAppearance.BorderSize = 0;
            this.btIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIntro.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIntro.ForeColor = System.Drawing.SystemColors.Control;
            this.btIntro.Location = new System.Drawing.Point(144, 0);
            this.btIntro.Margin = new System.Windows.Forms.Padding(0);
            this.btIntro.Name = "btIntro";
            this.btIntro.Size = new System.Drawing.Size(120, 73);
            this.btIntro.TabIndex = 1;
            this.btIntro.Text = "Intro";
            this.btIntro.UseVisualStyleBackColor = true;
            // 
            // btLogo
            // 
            this.btLogo.FlatAppearance.BorderSize = 0;
            this.btLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogo.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.btLogo.Location = new System.Drawing.Point(264, 0);
            this.btLogo.Margin = new System.Windows.Forms.Padding(0);
            this.btLogo.Name = "btLogo";
            this.btLogo.Size = new System.Drawing.Size(120, 73);
            this.btLogo.TabIndex = 2;
            this.btLogo.Text = "Logo";
            this.btLogo.UseVisualStyleBackColor = true;
            // 
            // AnimeTitle
            // 
            this.AnimeTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AnimeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimeTitle.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.AnimeTitle.Location = new System.Drawing.Point(387, 22);
            this.AnimeTitle.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.AnimeTitle.Name = "AnimeTitle";
            this.AnimeTitle.Size = new System.Drawing.Size(144, 27);
            this.AnimeTitle.TabIndex = 4;
            this.AnimeTitle.Text = "AnimeTitle";
            // 
            // Uploader
            // 
            this.Uploader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Uploader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Uploader.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.Uploader.Location = new System.Drawing.Point(537, 22);
            this.Uploader.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.Uploader.Name = "Uploader";
            this.Uploader.Size = new System.Drawing.Size(144, 27);
            this.Uploader.TabIndex = 5;
            this.Uploader.Text = "Uploader Name";
            // 
            // Fansub
            // 
            this.Fansub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Fansub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fansub.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fansub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.Fansub.Location = new System.Drawing.Point(687, 22);
            this.Fansub.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.Fansub.Name = "Fansub";
            this.Fansub.Size = new System.Drawing.Size(144, 27);
            this.Fansub.TabIndex = 6;
            this.Fansub.Text = "Fansuber";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(848, 97);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(120, 415);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 73);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 42);
            this.label4.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.btAdd);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.btSub);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.btRemove);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(728, 97);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(120, 415);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 73);
            this.label1.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btAdd.Location = new System.Drawing.Point(0, 73);
            this.btAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 66);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add RAW/Audio";
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 42);
            this.label2.TabIndex = 5;
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btSub.FlatAppearance.BorderSize = 0;
            this.btSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSub.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.ForeColor = System.Drawing.SystemColors.Control;
            this.btSub.Location = new System.Drawing.Point(0, 181);
            this.btSub.Margin = new System.Windows.Forms.Padding(0);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(120, 66);
            this.btSub.TabIndex = 5;
            this.btSub.Text = "SubFile";
            this.btSub.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 42);
            this.label5.TabIndex = 6;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btRemove.FlatAppearance.BorderSize = 0;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btRemove.Location = new System.Drawing.Point(0, 289);
            this.btRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(120, 66);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            // 
            // EpisodesTree
            // 
            this.EpisodesTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.EpisodesTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EpisodesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EpisodesTree.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpisodesTree.ForeColor = System.Drawing.Color.White;
            this.EpisodesTree.Location = new System.Drawing.Point(0, 97);
            this.EpisodesTree.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.EpisodesTree.Name = "EpisodesTree";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Node4";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Node5";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Node6";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Node1";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Node2";
            this.EpisodesTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.EpisodesTree.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EpisodesTree.Size = new System.Drawing.Size(728, 415);
            this.EpisodesTree.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(968, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EpisodesTree);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "OkanimeScriptGenerator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Space;
        private System.Windows.Forms.Button btIntro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLogo;
        private System.Windows.Forms.TextBox AnimeTitle;
        private System.Windows.Forms.TextBox Uploader;
        private System.Windows.Forms.TextBox Fansub;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.TreeView EpisodesTree;
    }
}

