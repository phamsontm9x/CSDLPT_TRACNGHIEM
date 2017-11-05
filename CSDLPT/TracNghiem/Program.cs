using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace TracNghiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static String serverName = "";
        public static String userName = "";
        public static String password = "";
        public static String loginName = "";

        public static String currentName = "";
        public static String currentPass = "";
        public static String currentUserName = "";
        public static String currentServer = "";
        public static String currentRole = "";
        public static int currentBranch = 0;

        public static String databaseName = "TRACNGHIEM";
        public static String remoteLogin = "SUPPORT";
        public static String remotePass = "123456";

        public static String connectStr;
        public static SqlConnection connect = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dataReader;
        public static Boolean isLogin = false;

        public static frmMain frmChinh;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }

        public static void getInforUserLoginSuccess(String serverName, String userName, String pass)
        {
            currentServer = serverName;
            currentUserName = userName;
            password = pass;
        }
    }
}
