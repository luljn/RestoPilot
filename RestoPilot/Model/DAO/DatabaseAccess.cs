using System.Data;
using System.Data.SqlClient;

namespace RestoPilot.Model.DAO;

public class DatabaseAccess {
    public string Cnx;
    private string RqSql;

    public DatabaseAccess() {
        
        this.Cnx = "Server=localhost\\SQLEXPRESS;Database=RestoPilot;Trusted_Connection=True;";
        this.RqSql = "";
        this.SqlDataAdapter = new SqlDataAdapter();
        this.SqlConnection = new SqlConnection(this.Cnx);
        this.SqlCommand = new SqlCommand();
        this.DataSet = new DataSet();
    }

    private SqlDataAdapter SqlDataAdapter { set; get; }
    private SqlConnection SqlConnection { get; }
    private SqlCommand SqlCommand { set; get; }
    private DataSet DataSet { get; }
}