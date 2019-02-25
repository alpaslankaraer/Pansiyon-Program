using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pansiyon_Program
{
	public partial class kisiEkle : Form
	{
		SqlConnection con;
		SqlCommand cmd;
		DataTable dt;

		public kisiEkle()
		{
			InitializeComponent();
			listele();
		}

		void listele()
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pansiyon.mdf;Integrated Security=True");
			SqlDataAdapter sda = new SqlDataAdapter("select * from Customer", con);
			dt = new DataTable();
			sda.Fill(dt);

			dataGridView1.DataSource = dt;
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			con.Close();

		}

		public string nonspace(string txt)
		{
			if (!txt.Equals(""))
			{
				int i = 0;
				while ((char)txt[i] == ' ' && i < txt.Length - 1)
				{ i++; }
				txt = txt.Substring(i, txt.Length - i);
				i = txt.Length - 1;
				while ((char)txt[i] == ' ' && i > 0)
				{ i--; }
				txt = txt.Substring(0, i + 1);
			}
			return txt;
		}

		private void yanaGecirButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				TC_NOTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
				isimTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				soyisimTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
				telefonTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
				karaListeTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
				hatirlatmaTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

				TC_NOAratextBox.Text = "";
				isimAraTextBox.Text = "";
				soyisimAraTextBox.Text = "";

			}
			else
			{
				TC_NOTextBox.Text = TC_NOAratextBox.Text;
				isimTextBox.Text = isimAraTextBox.Text;
				soyisimTextBox.Text = soyisimAraTextBox.Text;
			}
		}

		private void ekleButton_Click(object sender, EventArgs e)
		{
			if (TC_NOTextBox.Text == "")
			{
				MessageBox.Show("TC_NO boş bırakılamaz.");
			}
			else if (TC_NOTextBox.TextLength < 11)
			{
				MessageBox.Show("TC_NO 11 haneli olmalıdır.");
			}
			else if (isimTextBox.Text == "")
			{
				MessageBox.Show("İsim boş bırakılamaz.");
			}
			else if (soyisimTextBox.Text == "")
			{
				MessageBox.Show("Soyisim boş bırakılamaz.");
			}
			else if (telefonTextBox.Text == "")
			{
				MessageBox.Show("Lütfen bir telefon numarası giriniz.");
			}
			else if (telefonTextBox.TextLength < 11)
			{
				MessageBox.Show("Telefon numarası 11 haneli olmalıdır.");
			}
			else
			{
				con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pansiyon.mdf;Integrated Security=True");
				con.Open();

				cmd = new SqlCommand("select * from Customer where TC_NO=@TC_NO", con);
				cmd.Parameters.AddWithValue("@TC_NO", TC_NOTextBox.Text);

				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					string s = "update Customer set TC_NO=@TC_NO,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,KaraListe=@KaraListe,Hatırlatma=@Hatırlatma where TC_NO=@TC_NO";
					cmd = new SqlCommand(s, con);
					cmd.Parameters.AddWithValue("@TC_NO", TC_NOTextBox.Text);
					cmd.Parameters.AddWithValue("@Ad", nonspace(isimTextBox.Text.ToUpper()));
					cmd.Parameters.AddWithValue("@Soyad", nonspace(soyisimTextBox.Text.ToUpper()));
					cmd.Parameters.AddWithValue("@Telefon", telefonTextBox.Text);
					cmd.Parameters.AddWithValue("@KaraListe", nonspace(karaListeTextBox.Text.ToUpper()));
					cmd.Parameters.AddWithValue("@Hatırlatma", nonspace(hatirlatmaTextBox.Text.ToUpper()));
				}
				else
				{
					cmd = new SqlCommand("insert into Customer (TC_NO,Ad,Soyad,Telefon,KaraListe,Hatırlatma) values (@TC_NO,@Ad,@Soyad,@Telefon,@KaraListe,@Hatırlatma)", con);
					cmd.Parameters.AddWithValue("@TC_NO", TC_NOTextBox.Text);
					cmd.Parameters.AddWithValue("@Ad", nonspace(isimTextBox.Text.ToUpper()));
					cmd.Parameters.AddWithValue("@Soyad", nonspace(soyisimTextBox.Text.ToUpper()));
					cmd.Parameters.AddWithValue("@Telefon", telefonTextBox.Text);
					cmd.Parameters.AddWithValue("@KaraListe", nonspace(karaListeTextBox.Text.ToUpper()));
					cmd.Parameters.AddWithValue("@Hatırlatma", nonspace(hatirlatmaTextBox.Text.ToUpper()));
				}
				dr.Close();

				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Kayıt tamamlandı.");
				con.Close();
				TC_NOTextBox.Text = "";
				isimTextBox.Text = "";
				soyisimTextBox.Text = "";
				telefonTextBox.Text = "0";
				karaListeTextBox.Text = "";
				hatirlatmaTextBox.Text = "";
				TC_NOAratextBox.Text = "";
				isimAraTextBox.Text = "";
				soyisimAraTextBox.Text = "";
			}
			listele();
			dataGridView1.AutoResizeColumn(dataGridView1.CurrentRow.Cells[5].RowIndex);
		}

		private void TC_NOAratextBox_TextChanged(object sender, EventArgs e)
		{
			DataView dv = new DataView(dt);
			dv.RowFilter = "TC_NO like '%" + TC_NOAratextBox.Text + "%'";
			dataGridView1.DataSource = dv;
			bilgiLabel.Text = "Kişiyi yana geçir butonuna tıklayarak seçilen kişiyi sol taraftaki müşteri ekleme kısmına geçirebilirsiniz.";

		}

		private void isimAraTextBox_TextChanged(object sender, EventArgs e)
		{
			DataView dv = new DataView(dt);
			dv.RowFilter = "Ad like '%" + isimAraTextBox.Text + "%'";
			dataGridView1.DataSource = dv;
			bilgiLabel.Text = "Kişiyi yana geçir butonuna tıklayarak seçilen kişiyi sol taraftaki müşteri ekleme kısmına geçirebilirsiniz.";
		}

		private void soyisimAraTextBox_TextChanged(object sender, EventArgs e)
		{
			DataView dv = new DataView(dt);
			dv.RowFilter = "Soyad like '%" + soyisimAraTextBox.Text + "%'";
			dataGridView1.DataSource = dv;
			bilgiLabel.Text = "Kişiyi yana geçir butonuna tıklayarak seçilen kişiyi sol taraftaki müşteri ekleme kısmına geçirebilirsiniz.";
		}

		private void TC_NOTextBox_TextChanged(object sender, EventArgs e)
		{
			bilgiLabel.Text = "Ekle butonuna tıklayarak seçilen müşteriyi sisteme ekleyebilirsiniz.";
		}

		private void isimTextBox_TextChanged(object sender, EventArgs e)
		{
			bilgiLabel.Text = "Ekle butonuna tıklayarak seçilen müşteriyi sisteme ekleyebilirsiniz.";
		}

		private void soyisimTextBox_TextChanged(object sender, EventArgs e)
		{
			bilgiLabel.Text = "Ekle butonuna tıklayarak seçilen müşteriyi sisteme ekleyebilirsiniz.";
		}

		private void telefonTextBox_TextChanged(object sender, EventArgs e)
		{
			bilgiLabel.Text = "Ekle butonuna tıklayarak seçilen müşteriyi sisteme ekleyebilirsiniz.";
		}

		private void hatirlatmaTextBox_TextChanged(object sender, EventArgs e)
		{
			bilgiLabel.Text = "Ekle butonuna tıklayarak seçilen müşteriyi sisteme ekleyebilirsiniz.";
		}

		private void karaListeTextBox_TextChanged(object sender, EventArgs e)
		{
			bilgiLabel.Text = "Ekle butonuna tıklayarak seçilen müşteriyi sisteme ekleyebilirsiniz.";
		}

		private void silButton_Click(object sender, EventArgs e)
		{
			con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pansiyon.mdf;Integrated Security=True");
			con.Open();

			if (dataGridView1.CurrentRow != null)
			{
				cmd = new SqlCommand("select * from Customer where TC_NO=@TC_NO", con);
				cmd.Parameters.AddWithValue("@TC_NO", dataGridView1.CurrentRow.Cells[2].Value.ToString());

				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					string s = "delete Customer where TC_NO=@TC_NO";
					cmd = new SqlCommand(s, con);
					cmd.Parameters.AddWithValue("@TC_NO", dataGridView1.CurrentRow.Cells[2].Value.ToString());
					cmd.Parameters.AddWithValue("@Ad", dataGridView1.CurrentRow.Cells[0].Value.ToString());
					cmd.Parameters.AddWithValue("@Soyad", dataGridView1.CurrentRow.Cells[1].Value.ToString());
					cmd.Parameters.AddWithValue("@Telefon", dataGridView1.CurrentRow.Cells[3].Value.ToString());
					cmd.Parameters.AddWithValue("@KaraListe", dataGridView1.CurrentRow.Cells[4].Value.ToString());
					cmd.Parameters.AddWithValue("@Hatırlatma", dataGridView1.CurrentRow.Cells[5].Value.ToString());
				}
				dr.Close();

				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Silme işlemi tamamlandı.");
				con.Close();

				TC_NOTextBox.Text = "";
				isimTextBox.Text = "";
				soyisimTextBox.Text = "";
				telefonTextBox.Text = "0";
				karaListeTextBox.Text = "";
				hatirlatmaTextBox.Text = "";
				TC_NOAratextBox.Text = "";
				isimAraTextBox.Text = "";
				soyisimAraTextBox.Text = "";
			}
			else
			{
				MessageBox.Show("Şu an silinebilecek müşteri yok.");
			}
			listele();
			//dataGridView1.AutoResizeColumn(dataGridView1.CurrentRow.Cells[5].RowIndex);
		}

	}
}
