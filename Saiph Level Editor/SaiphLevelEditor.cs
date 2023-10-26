using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Drawing;
using System.ComponentModel;

namespace Saiph_Level_Editor {
	public partial class SaiphLevelEditor : Form {

		private PictureBox spawnPicBox = new PictureBox();
		private SaveFileDialog sfdlg = new SaveFileDialog();

		private BindingList<Spawn> nodesBindList = new BindingList<Spawn>();
		private bool isPendingChanges = false;

		private void ExtractAttributes(ref Spawn _node) {
			_node.X = nudXPosition.Value;
			_node.Y = nudYPosition.Value;
			_node.Wait = nudWaitTime.Value;
			_node.Interval = nudInterval.Value;
			_node.EnemyType = cbEnemyType.SelectedIndex;
			_node.Amount = nudAmount.Value;
		}

		private void LoadData(Stream istream) {
			bool errorOccured = false, displayMessageBox = false;
			
			XmlReaderSettings settings = new XmlReaderSettings();
			settings.Schemas.Add(null, "Resources/spawnSchema.xsd");
			settings.ValidationType = ValidationType.Schema;
			settings.ValidationEventHandler += (o, e) => errorOccured = displayMessageBox = true;
			
			XmlReader xrdr = XmlReader.Create(istream, settings);

			while (!xrdr.EOF) {
				xrdr.Read();
				if (!errorOccured && xrdr.LocalName == "Spawn") {
					Spawn node = new Spawn();
					node.X = decimal.Parse(xrdr.GetAttribute("x"));
					node.Y = decimal.Parse(xrdr.GetAttribute("y"));
					node.Wait = decimal.Parse(xrdr.GetAttribute("wait"));
					node.Interval = decimal.Parse(xrdr.GetAttribute("interval"));
					node.EnemyType = decimal.Parse(xrdr.GetAttribute("enemy"));
					node.Amount = decimal.Parse(xrdr.GetAttribute("amount"));
					nodesBindList.Add(node);
				}
				errorOccured = false;
			}
			lbNodes.SelectedIndex = -1;

			if (displayMessageBox) MessageBox.Show("Failed to parse one or more nodes", "Data Parsing Error", MessageBoxButtons.OK);
		}

		private void SaveData(Stream ostream) {
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			XmlWriter xwtr = XmlWriter.Create(ostream, settings);
			
			xwtr.WriteStartDocument();
			xwtr.WriteStartElement("Level");
			foreach (Spawn node in lbNodes.Items) {
				xwtr.WriteStartElement("Spawn");
				xwtr.WriteAttributeString("x", $"{node.X}");
				xwtr.WriteAttributeString("y", $"{node.Y}");
				xwtr.WriteAttributeString("wait", $"{node.Wait}");
				xwtr.WriteAttributeString("interval", $"{node.Interval}");
				xwtr.WriteAttributeString("enemy", $"{node.EnemyType}");
				xwtr.WriteAttributeString("amount", $"{node.Amount}");
				xwtr.WriteEndElement();
			}
			xwtr.WriteEndDocument();    // Automatically ends open elements (will end "Level" element)

			xwtr.Flush();
		}

		private void CollectionChanged(object o, EventArgs e) {
			if (!isPendingChanges) Text = "*" + Text;
			isPendingChanges = true;
		}

		public SaiphLevelEditor() {
			InitializeComponent();
			
			sfdlg.Filter = "All Files|*.*|Xml|*.xml";
			sfdlg.FilterIndex = 2;
			
			lbNodes.DataSource = nodesBindList;
			nodesBindList.ListChanged += CollectionChanged;
			btnUpdate.Click += CollectionChanged;

			spawnPicBox.BackColor = Color.Transparent;
			spawnPicBox.Size = new Size(64, 64);
			spawnPicBox.SizeMode = PictureBoxSizeMode.CenterImage;
			
			splitContainer1.Panel1.Controls.Add(spawnPicBox);

			newToolStripMenuItem_Click(this, EventArgs.Empty);
		}

