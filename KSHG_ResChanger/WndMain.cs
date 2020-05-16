using System;
using System.IO;
using System.Windows.Forms;

namespace KSHG_ResChanger
{
    public partial class WndMain : Form
    {
        
        public WndMain()
        {
            InitializeComponent();
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select your \"KSHG.exe\" or \"KSHG_no_cursor.exe\"";
            openFileDialog1.Filter = "Executable (*.exe) | *.exe;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_FilePath.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_Patch_Click(object sender, EventArgs e)
        {
            if (Txt_FilePath.Text.Length != 0 && Txt_ResX.Text.Length != 0 && Txt_ResY.Text.Length != 0)
            {
                Int32 X;
                Int32 Y;
                float TargetX;
                float TargetY;

                if (!Int32.TryParse(Txt_ResX.Text, out X))
                {
                    MessageBox.Show("X resolution : " + Txt_ResX.Text + "is not a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Int32.TryParse(Txt_ResY.Text, out Y))
                {
                    MessageBox.Show("Y resolution : " + Txt_ResY.Text + "is not a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(Txt_ResX.Text, out TargetX))
                {
                    MessageBox.Show("X resolution : " + Txt_ResX.Text + "is not a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(Txt_ResY.Text, out TargetY))
                {
                    MessageBox.Show("Y resolution : " + Txt_ResY.Text + "is not a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] XArray = BitConverter.GetBytes(X);
                byte[] YArray = BitConverter.GetBytes(Y);
                
                try
                {
                    WriteLog("Opening " + Txt_FilePath.Text + " ...");
                    using (BinaryWriter bw = new BinaryWriter(File.Open(Txt_FilePath.Text, FileMode.Open, FileAccess.ReadWrite)))
                    {
                        //Patch to bypass the CRC-check of KSHG.exe
                        bw.BaseStream.Seek(0x000D7073, SeekOrigin.Begin);
                        bw.Write(new byte[] { 0x90, 0x90 });

                        //Removing green banner, directly taken from DjExpert on it's level-select binary package.
                        if (Chk_Banner.Checked)
                        {
                            bw.BaseStream.Seek(0x0028BA72, SeekOrigin.Begin);
                            bw.Write(new byte[] { 0x62, 0x70, 0x6C, 0x2F, 0x62, 0x61, 0x72, 0x2E, 0x64, 0x64, 0x73 });
                        }

                        //Pushing original value parameter for SetCursor call is removing mouse cursor on my computer, 
                        //whereas using "KSHG_noCursor.exe" - which is pushing 0 as parameter - still shows the  "wait" spinning cursor. 
                        //No guarantees on this patch...test to try.  
                        if (Chk_cursor.Checked)
                        {
                            bw.BaseStream.Seek(0x000062DA, SeekOrigin.Begin);
                            bw.Write(new byte[] { 0x6A, 0x00 });
                        }

                        // CreateWindow size
                        //WriteLog("Patch 1 : WinMain [0x000D048F, 0x000D0493]");
                        bw.BaseStream.Seek(0x000D048F, SeekOrigin.Begin);
                        bw.Write(YArray);
                        bw.BaseStream.Seek(0x000D0494, SeekOrigin.Begin);
                        bw.Write(XArray);

                        //WriteLog("Patch 2 : Sub_416130() -> Init Structure with (X,Y) at 3 different places");
                        bw.BaseStream.Seek(0x000161A5, SeekOrigin.Begin);
                        bw.Write(XArray);
                        bw.BaseStream.Seek(0x00016226, SeekOrigin.Begin);
                        bw.Write(XArray);
                        bw.BaseStream.Seek(0x00016236, SeekOrigin.Begin);
                        bw.Write(XArray);
                        bw.BaseStream.Seek(0x000161CA, SeekOrigin.Begin);
                        bw.Write(YArray);

                        //Viewport -> D3D rendering size
                        //Patching only this one causes bug to video and not a better 3D rendering
                        //WriteLog("Patch 3 : Sub_4082F0() -> X,Y as parameter for call");
                        bw.BaseStream.Seek(0x000083CF, SeekOrigin.Begin);
                        bw.Write(YArray);
                        bw.BaseStream.Seek(0x000083D4, SeekOrigin.Begin);
                        bw.Write(XArray);

                        //Fix 2D ennemies HitBox (leeches, coackroaches..)
                        //Game is using floating point values within a fixed range [X=>0-640, Y=>0-480]
                        //The purpose here is to convert coordinates from the new resolution to this needed range.
                        //This is done by adding a codecave in an empty space of the binary and make the code jump there when needed.
                        float Ratio2D_X = (float)640 / TargetX;
                        float Ratio2D_Y = (float)480 / TargetY;
                        WriteLog("Fixing 2D ennemies hitbox...");
                        bw.BaseStream.Seek(0x0027FFBC, SeekOrigin.Begin);
                        bw.Write(BitConverter.GetBytes(Ratio2D_X)); 
                        bw.Write(BitConverter.GetBytes(Ratio2D_Y)); 

                        bw.Write(new byte[] { 0xF3, 0x0F, 0x2A, 0x86, 0xDC, 0x00, 0x00, 0x00, 0xF3, 0x0F, 0x59, 0x05 });
                        bw.Write(new byte[] { 0xC0, 0xFF, 0x67, 0x00 });
                        bw.Write(new byte[] { 0xF3, 0x0F, 0x2D, 0xC0, 0xF3, 0x0F, 0x2A, 0x86, 0xD8, 0x00, 0x00, 0x00, 0xF3, 0x0F, 0x59, 0x05 });
                        bw.Write(new byte[] { 0xBC, 0xFF, 0x67, 0x00 });
                        bw.Write(new byte[] { 0xF3, 0x0F, 0x2D, 0xC8 });
                        bw.Write(new byte[] { 0xE9, 0x40, 0xA5, 0xE8, 0xFF });

                        bw.BaseStream.Seek(0x0010A525, SeekOrigin.Begin);
                        bw.Write(new byte[] {0xE9, 0x9A, 0x5A, 0x17, 0x00, 0x90});

                        //Fix 2D hitbox for selection (path, weapon)
                        //Same thing as above, but different code for a different place.
                        WriteLog("Fixing 2D options hitbox...");
                        bw.BaseStream.Seek(0x0023C285, SeekOrigin.Begin);
                        
                        bw.Write(new byte[] { 0xF3, 0x0F, 0x2A, 0x40, 0x04, 0xF3, 0x0F, 0x59, 0x05 });
                        bw.Write(new byte[] { 0xBC, 0xFF, 0x67, 0x00 });
                        bw.Write(new byte[] { 0xF3, 0x0F, 0x2D, 0xD8, 0x89, 0x5A, 0x04, 0xF3, 0x0F, 0x2A, 0x40, 0x08, 0xF3, 0x0F, 0x59, 0x05 });
                        bw.Write(new byte[] { 0xC0, 0xFF, 0x67, 0x00 });
                        bw.Write(new byte[] { 0xF3, 0x0F, 0x2D, 0xC0 });
                        bw.Write(new byte[] { 0xE9, 0xAB, 0x13, 0xEB, 0xFF });

                        bw.BaseStream.Seek(0x000ED651, SeekOrigin.Begin);
                        bw.Write(new byte[] { 0xE9, 0x2F, 0xEC, 0x14, 0x00, 0x90, 0x90, 0x90, 0x90 });                        
                    }
                    MessageBox.Show("Patch success !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Please fill all information before !", "Can't do that !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteLog(String Data)
        {
            /*Txt_Log.Text += "[" + DateTime.Now.ToString("HH:mm:ss") + " ]  " + Data + "\n";
            Txt_Log.ScrollToCaret();*/
        }
    }
}
