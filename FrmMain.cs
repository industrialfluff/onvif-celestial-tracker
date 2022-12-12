using CosineKitty;
using Newtonsoft.Json;
using OnvifDiscovery;
using static System.Net.Mime.MediaTypeNames;


namespace ONVIFCelestialTracker
{
    public partial class FrmMain : Form
    {
        [System.Xml.Serialization.XmlArray]
        private List<Camera> cameras = new();

        public FrmLog frmLog = new();
        string programdata = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) + @"\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + @"\";

        public FrmMain()
        {
            InitializeComponent();
            treeMain.NodeMouseClick += (sender, args) => treeMain.SelectedNode = args.Node;
            treeMain.MouseDown += (sender, args) => treeMain_MouseDown(sender, args);
            ImageList imageList = new ImageList();
            System.Drawing.Image image1 = System.Drawing.Image.FromFile(@"icons8-ptz-camera-48.ico");
            imageList.Images.Add(image1);
            treeMain.ImageList = imageList;

            // For some reason in designer, these cursors keep reverting, so make sure they're normal.
            treeMain.Cursor = Cursors.Default;
            groupCamera.Cursor = Cursors.Default;
            groupCelestials.Cursor = Cursors.Default;
            splitContainer1.Panel1.Cursor = Cursors.Default;
            splitContainer1.Panel2.Cursor = Cursors.Default;

            LoadCameras();
            UpdateTreeView();
            frmLog.Show();
            CameraChecker.frmLog = frmLog;
        }

        async private void FindDevices()
        {
            frmLog.Log("Scanning for cameras");
            // Create a Discovery instance
            var onvifDiscovery = new Discovery();
            var onvifDevices = await onvifDiscovery.Discover(1);


            foreach (var device in onvifDevices)
            {
                frmLog.Log($"Found {device.Address}");
                Camera camera = new Camera();
                camera.IP = device.Address;
                camera.Addresses = device.XAdresses.ToList<string>();
                camera.Celestial = "None"; 
                cameras.Add(camera);
            }
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            Cursor.Current = Cursors.WaitCursor;
            treeMain.Nodes.Clear();
            treeMain.Nodes.Add("Cameras");
            treeMain.Nodes[0].Tag = "Cameras";
            
            foreach (Camera camera in cameras)
            {
                TreeNode tn = new TreeNode();
                tn.Text = camera.IP;
                tn.ImageIndex = 0;
                tn.Tag = "Camera";
                treeMain.Nodes[0].Nodes.Add(tn);
            }

            Cursor.Current = Cursors.Default;
        }

        private void SaveCameras()
        {
            if (!Directory.Exists(programdata))
            {
                Directory.CreateDirectory(programdata);
            }

            string json = JsonConvert.SerializeObject(cameras);
            File.WriteAllText(programdata + "cameras.json", json);
        }
        private void LoadCameras()
        {
            if (!File.Exists(programdata + "cameras.json"))
            {
                return;
            }
            string json = File.ReadAllText(programdata + "cameras.json");
            cameras = JsonConvert.DeserializeObject<List<Camera>>(json);
        }
        private void scanForCamerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindDevices();
        }

        // Display the appropriate context menu.
        private void treeMain_MouseDown(object sender, MouseEventArgs e)
        {
            // Select this node.
            TreeNode node_here = treeMain.GetNodeAt(e.X, e.Y);
            treeMain.SelectedNode = node_here;

            // See if we got a node.
            if (node_here == null)
            {
                return;
            }
            else if (e.Button == MouseButtons.Left)
            {
                foreach (Camera camera in cameras)
                {
                    if (node_here.Text == camera.IP)
                    {
                        txtIPAddress.Text = camera.IP;
                        txtName.Text = camera.Name;
                        txtUserName.Text = camera.User;
                        txtPassword.Text = camera.Password;
                        txtLatitude.Text = camera.Location.latitude.ToString();
                        txtLongitude.Text = camera.Location.longitude.ToString();
                        txtAltitude.Text = camera.Location.height.ToString();
                        lbAddresses.Items.Clear();
                        foreach (string s in camera.Addresses)
                        {
                            lbAddresses.Items.Add(s);
                        }
                        SetCelestial(camera.Celestial);
                        txtHeading.Text = camera.Heading.ToString();
                    }
                }
            }
        }


        private string GetCelestial()
        {
            string celestial = "";
            if (rbJupiter.Checked)
            {
                celestial = "Jupiter";
            }
            if (rbMars.Checked)
            {
                celestial = "Mars";
            }
            if (rbMercury.Checked)
            {
                celestial = "Mercury";
            }
            if (rbMoon.Checked)
            {
                celestial = "Moon";
            }
            if (rbSaturn.Checked)
            {
                celestial = "Saturn";
            }
            if (rbSun.Checked)
            {
                celestial = "Sun";
            }
            if (rbVenus.Checked)
            {
                celestial = "Venus";
            }
            if (rbNone.Checked)
            {
                celestial = "None";
            }
            return celestial;
        }
        private void SetCelestial(string celestial)
        {
            switch (celestial)
            {
                case "Venus":
                    rbVenus.Checked = true; break;
                case "Sun":
                    rbSun.Checked = true; break;
                case "Mars":
                    rbMars.Checked = true; break;
                case "Saturn":
                    rbSaturn.Checked = true; break;
                case "Moon":
                    rbMoon.Checked = true; break;
                case "Mercury":
                    rbMercury.Checked = true; break;
                case "Jupiter":
                    rbJupiter.Checked = true; break;
                default:
                    rbNone.Checked = true; break;
            }
        }
        private void btnSaveCamera_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Camera camera in cameras)
            {
                if (camera.IP == txtIPAddress.Text)
                {
                    camera.Name = txtName.Text;
                    camera.User = txtUserName.Text;
                    camera.Password = txtPassword.Text;
                    Observer location = new Observer(Convert.ToDouble(txtLatitude.Text), Convert.ToDouble(txtLongitude.Text), Convert.ToDouble(txtAltitude.Text));
                    camera.Location = location;
                    camera.Celestial = GetCelestial();
                    camera.Heading = Convert.ToDouble(txtHeading.Text);
                    found = true;
                }
            }
            if (!found)
            {
                // add new
                Camera camera = new Camera();
                camera.Name = txtName.Text;
                camera.User = txtUserName.Text;
                camera.Password = txtPassword.Text;
                Observer location = new Observer(Convert.ToDouble(txtLatitude.Text), Convert.ToDouble(txtLongitude.Text), Convert.ToDouble(txtAltitude.Text));
                camera.Location = location;
                camera.Celestial = GetCelestial();
                cameras.Add(camera);
            }
            SaveCameras();
        }

        private void timerCameraCheck_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Updating cameras...";
            CameraChecker.CheckCameras(cameras);
            lblStatus.Text = "Idle";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}