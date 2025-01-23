using System.Data;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormLogin());
            //Application.Run(new FormAdminInventory());
            //Application.Run(new FormEditInventory("i-005"));
            //Application.Run(new FormAddInventory());
            Application.Run(new FormExpense());
            //Application.Run(new FormAddExpense("U-001"));
            //Application.Run(new FormUsers());

            //try
            //{
            //    DataAccess da = new DataAccess();

            //    string query = "select * from users";
            //    DataSet ds = da.ExecuteQuery(query);

            //    MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("hello");
            //}
        }
    }
}