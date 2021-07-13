import java.sql.*;

public class Database {
	private Connection conn;
	private Statement stmt;
	ResultSet result=null;

	public Database(){
		try{
			Class.forName("com.mysql.jdbc.Driver");
			String url="jdbc:mysql://localhost:3306/test";  //    
			conn=DriverManager.getConnection(url, "root", "root");
			stmt=conn.createStatement();
		}
		catch(ClassNotFoundException ex){
			ex.printStackTrace();
		}
		catch(SQLException ex){
			ex.printStackTrace();
		}
	}


	//adds table to database
	void addTable(String table) {
		dropTable(table); //drops other existing table of the same name
		try{
			stmt.executeUpdate("CREATE TABLE "+table+" (ID varchar(50), Age int, Prescription int, docId int, treatType int)");
		}
		catch(SQLException ex){
			ex.printStackTrace();
		}
	}

	//inserts patient data into table
	void insert(String table, int ID, int Age, int Prescription, int docId, int treatType) {
		try{
			stmt.executeUpdate("INSERT INTO "+table+" VALUES('"+ID+"', "+ Age+", "+ Prescription+" , "+ docId+" , "+ treatType+")");
		}
		catch(SQLException ex){
			ex.printStackTrace();
		}
	}

	//deletes table
	void dropTable(String tableN){
		try{
			stmt.executeUpdate("Drop TABLE "+tableN);
		}
		catch(SQLException ex){
		}
	}


}


