using System;
using System.Windows.Forms;

/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 20/07/2020
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Demo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.Enemy1 = new System.Windows.Forms.PictureBox();
			this.Car = new System.Windows.Forms.PictureBox();
			this.gameover = new System.Windows.Forms.Label();
			this.Coin1 = new System.Windows.Forms.PictureBox();
			this.Coin2 = new System.Windows.Forms.PictureBox();
			this.Coin3 = new System.Windows.Forms.PictureBox();
			this.Coin4 = new System.Windows.Forms.PictureBox();
			this.score = new System.Windows.Forms.Label();
			this.Enemy2 = new System.Windows.Forms.PictureBox();
			this.enemy3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
			this.pictureBox1.Location = new System.Drawing.Point(185, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 107);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.DimGray;
			this.pictureBox5.Location = new System.Drawing.Point(-1, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(10, 462);
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.DimGray;
			this.pictureBox6.Location = new System.Drawing.Point(372, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(10, 462);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
			this.pictureBox2.Location = new System.Drawing.Point(185, 132);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(10, 107);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
			this.pictureBox3.Location = new System.Drawing.Point(185, 265);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 107);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
			this.pictureBox4.Location = new System.Drawing.Point(185, 393);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 70);
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// Enemy1
			// 
			this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
			this.Enemy1.Location = new System.Drawing.Point(25, 66);
			this.Enemy1.Name = "Enemy1";
			this.Enemy1.Size = new System.Drawing.Size(34, 41);
			this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Enemy1.TabIndex = 13;
			this.Enemy1.TabStop = false;
			// 
			// Car
			// 
			this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
			this.Car.Location = new System.Drawing.Point(66, 319);
			this.Car.Name = "Car";
			this.Car.Size = new System.Drawing.Size(36, 76);
			this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Car.TabIndex = 9;
			this.Car.TabStop = false;
			// 
			// gameover
			// 
			this.gameover.BackColor = System.Drawing.Color.Yellow;
			this.gameover.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameover.ForeColor = System.Drawing.Color.Red;
			this.gameover.Location = new System.Drawing.Point(119, 175);
			this.gameover.Name = "gameover";
			this.gameover.Size = new System.Drawing.Size(142, 52);
			this.gameover.TabIndex = 14;
			this.gameover.Text = "GAME OVER!";
			// 
			// Coin1
			// 
			this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
			this.Coin1.Location = new System.Drawing.Point(36, 210);
			this.Coin1.Name = "Coin1";
			this.Coin1.Size = new System.Drawing.Size(23, 29);
			this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Coin1.TabIndex = 15;
			this.Coin1.TabStop = false;
			// 
			// Coin2
			// 
			this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
			this.Coin2.Location = new System.Drawing.Point(104, 56);
			this.Coin2.Name = "Coin2";
			this.Coin2.Size = new System.Drawing.Size(23, 29);
			this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Coin2.TabIndex = 16;
			this.Coin2.TabStop = false;
			// 
			// Coin3
			// 
			this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
			this.Coin3.Location = new System.Drawing.Point(250, 154);
			this.Coin3.Name = "Coin3";
			this.Coin3.Size = new System.Drawing.Size(23, 29);
			this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Coin3.TabIndex = 17;
			this.Coin3.TabStop = false;
			// 
			// Coin4
			// 
			this.Coin4.Image = ((System.Drawing.Image)(resources.GetObject("Coin4.Image")));
			this.Coin4.Location = new System.Drawing.Point(325, 27);
			this.Coin4.Name = "Coin4";
			this.Coin4.Size = new System.Drawing.Size(23, 29);
			this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Coin4.TabIndex = 18;
			this.Coin4.TabStop = false;
			// 
			// score
			// 
			this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.score.Location = new System.Drawing.Point(148, 439);
			this.score.Name = "score";
			this.score.Size = new System.Drawing.Size(100, 23);
			this.score.TabIndex = 19;
			this.score.Text = "Score:0";
			// 
			// Enemy2
			// 
			this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
			this.Enemy2.Location = new System.Drawing.Point(136, 132);
			this.Enemy2.Name = "Enemy2";
			this.Enemy2.Size = new System.Drawing.Size(35, 40);
			this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Enemy2.TabIndex = 20;
			this.Enemy2.TabStop = false;
			// 
			// enemy3
			// 
			this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
			this.enemy3.Location = new System.Drawing.Point(311, 66);
			this.enemy3.Name = "enemy3";
			this.enemy3.Size = new System.Drawing.Size(37, 41);
			this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy3.TabIndex = 21;
			this.enemy3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(384, 462);
			this.Controls.Add(this.enemy3);
			this.Controls.Add(this.Enemy2);
			this.Controls.Add(this.score);
			this.Controls.Add(this.Coin4);
			this.Controls.Add(this.Coin3);
			this.Controls.Add(this.Coin2);
			this.Controls.Add(this.Coin1);
			this.Controls.Add(this.gameover);
			this.Controls.Add(this.Enemy1);
			this.Controls.Add(this.Car);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "CAR RACE BY OMSAI!";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox enemy3;
		private System.Windows.Forms.PictureBox Enemy2;
		private System.Windows.Forms.Label score;
		private System.Windows.Forms.PictureBox Coin4;
		private System.Windows.Forms.PictureBox Coin3;
		private System.Windows.Forms.PictureBox Coin2;
		private System.Windows.Forms.PictureBox Coin1;
		private System.Windows.Forms.Label gameover;
		private System.Windows.Forms.PictureBox Enemy1;
		private System.Windows.Forms.PictureBox Car;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		

		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
			moveline(gamespeed);
			enemy(5);
			gameOver();
			coin(gamespeed);
			coinCollection();
		}
		Random r=new Random();
		int x,y,z;
		void enemy(int speed)
		{
			if(Enemy1.Top>=500){
				x=r.Next(20,170);
				Enemy1.Location=new System.Drawing.Point(x,0);
			}
			else{
				Enemy1.Top +=speed;	
			}
			if(Enemy2.Top>=500){
				y=r.Next(170,250);
				Enemy2.Location=new System.Drawing.Point(y,0);
			}
			else{
				Enemy2.Top +=speed;
			}
			if(enemy3.Top>=500){
				z=r.Next(250,350);
				enemy3.Location=new System.Drawing.Point(z,0);
			}
			else{
				enemy3.Top +=speed;		
			}
		}
		int coinsCollected=0;
		
		void coin(int speed)
		{
			if(Coin1.Top>=500){
				Coin1.Visible=true;
				x=r.Next(20,100);
				Coin1.Location=new System.Drawing.Point(x,0);
			}
			else{
				//Coin1.Visible=true;
				Coin1.Top +=speed;	
			}
			if(Coin2.Top>=500){
				Coin2.Visible=true;
				x=r.Next(100,200);
				Coin2.Location=new System.Drawing.Point(x,0);
			}
			else{
				//Coin2.Visible=true;
				Coin2.Top +=speed;	
			}
			if(Coin3.Top>=500){
				Coin3.Visible=true;
				x=r.Next(200,300);
				Coin3.Location=new System.Drawing.Point(x,0);
			}
			else{
				//Coin3.Visible=true;
				Coin3.Top +=speed;	
			}
			if(Coin4.Top>=500){
				Coin4.Visible=true;
				x=r.Next(300,370);
				Coin4.Location=new System.Drawing.Point(x,0);
			}
			else{
				//Coin4.Visible=true;
				Coin4.Top +=speed;	
			}
		}
		void coinCollection()
		{
			if(Car.Bounds.IntersectsWith(Coin1.Bounds))
			{
			 coinsCollected+=1;
			 Coin1.Visible=false;
			 score.Text="Score:"+coinsCollected.ToString();
			}
			if(Car.Bounds.IntersectsWith(Coin2.Bounds))
			{
			 coinsCollected+=1;
			 Coin2.Visible=false;
			 score.Text="Score:"+coinsCollected.ToString();
			}
			if(Car.Bounds.IntersectsWith(Coin3.Bounds))
			{
			 coinsCollected+=1;
			 Coin3.Visible=false;
			 score.Text="Score:"+coinsCollected.ToString();
			}
			if(Car.Bounds.IntersectsWith(Coin4.Bounds))
			{
			 coinsCollected+=1;
			 Coin4.Visible=false;
			 score.Text="Score:"+coinsCollected.ToString();
			}

		}
		void gameOver()
		{
			if(Car.Bounds.IntersectsWith(Enemy1.Bounds))
			{
			timer1.Enabled=false;
			gameover.Visible=true;
			score.Visible=false;
			Coin1.Visible=false;
			Coin2.Visible=false;
			Coin3.Visible=false;
			Coin4.Visible=false;
			Enemy2.Visible=false;
			enemy3.Visible=false;
			gameover.Text="GAME OVER!\n     Score:"+coinsCollected.ToString();
			}
			if(Car.Bounds.IntersectsWith(Enemy2.Bounds))
			{
			timer1.Enabled=false;
			gameover.Visible=true;			
			score.Visible=false;
			Coin1.Visible=false;
			Coin2.Visible=false;
			Coin3.Visible=false;
			Coin4.Visible=false;
			Enemy1.Visible=false;
			enemy3.Visible=false;
			gameover.Text="GAME OVER!\n     Score:"+coinsCollected.ToString();			
			}
			if(Car.Bounds.IntersectsWith(enemy3.Bounds))
			{
			timer1.Enabled=false;
			gameover.Visible=true;			
			score.Visible=false;
			Coin1.Visible=false;
			Coin2.Visible=false;
			Coin3.Visible=false;
			Coin4.Visible=false;			
			Enemy1.Visible=false;
			Enemy2.Visible=false;
			gameover.Text="GAME OVER!\n     Score:"+coinsCollected.ToString();
			}
		}
		void moveline(int speed)
		{
			if(pictureBox1.Top>=500){
				pictureBox1.Top =0;
			}
			else{
				pictureBox1.Top +=speed;	
			}
			if(pictureBox2.Top>=500){
				pictureBox2.Top =0;
			}
			else{
				pictureBox2.Top +=speed;
			}
			if(pictureBox3.Top>=500){
				pictureBox3.Top =0;
			}
			else{
				pictureBox3.Top +=speed;		
			}
			if(pictureBox4.Top>=500){
				pictureBox4.Top =0;
			}
			else{
				pictureBox4.Top +=speed;	
			}
		}
		
		void PictureBox3Click(object sender, System.EventArgs e)
		{
			
		}
		
		void PictureBox2Click(object sender, System.EventArgs e)
		{
			
		}
		
		void PictureBox7Click(object sender, System.EventArgs e)
		{
			
		}
		
		int gamespeed=04;
		void MainFormKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left)
			{
				if(Car.Left>15)
				Car.Left +=-gamespeed;
			}
			if(e.KeyCode == Keys.Right)
			{
				if(Car.Right<370)
				Car.Left+=gamespeed;
			}
			
			if(e.KeyCode==Keys.Up)
			{
				if(gamespeed<=15)
				{
					gamespeed++;
				}
			}
			if(e.KeyCode==Keys.Down)
			{
				if(gamespeed>0)
				{
					gamespeed--;
				}
			}
		}
	}
}
