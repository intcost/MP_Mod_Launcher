/*

░▒█░░░░█▀▀▄░▒█░▒█░▒█▄░▒█░▒█▀▀▄░▒█░▒█░▒█▀▀▀░▒█▀▀▄░░░▒█▀▀▀█░▒█▀▀▀█░▒█░▒█░▒█▀▀▄░▒█▀▀▄░▒█▀▀▀
░▒█░░░▒█▄▄█░▒█░▒█░▒█▒█▒█░▒█░░░░▒█▀▀█░▒█▀▀▀░▒█▄▄▀░░░░▀▀▀▄▄░▒█░░▒█░▒█░▒█░▒█▄▄▀░▒█░░░░▒█▀▀▀
░▒█▄▄█▒█░▒█░░▀▄▄▀░▒█░░▀█░▒█▄▄▀░▒█░▒█░▒█▄▄▄░▒█░▒█░░░▒█▄▄▄█░▒█▄▄▄█░░▀▄▄▀░▒█░▒█░▒█▄▄▀░▒█▄▄▄

|	Пришло время раскрыть все карты для слабовидящих.      |
|                                                          |
|	author - intcost                                       |
|	design - MiZa                                          |
|														   |
|	t.me/msco1											   |
|	t.me/mscofaq										   |

*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPMODENEWLAUNCHER
{
	public partial class MSCO : Form
	{
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public MSCO()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			this.gradientTimer = new Timer();
			this.gradientTimer.Interval = 16;
			this.gradientTimer.Tick += this.GradientTimer_Tick;
			this.gradientTimer.Start();
			this.gradientColors = new Color[]
			{
				Color.Blue,
				Color.Purple,
				Color.Red,
				Color.Green,
				Color.Pink,
				Color.FromArgb(238, 173, 229),
				Color.FromArgb(249, 210, 246),
				Color.FromArgb(255, 255, 254),
				Color.FromArgb(201, 159, 222),
				Color.FromArgb(160, 81, 146)
			};
			this.currentPresetIndex = 0;
			this.nextPresetIndex = 1;
		}

		private void Check()
		{
#if debug
			if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "msco_crack")))
			{
				MessageBox.Show("Похоже, вы запускаете лаунчер не из корневой папки игры. (Проверьте наличие папки 'msco_crack')");
				Environment.Exit(0);
			}
#endif
		}

		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MSCO.ReleaseCapture();
				MSCO.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private void ReplaceFilesInRootFolder(string sourceFolderName)
		{
			foreach (string text in Directory.GetFiles(sourceFolderName))
			{
				string fileName = Path.GetFileName(text);
				string text2 = Path.Combine(Environment.CurrentDirectory, fileName);
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				File.Copy(text, text2);
			}
		}

		private void DeleteFilesInRootFolder(string folderName)
		{
			string[] files = Directory.GetFiles(folderName);
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = Path.GetFileName(files[i]);
				string text = Path.Combine(Environment.CurrentDirectory, fileName);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
			}
		}

		private void LoadLastUserChoice()
		{
			if (File.Exists("user_settings.txt"))
			{
				string text = File.ReadAllText("user_settings.txt");
				this.comboBox1.Text = text;
			}
		}

		private void SaveUserChoice(string choice) // сохраняем последний выбор пользователя
		{
			File.WriteAllText("user_settings.txt", choice);
		}

		private bool IsSteamRunning() // проверяем запущен ли стим
		{
			return Process.GetProcessesByName("steam").Length != 0;
		}

		private bool IsRadminRunning() // проверяем запущен ли радмин
        {
			return true; // костыль просто, ну не нужно большэ
			//return Process.GetProcessesByName("RvRvpnGui").Length != 0;
		}

		private void startbutton_Click(object sender, EventArgs e) //обработчик нажатой кнопки старт
		{
			if (this.comboBox1.SelectedIndex == -1)
			{
				MessageBox.Show("Пожалуйста, выберете тип подключения.");
			}
			if (this.comboBox1.Text == "Steam (Лицензия)")
			{
				if (!this.IsSteamRunning())
				{
					MessageBox.Show("Steam закрыт. Пожалуйста, откройте Steam и попробуйте снова. Либо, выберете тип подключения по LAN.");
					goto IL_233;
				}
				this.SaveUserChoice("Steam (Лицензия)");
				string text = Path.Combine(new string[] { "mysummercar.exe" });
				try
				{
					this.DeleteFilesInRootFolder("Lan");
					this.DeleteFilesInRootFolder("Steam");
					this.ReplaceFilesInRootFolder("SteamLic");
					if (File.Exists(text))
					{
						GamePatcherMod.InjectorLic();
						this.SaveUserChoice("Steam (Лицензия)");
					}
					else
					{
						MessageBox.Show("mysummercar.exe не найден. Вы уверены что запускаете лаунчер из под корневой папки?");
					}
					goto IL_233;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ошибка запуска приложения (попробуйте отключить антивирус): " + ex.Message);
					goto IL_233;
				}
			}
			if (this.comboBox1.Text == "Steam")
			{
				if (!this.IsSteamRunning())
				{
					MessageBox.Show("Steam закрыт. Пожалуйста, откройте Steam и попробуйте снова. Либо, выберете тип подключения по LAN.");
					goto IL_233;
				}
				this.SaveUserChoice("Steam");
				string text2 = Path.Combine(new string[] { "mysummercar.exe" });
				try
				{
					this.DeleteFilesInRootFolder("Lan");
					this.ReplaceFilesInRootFolder("Steam");
					if (File.Exists(text2))
					{
						GamePatcherMod.Patch();
						this.SaveUserChoice("Steam");
					}
					else
					{
						MessageBox.Show("mysummercar.exe не найден. Вы уверены что запускаете лаунчер из под корневой папки?");
					}
					goto IL_233;
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Ошибка запуска приложения: " + ex2.Message);
					goto IL_233;
				}
			}
			if (this.comboBox1.Text == "LAN (Локальная сеть)")
			{
				if (this.RadminVPNCheckBox.Checked && !this.IsRadminRunning())
				{
					MessageBox.Show("Лаунчер не обнаружил процесс Radmin VPN. Если вы используете сторонний эмулятор сети, то продолжайте. Если нет, то скачайте Radmin VPN.");
				}
				else
				{
					this.SaveUserChoice("LAN (Локальная сеть)");
					this.DeleteFilesInRootFolder("Steam");
					this.ReplaceFilesInRootFolder("Lan");
					string currentDirectory = Environment.CurrentDirectory;
					Directory.SetCurrentDirectory("msco_crack\\bin\\debug");
					string text3 = "crck_lan.exe";
					if (File.Exists(text3))
					{
						try
						{
							Process.Start(text3);
							Directory.SetCurrentDirectory(currentDirectory);
							goto IL_233;
						}
						catch (Exception ex3)
						{
							MessageBox.Show("Ошибка запуска приложения: " + ex3.Message);
							goto IL_233;
						}
					}
					MessageBox.Show("Файл c msco не найден.");
				}
			}
			IL_233:
			if (this.comboBox1.SelectedIndex == -1337)
			{
				MessageBox.Show("Привет реверс инженеры) Как вас сюда занесло?))) Моё вам послание (если кто-то будет рыться в моём сурсе :) Проект чист, как видите)");
			}
			Environment.Exit(0);
		}

		private void discordBLINK_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo("https://discord.gg/jD3uqZbEBz")
			{
				UseShellExecute = true
			});
		}

        private void githubBLINK_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/intcost/MP_Mod_Launcher")
            {
                UseShellExecute = true
            });
        }

        private void GradientTimer_Tick(object sender, EventArgs e)
		{
			this.gradientOffset += 0.005f;
			if (this.gradientOffset > 1f)
			{
				this.gradientOffset = 0f;
				this.currentPresetIndex = this.nextPresetIndex;
				this.nextPresetIndex = (this.nextPresetIndex + 1) % this.maxPresets;
			}
			base.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Color color = this.gradientColors[this.currentPresetIndex];
			Color color2 = this.gradientColors[this.nextPresetIndex];
			Color color3 = this.InterpolateColor(color, color2, this.gradientOffset);
			Color color4 = this.InterpolateColor(color2, color, this.gradientOffset);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, color3, color4, 45f))
			{
				linearGradientBrush.InterpolationColors = new ColorBlend
				{
					Positions = new float[] { 0f, this.gradientOffset, 1f },
					Colors = new Color[] { color3, color4, color3 }
				};
				e.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			}
		}

		private Color InterpolateColor(Color start, Color end, float factor)
		{
			int num = (int)((float)start.R + factor * (float)(end.R - start.R));
			int num2 = (int)((float)start.G + factor * (float)(end.G - start.G));
			int num3 = (int)((float)start.B + factor * (float)(end.B - start.B));
			return Color.FromArgb(num, num2, num3);
		}

		private async Task LoadImageUrls()
		{
			string text = "https://raw.githubusercontent.com/SatanMaker2077/MP_Mod/refs/heads/main/images.txt"; // получаем список картинок с гитхаба
			using (HttpClient clients = new HttpClient())
			{
				string text2 = await (await clients.GetAsync(text)).Content.ReadAsStringAsync();
				this.imageUrls = text2.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
			}
			HttpClient client = null;
			if (this.imageUrls.Count > 0)
			{
				this.LoadImage(this.currentImageIndex);
			}
		}

        private async void LoadImage(int index)
        {
            if (index >= 0 && index < this.imageUrls.Count)
            {
                string imageUrl = this.imageUrls[index];
                if (this.imageCache.ContainsKey(imageUrl))
                {
                    this.screenshots.Image = this.imageCache[imageUrl];
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                            {
                                Image image = Image.FromStream(memoryStream);
                                this.imageCache[imageUrl] = image;
                                this.screenshots.Image = image;
                            }
                        }
                        catch (Exception ex)
                        {
                            // лог обработки ошибок
                            Console.WriteLine($"Ошибка загрузки изображения: {ex.Message}");
                        }
                    }
                }
            }
        }


        private void telegranBLINK_Click(object sender, EventArgs e) // телега наша
		{
			Process.Start(new ProcessStartInfo("https://t.me/msco1")
			{
				UseShellExecute = true
			});
		}

		public async Task CheckServerStatus()
		{
			// TODO: добавить проверку серверов в будущем
			bool flag = true;
			bool flag2 = true;
			//костыли для визуала
			if (flag && flag2)
			{
				this.label6.Text = "Доступны";
				this.label6.ForeColor = Color.Green;
			}
			else if (flag || flag2)
			{
				this.label6.Text = "Один из серверов не в сети";
				this.label6.ForeColor = Color.Yellow;
			}
			else
			{
				this.label6.Text = "Сервера недоступны (в разработке.)";
				this.label6.ForeColor = Color.Red;
			}
		}

		private async Task<bool> IsServerOnline(string url)
		{
			bool flag;
			try
			{
				flag = (await MSCO.client.GetAsync(url)).IsSuccessStatusCode;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		private async void MSCO_Load(object sender, EventArgs e)
		{
			this.LoadLastUserChoice();
			string text = "https://raw.githubusercontent.com/SatanMaker2077/MP_Mod/refs/heads/main/Title.txt";
			string DescURL = "https://raw.githubusercontent.com/SatanMaker2077/MP_Mod/refs/heads/main/Description.txt";
			this.label2.Text = "MSCO Cracks | 20" + DateTime.Now.ToString("yy"); // колхоз на актуальном времени (костыль тупа да)
			using (HttpClient client_networks = new HttpClient())
			{
				try
				{
					HttpResponseMessage httpResponseMessage = await client_networks.GetAsync(text);
					if (httpResponseMessage.IsSuccessStatusCode)
					{
						string text2 = await httpResponseMessage.Content.ReadAsStringAsync();
						this.label3.Text = text2;
					}
					else
					{
						this.label3.Text = "Ошибка сети...";
					}
					HttpResponseMessage httpResponseMessage2 = await client_networks.GetAsync(DescURL);
					if (httpResponseMessage2.IsSuccessStatusCode)
					{
						string text3 = await httpResponseMessage2.Content.ReadAsStringAsync();
						this.label4.Text = text3;
					}
					else
					{
						this.label4.Text = "Проверьте соединение с интернетом.";
					}
					await this.LoadImageUrls();
					this.Check();
					await this.CheckServerStatus();
				}
				catch (Exception)
				{
					this.label3.Text = "Ошибка сети...";
					this.label4.Text = "Проверьте соединение с интернетом.";
				}
			}
			HttpClient client_network = null;
		}

		private void image_prev_Click(object sender, EventArgs e)
		{
			if (this.currentImageIndex > 0)
			{
				this.currentImageIndex--;
			}
			else
			{
				this.currentImageIndex = this.imageUrls.Count - 1;
			}
			this.LoadImage(this.currentImageIndex);
		}

		private void image_next_Click(object sender, EventArgs e)
		{
			if (this.currentImageIndex < this.imageUrls.Count - 1)
			{
				this.currentImageIndex++;
			}
			else
			{
				this.currentImageIndex = 0;
			}
			this.LoadImage(this.currentImageIndex);
		}

		private void RadminVPNCheckBox_CheckedChanged(object sender, EventArgs e)
		{
		}

		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private Timer gradientTimer;

		private float gradientOffset;

		private Color[] gradientColors;

		private int currentPresetIndex;

		private int nextPresetIndex;

		private int maxPresets = 5;

		private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

		private const string SettingsFileName = "user_settings.txt";

		private const string SteamOption = "Steam";

		private const string SteamLicOption = "Steam (Лицензия)";

		private const string LanOption = "LAN (Локальная сеть)";

		private List<string> imageUrls = new List<string>();

		private int currentImageIndex;

		private static readonly HttpClient client = new HttpClient();

        private void label7_Click(object sender, EventArgs e)
        {
			// наху не нужно
        }
    }
}
