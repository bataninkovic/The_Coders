using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Database : IDisposable
    {
        #region Singleton Support
        private static Database s_instance = null;

        public static Database Instance()
        {
            if (s_instance == null)
            {
                s_instance = new Database();
            }
            return s_instance;
        }

        public static void Destroy()
        {
            if (s_instance != null)
            {
                s_instance.Dispose();
                s_instance = null;
            }
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                if (d_sqlConnection != null)
                {
                    d_sqlConnection.Close();
                }
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Database() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        private Database()
        {
            string hostName = System.Net.Dns.GetHostName();
            d_sqlConnection = new SqlConnection(@"Data Source=" + hostName + "\\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");
            d_sqlConnection.Open();
        }

        private SqlConnection d_sqlConnection = null;

        public SqlConnection Connection { get { return d_sqlConnection; } }

    }
}
