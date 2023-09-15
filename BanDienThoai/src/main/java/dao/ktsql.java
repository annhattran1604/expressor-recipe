package dao;

import java.sql.Connection;
import java.sql.DriverManager;

public class ktsql {
	public Connection cn;
	public void ketnoi() throws Exception{
		Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		String url="jdbc:sqlserver://DESKTOP-HPRJ4H7:1433;databaseName=bandt; user=sa; password=123456";
		cn=DriverManager.getConnection(url);
		System.out.print("Da Ket Noi");
	}
}
