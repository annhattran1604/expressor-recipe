package view;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import bean.hanghoabean;
import bo.hangbo;
import dao.coso;
import dao.hanghoadao;

import javax.swing.JLabel;
import java.awt.Choice;
import java.awt.Label;
import javax.swing.JTextField;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.ArrayList;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.Font;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.ImageIcon;
import java.awt.Color;

public class jfmbaocao extends JFrame {

	private JPanel contentPane;
	private JTextField txtsltk;
	private JTextField txtgiatk;
	private JTextField txttien;

	/**
	 * Launch the application.
	 */
	jfmhang h=new jfmhang();
	hanghoabean bean=new hanghoabean();
	hangbo bo=new hangbo();
	hanghoadao dao=new hanghoadao();
	private JTextField txtghi;
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					jfmbaocao frame = new jfmbaocao();
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
	public jfmbaocao() {
		setTitle("Thống kê báo cáo");
		Choice choice = new Choice();
		choice.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				String a=choice.getSelectedItem();
				try {
					for(hanghoabean hh: dao.getdv())
					{
						if(hh.getTenhang().equals(a))
						{
							txtsltk.setText(String.valueOf(hh.getTonkho()));
							double gia=hh.getGiaban()*hh.getTonkho();
							txtgiatk.setText(String.valueOf(gia));
							if(hh.getTonkho()>5)
							{
								txtghi.setText("Số lượng còn đủ chưa cần nhập thêm!");
							}
							else {
								txtghi.setText("Cần nhập thêm hàng!");
							}
							String mn=txtgiatk.getText();
							docso ds=new docso();
							ArrayList<String> kq= docso.readNum1(mn);
							String thanhtien = "" ;
				            for (int i = 0; i < kq.size(); i++) {
				            	thanhtien+=kq.get(i)+ " ";
				            	
				            }
				            txttien.setText(thanhtien+"$");
							
						}
					}
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		txtsltk = new JTextField();
		txtgiatk = new JTextField();
		txttien = new JTextField();
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) {
				try {
					coso cs=new coso();
					cs.KetNoi();
					for(hanghoabean hh: dao.getdv()) {
						choice.add(hh.getTenhang());
						if(hh.getTenhang().equals(choice.getSelectedItem()))
						{
							txtsltk.setText(String.valueOf(hh.getTonkho()));
							double gia=hh.getGiaban()*hh.getTonkho();
							txtgiatk.setText(String.valueOf(gia));
							if(hh.getTonkho()>5)
							{
								txtghi.setText("Số lượng còn đủ chưa cần nhập thêm!");
							}
							else {
								txtghi.setText("Cần nhập thêm hàng!");
							}
							String mn=txtgiatk.getText();
							docso ds=new docso();
							ArrayList<String> kq= docso.readNum1(mn);
							String thanhtien = "" ;
				            for (int i = 0; i < kq.size(); i++) {
				            	thanhtien+=kq.get(i)+ " ";
				            	
				            }
				            txttien.setText(thanhtien+"$");
							
						}
					}
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 538, 247);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("⌂Tên Hàng");
		lblNewLabel.setForeground(new Color(0, 0, 139));
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblNewLabel.setBounds(30, 25, 130, 21);
		contentPane.add(lblNewLabel);
		
		
		choice.setBounds(170, 25, 157, 18);
		contentPane.add(choice);
		
		JLabel lblNewLabel_1 = new JLabel("⌂Số lượng tồn kho");
		lblNewLabel_1.setForeground(new Color(0, 0, 139));
		lblNewLabel_1.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblNewLabel_1.setBounds(30, 48, 130, 21);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("⌂Giá trị tồn kho");
		lblNewLabel_2.setForeground(new Color(0, 0, 139));
		lblNewLabel_2.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblNewLabel_2.setBounds(30, 71, 130, 21);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("⌂Thành tiền");
		lblNewLabel_3.setForeground(new Color(0, 0, 139));
		lblNewLabel_3.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblNewLabel_3.setBounds(30, 94, 130, 21);
		contentPane.add(lblNewLabel_3);
		
		
		txtsltk.setBounds(170, 49, 157, 19);
		contentPane.add(txtsltk);
		txtsltk.setColumns(10);
		
		
		txtgiatk.setBounds(170, 73, 157, 19);
		contentPane.add(txtgiatk);
		txtgiatk.setColumns(10);
		
		
		txttien.setBounds(169, 99, 284, 19);
		contentPane.add(txttien);
		txttien.setColumns(10);
		
		JLabel lblNewLabel_4 = new JLabel("⁕ Ghi chú");
		lblNewLabel_4.setForeground(new Color(255, 0, 0));
		lblNewLabel_4.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblNewLabel_4.setBounds(44, 121, 97, 25);
		contentPane.add(lblNewLabel_4);
		
		txtghi = new JTextField();
		txtghi.setBounds(142, 122, 311, 28);
		contentPane.add(txtghi);
		txtghi.setColumns(10);
		
		JButton btnNewButton = new JButton("MENU");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				menu f=new menu();
				f.setVisible(true);
				
			}
		});
		btnNewButton.setBounds(276, 171, 85, 21);
		contentPane.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("EXIT");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnNewButton_1.setBounds(408, 171, 85, 21);
		contentPane.add(btnNewButton_1);
		
		JLabel lblNewLabel_5 = new JLabel("");
		lblNewLabel_5.setIcon(new ImageIcon(jfmbaocao.class.getResource("/view/icon/702bf928e91ac894c7930e73e2347ddf.jpeg")));
		lblNewLabel_5.setBounds(-16, -50, 602, 317);
		contentPane.add(lblNewLabel_5);
		
	}
}
