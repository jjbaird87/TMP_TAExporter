using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Morpho.MorphoAcquisition;
using MSOSDK_MKIT_TESTER.Properties;

namespace MSOSDK_MKIT_TESTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            var versionInfo = FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + @"\Morpho.MorphoAcquisition.dll");
            string version = versionInfo.ProductVersion;

            //Copy all the files & Replaces any files with the same name
            if (Settings.Default.Mkit)
            {
                if (version != "1.2.7.0")
                {
                    foreach (var newPath in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\MorphoKit", "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath,
                            newPath.Replace(Directory.GetCurrentDirectory() + @"\MorphoKit",
                                Directory.GetCurrentDirectory()),
                            true);
                }
            }
            else
            {
                if (version != "1.2.8.0")
                {
                    foreach (var newPath in Directory.GetFiles(Directory.GetCurrentDirectory() + @"\MorphoSmart", "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath,
                            newPath.Replace(Directory.GetCurrentDirectory() + @"\MorphoSmart",
                                Directory.GetCurrentDirectory()),
                            true);
                }
            }

            InitializeComponent();
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            // Check that CLR is loading the version of ThirdPartyLibrary referenced by MyLibrary
            if (
                args.Name.Equals(
                    "Morpho.MorphoAcquisition, Version=1.2.7.0, Culture=neutral, PublicKeyToken=6c88356942c144bd"))
            {
                try
                {
                    var assembly = Assembly.LoadFrom("Morpho.MorphoAcquisition.dll");
                    return assembly;
                }
                catch (Exception)
                {
                    //Console.WriteLine(exception);
                }
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Mkit)
            {
                radMkit.Checked = true;
                var morphoAcquisitionComponent = new MorphoAcquisitionComponent(DeviceType.MORPHOKIT);

                var devices = morphoAcquisitionComponent.GetConnectedDevices();
                foreach (var device in devices)
                {
                    cmbDevices.Items.Add(device);
                }
            }
            else
            {
                radMsoSdk.Checked = true;
                var morphoAcquisitionComponent = new MorphoAcquisitionComponent(DeviceType.MORPHOSMART);

                var devices = morphoAcquisitionComponent.GetConnectedDevices();
                foreach (var device in devices)
                {
                    cmbDevices.Items.Add(device);
                }
            }
            if (cmbDevices.Items.Count > 0)
                cmbDevices.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MorphoAcquisitionComponent morphoAcquisitionComponent;
                if (radMsoSdk.Checked)
                {
                    morphoAcquisitionComponent = new MorphoAcquisitionComponent(DeviceType.MORPHOSMART);
                    morphoAcquisitionComponent.BindEnrollmentDevice(DeviceType.MORPHOSMART);

                    morphoAcquisitionComponent.DeviceName = cmbDevices.Items[0].ToString();
                    morphoAcquisitionComponent.Consolidation = true;
                    morphoAcquisitionComponent.ShowLiveQualityBar = true;
                    morphoAcquisitionComponent.ShowLiveQualityThreshold = true;
                    morphoAcquisitionComponent.AcceptBadQualityEnrollment = false;
                    morphoAcquisitionComponent.JuvenileMode = false;
                    morphoAcquisitionComponent.TemplateFormat = TemplateFormat.PKMAT;

                    var result = morphoAcquisitionComponent.RunEnroll();

                    if (result?.Status != ErrorCodes.IED_NO_ERROR) return;
                    var score = ((double) result.TemplateQuality/175)*100;
                    MessageBox.Show(score.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    morphoAcquisitionComponent = new MorphoAcquisitionComponent(DeviceType.MORPHOKIT);
                    morphoAcquisitionComponent.BindEnrollmentDevice(DeviceType.MORPHOKIT);

                    morphoAcquisitionComponent.DeviceName = cmbDevices.Items[0].ToString();
                    morphoAcquisitionComponent.Consolidation = true;
                    morphoAcquisitionComponent.ShowLiveQualityBar = true;
                    morphoAcquisitionComponent.ShowLiveQualityThreshold = true;
                    morphoAcquisitionComponent.AcceptBadQualityEnrollment = false;
                    morphoAcquisitionComponent.JuvenileMode = false;
                    morphoAcquisitionComponent.TemplateFormat = TemplateFormat.PKMAT;

                    var result = morphoAcquisitionComponent.RunEnroll();

                    if (result?.Status != ErrorCodes.IED_NO_ERROR) return;
                    var score = ((double) result.TemplateQuality/175)*100;
                    MessageBox.Show(score.ToString(CultureInfo.InvariantCulture));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radMkit_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Mkit = radMkit.Checked;
            Settings.Default.Save();
        }

        private void radMsoSdk_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}