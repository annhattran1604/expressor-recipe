package dangnhap;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import dao.coso;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.sql.PreparedStatement;
import java.util.ArrayList;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Label;
import java.awt.SystemColor;
import java.awt.Font;
import java.awt.Color;

public class dangky extends JFrame {

	private JPanel contentPane;
	private JTextField txt1;
	private JTextField txt2;
	private JTextField txt3;

	userdao dao=new userdao();
	/**
	 * Launch the application.
	 */
	ArrayList<userbean> ds=new ArrayList<userbean>();
	private JButton btnNewButton_1;
	private JLabel lblNewLabel_3;
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					dangky frame = new dangky();
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
	public dangky() {
		setIconImage(new ImageIcon(getClass().getResource ("User-Administrator-Blue-icon.png")).getImage());
		setTitle("Đăng ký");
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) {
				coso cs=new coso();
				cs.KetNoi();
				
			}
		});
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("T\u00EAn t\u00E0i kho\u1EA3n");
		lblNewLabel.setForeground(Color.RED);
		lblNewLabel.setBounds(72, 82, 99, 13);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("M\u1EADt kh\u1EA9u");
		lblNewLabel_1.setForeground(Color.RED);
		lblNewLabel_1.setBounds(72, 104, 99, 13);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Nh\u1EADp l\u1EA1i m\u1EADt kh\u1EA9u");
		lblNewLabel_2.setForeground(Color.RED);
		lblNewLabel_2.setBounds(72, 127, 110, 13);
		contentPane.add(lblNewLabel_2);
		
		txt1 = new JTextField();
		txt1.setBounds(187, 79, 173, 19);
		contentPane.add(txt1);
		txt1.setColumns(10);
		
		txt2 = new JTextField();
		txt2.setBounds(187, 101, 173, 19);
		contentPane.add(txt2);
		txt2.setColumns(10);
		
		txt3 = new JTextField();
		txt3.setBounds(187, 124, 173, 19);
		contentPane.add(txt3);
		txt3.setColumns(10);
		
		JButton btnNewButton = new JButton("Tạo tài khoản");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if(txt1.getText().equals("")||txt2.getText().equals(""))
					JOptionPane.showMessageDialog(null, "Loi dang ky!");
				else {
					if(txt2.getText().equals(txt3.getText())) {
						try {
							ArrayList<userbean> dsdao= dao.getdv();
							String tk=txt1.getText();
							String mk=txt2.getText();
						for(userbean dv: dsdao)
						{if(dv.getUsername().equals(tk))
						{
							JOptionPane.showMessageDialog(null, "Tài khoản này đã có!");
							return ;
						}}
						ds.add(new userbean(tk, mk));//Them vao bonho
						userdao.Them(tk, mk);
						JOptionPane.showMessageDialog(null, "Thêm thành công!");
				} catch (Exception e2) {
					// TODO Auto-generated catch block
					e2.printStackTrace();
				}}
					
				else JOptionPane.showMessageDialog(null, "Kiểm tra lại mật khẩu !");
				}}
			}
		);
		btnNewButton.setBounds(259, 167, 110, 21);
		contentPane.add(btnNewButton);
		
		btnNewButton_1 = new JButton("Đăng nhập");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dangnhap f=new dangnhap();
				f.setVisible(true);
				dispose();
			}
		});
		btnNewButton_1.setBounds(259, 198, 110, 21);
		contentPane.add(btnNewButton_1);
		
		lblNewLabel_3 = new JLabel("ĐĂNG KÝ TÀI KHOẢN");
		lblNewLabel_3.setForeground(Color.BLUE);
		lblNewLabel_3.setFont(new Font("Times New Roman", Font.BOLD, 19));
		lblNewLabel_3.setBounds(121, 29, 216, 22);
		contentPane.add(lblNewLabel_3);
	}

}