		private void SavePrompt(object sender, EventArgs e) {
			if (isPendingChanges) {
				DialogResult result = MessageBox.Show("Current file has unsaved changes! Do you want to save first?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);

				if (DialogResult.Yes == result) saveToolStripMenuItem_Click(sender, e);
				else if (DialogResult.No == result) isPendingChanges = false;	// Nullify changes
			}
		}


		private void SaiphLevelEditor_FormClosing(object sender, FormClosingEventArgs e) {
			SavePrompt(sender, e);
			if (isPendingChanges) e.Cancel = true;
		}


		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			SavePrompt(sender, e);
			if (!isPendingChanges) {
				nudXPosition.Value = nudYPosition.Value = 300M;
				nudWaitTime.Value = nudInterval.Value = nudAmount.Value = cbEnemyType.SelectedIndex = 0;
				spawnPicBox.Location = new Point((int)(nudXPosition.Value - 32M), (int)(nudYPosition.Value - 32M));
				nodesBindList.Clear();
				cbEnemyType.SelectedIndex = 0;
				sfdlg.FileName = string.Empty;
				isPendingChanges = false;
				Text = "Untitled - Saiph Level Editor";
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog ofdlg = new OpenFileDialog();
			if (DialogResult.OK == ofdlg.ShowDialog()) {
				newToolStripMenuItem_Click(sender, e);
				if (!isPendingChanges) {
					using (Stream fstream = new FileStream(ofdlg.FileName, FileMode.Open, FileAccess.Read)) {
						LoadData(fstream);
						Text = ofdlg.FileName.Substring(ofdlg.FileName.LastIndexOf('\\') + 1) + " - Saiph Level Editor";
						sfdlg.FileName = ofdlg.FileName;
						isPendingChanges = false;
					}
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			if (sfdlg.FileName is null || sfdlg.FileName == string.Empty)
				if (DialogResult.Cancel == sfdlg.ShowDialog()) return;

			using (Stream fstream = new FileStream(sfdlg.FileName, FileMode.Create, FileAccess.Write)) {
				SaveData(fstream);
				Text = sfdlg.FileName.Substring(sfdlg.FileName.LastIndexOf('\\') + 1) + " - Saiph Level Editor";
				isPendingChanges = false;    // Nullify changes, can later be used to deduce result value
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			String oldValue = sfdlg.FileName;
			sfdlg.FileName = string.Empty;
			saveToolStripMenuItem_Click(sender, e);
			if (isPendingChanges) sfdlg.FileName = oldValue;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (!(cbEnemyType.SelectedItem is null)) {	// is faster than using a try/catch mechanism
				Spawn node = new Spawn();
				ExtractAttributes(ref node);
				(lbNodes.DataSource as BindingList<Spawn>).Add(node);
				lbNodes.SelectedItem = node;
			}
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (!(lbNodes.SelectedItem is null)) {
				(lbNodes.DataSource as BindingList<Spawn>).Remove(lbNodes.SelectedItem as Spawn);
				lbNodes.SelectedIndex = cbEnemyType.SelectedIndex = -1;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			if (lbNodes.SelectedItem is Spawn node)
				if (!(cbEnemyType.SelectedItem is null)) {	// is faster than using a try/catch mechanism
					ExtractAttributes(ref node);
					nodesBindList.ResetItem(lbNodes.SelectedIndex);
				}
		}

		private void lbNodes_SelectedIndexChanged(object sender, EventArgs e) {
			if (lbNodes.SelectedItem is Spawn node) {
				nudXPosition.Value = node.X;
				nudYPosition.Value = node.Y;
				nudWaitTime.Value = node.Wait;
				nudInterval.Value = node.Interval;
				cbEnemyType.SelectedIndex = (int)node.EnemyType;
				nudAmount.Value = node.Amount;
			}
		}

		private void nudXPosition_ValueChanged(object sender, EventArgs e) {
			spawnPicBox.Location = new Point((int)(nudXPosition.Value - 32M), spawnPicBox.Location.Y);
		}

		private void nudYPosition_ValueChanged(object sender, EventArgs e) {
			spawnPicBox.Location = new Point(spawnPicBox.Location.X, (int)(nudYPosition.Value - 32M));
		}

		private void cbEnemyType_SelectedIndexChanged(object sender, EventArgs e) {
			switch (cbEnemyType.SelectedIndex) {
				case 0:
					spawnPicBox.Image = Properties.Resources.enemy0;
					break;
				case 1:
					spawnPicBox.Image = Properties.Resources.enemy1;
					break;
				case 2:
					spawnPicBox.Image = Properties.Resources.enemy2;
					break;
				case 3:
					spawnPicBox.Image = Properties.Resources.enemy3;
					break;
				case 4:
					spawnPicBox.Image = Properties.Resources.enemy4;
					break;
				default:
					spawnPicBox.Image = null;
					break;
			}
		}
	}
}
