namespace music
{
    partial class Main
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
            this.grid_authors = new System.Windows.Forms.DataGridView();
            this.grid_song = new System.Windows.Forms.DataGridView();
            this.button_authors = new System.Windows.Forms.Button();
            this.button_songs = new System.Windows.Forms.Button();
            this.grid_albums = new System.Windows.Forms.DataGridView();
            this.button_albums = new System.Windows.Forms.Button();
            this.TB_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_smena_akka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ico_author = new System.Windows.Forms.Label();
            this.ico_album = new System.Windows.Forms.Label();
            this.ico_music = new System.Windows.Forms.Label();
            this.lbl_title_main = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_add_albom = new System.Windows.Forms.Button();
            this.button_remoove_albom = new System.Windows.Forms.Button();
            this.button_change_albom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_authors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_albums)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_authors
            // 
            this.grid_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_authors.Location = new System.Drawing.Point(229, 104);
            this.grid_authors.Name = "grid_authors";
            this.grid_authors.RowHeadersWidth = 51;
            this.grid_authors.Size = new System.Drawing.Size(522, 326);
            this.grid_authors.TabIndex = 3;
            this.grid_authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_authors_CellClick);
            // 
            // grid_song
            // 
            this.grid_song.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_song.Location = new System.Drawing.Point(229, 104);
            this.grid_song.Name = "grid_song";
            this.grid_song.RowHeadersWidth = 51;
            this.grid_song.Size = new System.Drawing.Size(522, 326);
            this.grid_song.TabIndex = 4;
            this.grid_song.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_song_CellClick);
            // 
            // button_authors
            // 
            this.button_authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_authors.FlatAppearance.BorderSize = 0;
            this.button_authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_authors.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_authors.Location = new System.Drawing.Point(6, 266);
            this.button_authors.Name = "button_authors";
            this.button_authors.Size = new System.Drawing.Size(173, 28);
            this.button_authors.TabIndex = 5;
            this.button_authors.Text = "              Исполнители";
            this.button_authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_authors.UseVisualStyleBackColor = false;
            this.button_authors.Click += new System.EventHandler(this.button_authors_Click);
            this.button_authors.MouseEnter += new System.EventHandler(this.button_authors_MouseEnter);
            this.button_authors.MouseLeave += new System.EventHandler(this.button_authors_MouseLeave);
            // 
            // button_songs
            // 
            this.button_songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_songs.FlatAppearance.BorderSize = 0;
            this.button_songs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(215)))));
            this.button_songs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_songs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_songs.Location = new System.Drawing.Point(6, 206);
            this.button_songs.Name = "button_songs";
            this.button_songs.Size = new System.Drawing.Size(173, 28);
            this.button_songs.TabIndex = 6;
            this.button_songs.Text = "              Треки";
            this.button_songs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_songs.UseVisualStyleBackColor = false;
            this.button_songs.Click += new System.EventHandler(this.button_songs_Click);
            this.button_songs.MouseEnter += new System.EventHandler(this.button_songs_MouseEnter);
            this.button_songs.MouseLeave += new System.EventHandler(this.button_songs_MouseLeave);
            // 
            // grid_albums
            // 
            this.grid_albums.BackgroundColor = System.Drawing.Color.Snow;
            this.grid_albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_albums.Location = new System.Drawing.Point(230, 104);
            this.grid_albums.Name = "grid_albums";
            this.grid_albums.RowHeadersWidth = 51;
            this.grid_albums.Size = new System.Drawing.Size(522, 326);
            this.grid_albums.TabIndex = 7;
            this.grid_albums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_albums_CellClick);
            // 
            // button_albums
            // 
            this.button_albums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_albums.FlatAppearance.BorderSize = 0;
            this.button_albums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(215)))));
            this.button_albums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_albums.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_albums.Location = new System.Drawing.Point(6, 235);
            this.button_albums.Name = "button_albums";
            this.button_albums.Size = new System.Drawing.Size(173, 28);
            this.button_albums.TabIndex = 8;
            this.button_albums.Text = "              Альбомы";
            this.button_albums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_albums.UseVisualStyleBackColor = false;
            this.button_albums.Click += new System.EventHandler(this.button_albums_Click);
            this.button_albums.MouseEnter += new System.EventHandler(this.button_albums_MouseEnter);
            this.button_albums.MouseLeave += new System.EventHandler(this.button_albums_MouseLeave);
            // 
            // TB_search
            // 
            this.TB_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_search.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TB_search.Location = new System.Drawing.Point(252, 13);
            this.TB_search.Margin = new System.Windows.Forms.Padding(2);
            this.TB_search.MinimumSize = new System.Drawing.Size(506, 19);
            this.TB_search.Multiline = true;
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(506, 20);
            this.TB_search.TabIndex = 9;
            this.TB_search.Text = "Поиск";
            this.TB_search.Click += new System.EventHandler(this.TB_search_Click);
            this.TB_search.TextChanged += new System.EventHandler(this.TB_search_TextChanged);
            this.TB_search.Leave += new System.EventHandler(this.TB_search_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.button_smena_akka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ico_author);
            this.groupBox1.Controls.Add(this.ico_album);
            this.groupBox1.Controls.Add(this.button_albums);
            this.groupBox1.Controls.Add(this.button_authors);
            this.groupBox1.Controls.Add(this.ico_music);
            this.groupBox1.Controls.Add(this.button_songs);
            this.groupBox1.Location = new System.Drawing.Point(-10, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 508);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button_smena_akka
            // 
            this.button_smena_akka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_smena_akka.FlatAppearance.BorderSize = 0;
            this.button_smena_akka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_smena_akka.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smena_akka.Location = new System.Drawing.Point(6, 465);
            this.button_smena_akka.Name = "button_smena_akka";
            this.button_smena_akka.Size = new System.Drawing.Size(158, 28);
            this.button_smena_akka.TabIndex = 10;
            this.button_smena_akka.Text = "      Сменить аккаунт";
            this.button_smena_akka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_smena_akka.UseVisualStyleBackColor = false;
            this.button_smena_akka.Click += new System.EventHandler(this.button_smena_akka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "МОЯ МУЗЫКА";
            // 
            // ico_author
            // 
            this.ico_author.AutoSize = true;
            this.ico_author.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ico_author.Location = new System.Drawing.Point(26, 268);
            this.ico_author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ico_author.Name = "ico_author";
            this.ico_author.Size = new System.Drawing.Size(28, 23);
            this.ico_author.TabIndex = 13;
            this.ico_author.Text = "〠";
            // 
            // ico_album
            // 
            this.ico_album.AutoSize = true;
            this.ico_album.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ico_album.Location = new System.Drawing.Point(25, 235);
            this.ico_album.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ico_album.Name = "ico_album";
            this.ico_album.Size = new System.Drawing.Size(28, 26);
            this.ico_album.TabIndex = 12;
            this.ico_album.Text = "◎";
            // 
            // ico_music
            // 
            this.ico_music.AutoSize = true;
            this.ico_music.BackColor = System.Drawing.Color.Transparent;
            this.ico_music.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.ico_music.Location = new System.Drawing.Point(25, 206);
            this.ico_music.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ico_music.Name = "ico_music";
            this.ico_music.Size = new System.Drawing.Size(28, 26);
            this.ico_music.TabIndex = 11;
            this.ico_music.Text = "♬";
            // 
            // lbl_title_main
            // 
            this.lbl_title_main.AutoSize = true;
            this.lbl_title_main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_main.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title_main.Location = new System.Drawing.Point(220, 45);
            this.lbl_title_main.Name = "lbl_title_main";
            this.lbl_title_main.Size = new System.Drawing.Size(127, 44);
            this.lbl_title_main.TabIndex = 11;
            this.lbl_title_main.Text = "Треки";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(229, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 1);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(227, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "🔍";
            // 
            // button_add_albom
            // 
            this.button_add_albom.Location = new System.Drawing.Point(230, 436);
            this.button_add_albom.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_albom.Name = "button_add_albom";
            this.button_add_albom.Size = new System.Drawing.Size(73, 19);
            this.button_add_albom.TabIndex = 15;
            this.button_add_albom.Text = "Добавить";
            this.button_add_albom.UseVisualStyleBackColor = true;
            this.button_add_albom.Click += new System.EventHandler(this.button_add_albom_Click);
            // 
            // button_remoove_albom
            // 
            this.button_remoove_albom.Location = new System.Drawing.Point(385, 436);
            this.button_remoove_albom.Margin = new System.Windows.Forms.Padding(2);
            this.button_remoove_albom.Name = "button_remoove_albom";
            this.button_remoove_albom.Size = new System.Drawing.Size(73, 19);
            this.button_remoove_albom.TabIndex = 16;
            this.button_remoove_albom.Text = "Удалить";
            this.button_remoove_albom.UseVisualStyleBackColor = true;
            this.button_remoove_albom.Click += new System.EventHandler(this.button_remoove_albom_Click);
            // 
            // button_change_albom
            // 
            this.button_change_albom.Location = new System.Drawing.Point(308, 436);
            this.button_change_albom.Margin = new System.Windows.Forms.Padding(2);
            this.button_change_albom.Name = "button_change_albom";
            this.button_change_albom.Size = new System.Drawing.Size(73, 19);
            this.button_change_albom.TabIndex = 17;
            this.button_change_albom.Text = "Изменить";
            this.button_change_albom.UseVisualStyleBackColor = true;
            this.button_change_albom.Click += new System.EventHandler(this.button_change_albom_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.button_change_albom);
            this.Controls.Add(this.button_remoove_albom);
            this.Controls.Add(this.button_add_albom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.lbl_title_main);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_albums);
            this.Controls.Add(this.grid_song);
            this.Controls.Add(this.grid_authors);
            this.MaximumSize = new System.Drawing.Size(818, 532);
            this.MinimumSize = new System.Drawing.Size(818, 532);
            this.Name = "Main";
            this.Text = "Z.Музыка";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_authors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_albums)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_authors;
        private System.Windows.Forms.DataGridView grid_song;
        private System.Windows.Forms.Button button_authors;
        private System.Windows.Forms.Button button_songs;
        private System.Windows.Forms.DataGridView grid_albums;
        private System.Windows.Forms.Button button_albums;
        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title_main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_smena_akka;
        private System.Windows.Forms.Label ico_music;
        private System.Windows.Forms.Label ico_album;
        private System.Windows.Forms.Label ico_author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add_albom;
        private System.Windows.Forms.Button button_remoove_albom;
        private System.Windows.Forms.Button button_change_albom;
    }
}