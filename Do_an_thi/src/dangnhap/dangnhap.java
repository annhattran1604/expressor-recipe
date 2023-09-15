package dangnhap;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import dao.coso;
import view.menu;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPasswordField;
import javax.swing.JTextField;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.awt.Label;
import java.awt.Color;
import java.awt.SystemColor;
import java.awt.Font;

public class dangnhap extends JFrame {

	private JPanel contentPane;
	private JPasswordField txtmk;
	private JTextField txttk;
	private JButton btnNewButton_1;
	
	/**
	 * Launch the application.
	 */
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					dangnhap frame = new dangnhap();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public dangnhap() {
		setIconImage(new ImageIcon(getClass().getResource ("User-Administrator-Blue-icon.png")).getImage());
		setTitle("Đăng nhập");
		txtmk = new JPasswordField();
		txttk = new JTextField();
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("T\u00E0i kho\u1EA3n");
		lblNewLabel.setFont(new Font("Tahoma", Font.BOLD, 13));
		lblNewLabel.setForeground(new Color(255, 0, 0));
		lblNewLabel.setBounds(60, 88, 68, 19);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel(" M\u1EADt kh\u1EA9u");
		lblNewLabel_1.setFont(new Font("Tahoma", Font.BOLD, 13));
		lblNewLabel_1.setForeground(new Color(255, 0, 0));
		lblNewLabel_1.setBounds(60, 111, 68, 19);
		contentPane.add(lblNewLabel_1);
		
		
		txtmk.setBounds(138, 111, 170, 19);
		contentPane.add(txtmk);
		
		
		txttk.setBounds(138, 88, 170, 19);
		contentPane.add(txttk);
		txttk.setColumns(10);
		
		JButton btnNewButton = new JButton("\u0110\u0103ng nh\u1EADp");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
				String userName=txttk.getText();
				String password = String.valueOf(txtmk.getPassword());
				if(userName.equals("")||password.equals("")) {
					JOptionPane.showMessageDialog(null, "Loi dang nhap!");
					return;}
				Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
    			//System.out.println("Da xac dinh HQTCSDL");
    			String st1=
    					"jdbc:sqlserver://DESKTOP-HPRJ4H7:1433;databaseName=qlbh; user=sa; password=123456";
    			Connection cn=DriverManager.getConnection(st1);

                PreparedStatement st = (PreparedStatement) cn.prepareStatement("Select username, password from [nguoidung] where username=? and password=?");

                st.setString(1, userName);
                st.setString(2, password);
                ResultSet rs = st.executeQuery();
                if (rs.next()) {
                    dispose(); //dang nhap xong tat cua so dn
                    menu f=new menu();
                    f.setVisible(true);
                    //JOptionPane.showMessageDialog(btnNewButton, "ĐN Thành công!");
                } else {
                    JOptionPane.showMessageDialog(btnNewButton, "Wrong Username or Password!");
                }
            } catch (SQLException sqlException) {
                sqlException.printStackTrace();
            } catch (Exception e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		}
		});
		btnNewButton.setBounds(91, 165, 118, 21);
		contentPane.add(btnNewButton);
		
		btnNewButton_1 = new JButton("\u0110\u0103ng k\u00FD");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dangky f=new dangky();
				f.setVisible(true);
				dispose();
			}
		});
		btnNewButton_1.setBounds(239, 165, 118, 21);
		contentPane.add(btnNewButton_1);
		
		JLabel lblNewLabel_2 = new JLabel("Qu\u1EA3n l\u00FD h\u00E0ng");
		lblNewLabel_2.setFont(new Font("Times New Roman", Font.BOLD, 19));
		lblNewLabel_2.setForeground(new Color(0, 0, 255));
		lblNewLabel_2.setBounds(166, 20, 154, 56);
		contentPane.add(lblNewLabel_2);
		
		JButton btnNewButton_2 = new JButton("Cancel");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnNewButton_2.setBounds(272, 196, 85, 21);
		contentPane.add(btnNewButton_2);
		
		JLabel lblNewLabel_3 = new JLabel("Yêu cầu nhập đúng ");
		lblNewLabel_3.setBounds(166, 140, 123, 13);
		contentPane.add(lblNewLabel_3);
	}
}
