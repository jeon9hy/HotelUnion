using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelUnionClient.Helper
{
    public static class Config
    {
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string sAppName, string sKeyName, string sDefault, StringBuilder sReturnedString, int nSize, string sFileName);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string sAppName, string sKeyName, string sValue, string sFileName);

        public static string sINIPath = System.Windows.Forms.Application.StartupPath + "\\Config\\Config.ini";

        /// <summary>
        /// 이 부분은 너가 ini 파일에서 읽어오거나 저장할때 사용할 변수 리스트
        /// </summary>
        public static string Email = string.Empty;
        public static string Email_RememberMe = string.Empty;

        /// <summary>
        /// 여기는 너가 위 변수에 ini 파일에 대한 값을 읽어서 저장하는 로직
        /// </summary>
        public static void LoadInIFile()
        {
            /// 예시
            StringBuilder Buf = new StringBuilder(1024);

            GetPrivateProfileString("USER", "EMAIL", "", Buf, 1024, sINIPath);
            Email = Buf.ToString();
        }


        /// <summary>
        /// 위 변수에 저장되어 있는 값을 ini파일에 쓰는 로직
        /// </summary>
        public static void SaveINIFile()
        {
            WritePrivateProfileString("USER", "EMAIL", Email, sINIPath);
        }

    }
}
