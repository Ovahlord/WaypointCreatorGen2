using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaypointCreatorGen2
{
    public partial class WaypointCreator : Form
    {
        // Dictionary<UInt32 /*CreatureID*/, Dictionary<UInt64 /*lowGUID*/, List<WaypointInfo>>>
        Dictionary<UInt32, Dictionary<UInt64, List<WaypointInfo>>> WaypointDatabyCreatureEntry = new Dictionary<UInt32, Dictionary<UInt64, List<WaypointInfo>>>();


        public WaypointCreator()
        {
            InitializeComponent();
        }

        private void WaypointCreator_Load(object sender, EventArgs e)
        {

        }

        private async void EditorImportSniffButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                EditorListBox.Items.Clear();
                EditorImportSniffButton.Enabled = false;
                EditorFilterEntryButton.Enabled = false;
                EditorLoadingLabel.Text = "Loading [" + Path.GetFileName(dialog.FileName) + "]...";

                WaypointDatabyCreatureEntry = await Task.Run(()=> GetWaypointDataFromSniff(dialog.FileName));

                EditorImportSniffButton.Enabled = true;
                EditorFilterEntryButton.Enabled = true;
                EditorLoadingLabel.Text = "Loaded [" + Path.GetFileName(dialog.FileName) + "].";
                ListEntries(0); // Initially listing all available GUIDs
            }
        }

        // Parses all waypoint data from the provided file and returns a container filled with all needed data
        private Dictionary<UInt32, Dictionary<UInt64, List<WaypointInfo>>> GetWaypointDataFromSniff(String filePath)
        {
            Dictionary<UInt32, Dictionary<UInt64, List<WaypointInfo>>> result = new Dictionary<UInt32, Dictionary<UInt64, List<WaypointInfo>>>();

            string[] lines = File.ReadAllLines(filePath);

            for (int lineIndex = 0; lineIndex < lines.Length; ++lineIndex)
            {
                string line = lines[lineIndex];

                if (line.Contains("SMSG_ON_MONSTER_MOVE") || line.Contains("SMSG_ON_MONSTER_MOVE_TRANSPORT"))
                {
                    WaypointInfo wpInfo = new WaypointInfo();
                    UInt32 creatureId = 0;
                    UInt64 lowGuid = 0;

                    // Extracting the packet timestamp in milliseconds from the packet header for delay calculations
                    string[] packetHeader = line.Split(new char[] { ' ' });
                    for (int i = 0; i < packetHeader.Length; ++i)
                    {
                        if (packetHeader[i].Contains("Time:"))
                        {
                            wpInfo.TimeStamp = UInt32.Parse(TimeSpan.Parse(packetHeader[i + 2]).TotalMilliseconds.ToString());
                            break;
                        }
                    }

                    // Header noted, reading rest of the packet now
                    do
                    {
                        ++lineIndex;

                        // Skip chase movement
                        if (lines[lineIndex].Contains("Face: 3"))
                            break;

                        // Extracting entry and lowGuid from packet
                        if (lines[lineIndex].Contains("MoverGUID:"))
                        {
                            string[] words = lines[lineIndex].Split(new char[] { ' ' });
                            for (int i = 0; i < words.Length; ++i)
                            {
                                if (words[i].Contains("Entry:"))
                                    creatureId = UInt32.Parse(words[i + 1]);
                                else if (words[i].Contains("Low:"))
                                    lowGuid = UInt64.Parse(words[i + 1]);
                            }
                        }

                        // Extracting spline duration
                        if (lines[lineIndex].Contains("MoveTime:"))
                        {
                            string[] words = lines[lineIndex].Split(new char[] { ' ' });
                            for (int i = 0; i < words.Length; ++i)
                                if (words[i].Contains("MoveTime:"))
                                    wpInfo.MoveTime = UInt32.Parse(words[i + 1]);
                        }

                        // Extract Facing Angles
                        if (lines[lineIndex].Contains("FaceDirection:"))
                        {
                            string[] words = lines[lineIndex].Split(new char[] { ' ' });
                            for (int i = 0; i < words.Length; ++i)
                                if (words[i].Contains("FaceDirection:"))
                                    wpInfo.Position.Orientation = float.Parse(words[i + 1], CultureInfo.InvariantCulture);
                        }

                        // Extracting waypoint (The space in the string is intentional. Do not remove!)
                        if (lines[lineIndex].Contains(" Points:"))
                        {
                            string[] words = lines[lineIndex].Split(new char[] { ' ' });
                            for (int i = 0; i < words.Length; ++i)
                            {
                                if (words[i].Contains("X:"))
                                    wpInfo.Position.PositionX = float.Parse(words[i + 1], CultureInfo.InvariantCulture);
                                else if (words[i].Contains("Y:"))
                                    wpInfo.Position.PositionY = float.Parse(words[i + 1], CultureInfo.InvariantCulture);
                                else if (words[i].Contains("Z:"))
                                    wpInfo.Position.PositionZ = float.Parse(words[i + 1], CultureInfo.InvariantCulture);
                            }

                            // Gathered all needed data. Time to store them.
                            if (creatureId == 0)
                                break;

                            // Delay Calculation
                            if (result.ContainsKey(creatureId) && result[creatureId].ContainsKey(lowGuid))
                            {
                                if (result[creatureId][lowGuid].Count != 0)
                                {
                                    int index = result[creatureId][lowGuid].Count - 1;
                                    Int64 timeDiff = wpInfo.TimeStamp - result[creatureId][lowGuid][index].TimeStamp;
                                    UInt32 oldMoveTime = result[creatureId][lowGuid][index].MoveTime;
                                    result[creatureId][lowGuid][index].Delay = Convert.ToInt32(timeDiff - oldMoveTime);
                                }
                            }

                            if (!result.ContainsKey(creatureId))
                                result.Add(creatureId, new Dictionary<UInt64, List<WaypointInfo>>());

                            if (!result[creatureId].ContainsKey(lowGuid))
                                result[creatureId].Add(lowGuid, new List<WaypointInfo>());

                            result[creatureId][lowGuid].Add(wpInfo);
                        }

                    }
                    while (lines[lineIndex] != "");
                }
            }

            return result;
        }

        private void ListEntries(UInt32 creatureId)
        {
            EditorListBox.Items.Clear();

            if (creatureId == 0)
            {
                foreach (var waypointsByEntry in WaypointDatabyCreatureEntry)
                    foreach (var waypointsByGuid in waypointsByEntry.Value)
                        EditorListBox.Items.Add(waypointsByGuid.Key);
            }
            else
            {
                if (WaypointDatabyCreatureEntry.ContainsKey(creatureId))
                    foreach (var waypointsByGuid in WaypointDatabyCreatureEntry[creatureId])
                        EditorListBox.Items.Add(waypointsByGuid.Key);
            }
        }

        private void ShowWaypointDataForGUID(UInt64 lowGUID)
        {
            // Filling the GridView
            EditorGridView.Rows.Clear();

            foreach (var waypointsByEntry in WaypointDatabyCreatureEntry)
            {
                if (waypointsByEntry.Value.ContainsKey(lowGUID))
                {
                    int count = 0;
                    foreach (WaypointInfo wpInfo in waypointsByEntry.Value[lowGUID])
                    {
                        EditorGridView.Rows.Add(
                            count,
                            wpInfo.Position.PositionX.ToString(CultureInfo.InvariantCulture),
                            wpInfo.Position.PositionY.ToString(CultureInfo.InvariantCulture),
                            wpInfo.Position.PositionZ.ToString(CultureInfo.InvariantCulture),
                            wpInfo.Position.Orientation.ToString(CultureInfo.InvariantCulture),
                            wpInfo.MoveTime,
                            wpInfo.Delay);

                        ++count;
                    }

                    break;
                }
            }

            BuildGraphPath();
        }
        private void BuildGraphPath()
        {
            EditorWaypointChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            EditorWaypointChart.ChartAreas[0].AxisY.ScaleView.ZoomReset();

            EditorWaypointChart.Series["Path"].Points.Clear();
            EditorWaypointChart.Series["Line"].Points.Clear();

            foreach (DataGridViewRow dataRow in EditorGridView.Rows)
            {
                float x = float.Parse(dataRow.Cells[1].Value.ToString(), CultureInfo.InvariantCulture);
                float y = float.Parse(dataRow.Cells[2].Value.ToString(), CultureInfo.InvariantCulture);

                EditorWaypointChart.Series["Path"].Points.AddXY(x, y);
                EditorWaypointChart.Series["Path"].Points[dataRow.Index].Label = dataRow.Index.ToString();
                EditorWaypointChart.Series["Line"].Points.AddXY(x, y);
            }
        }

        // Filters the ListBox entries by CreatureID
        private void EditorFilterEntryButton_Click(object sender, EventArgs e)
        {
            UInt32 creatureId = 0;
            UInt32.TryParse(EditorFilterEntryTextBox.Text, out creatureId);
            ListEntries(creatureId);
        }

        private void EditorListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (EditorListBox.SelectedIndex == -1)
                return;

            UInt64 lowGuid = UInt64.Parse(EditorListBox.SelectedItem.ToString());
            ShowWaypointDataForGUID(lowGuid);
        }
    }

    public class WaypointInfo
    {
        public UInt32 TimeStamp = 0;
        public WaypointPosition Position = new WaypointPosition();
        public UInt32 MoveTime = 0;
        public Int32 Delay = 0;
    }

    public class WaypointPosition
    {
        public float PositionX = 0f;
        public float PositionY = 0f;
        public float PositionZ = 0f;
        public float Orientation = 0f;
    }

}
