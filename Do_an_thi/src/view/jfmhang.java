package view;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import bean.hanghoabean;
import bo.hangbo;
import dao.coso;
import dao.hanghoadao;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JTabbedPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Rectangle;
import java.awt.Label;
import java.awt.Point;
import java.awt.Dimension;
import java.awt.Color;

public class jfmhang extends JFrame {

	private JPanel contentPane;
	private JTextField txtmh;
	private JTextField txtth;
	private JTextField txtgb;
	private JTextField txtncc;
	private JTextField txttk;
	private JTable table;

	/**
	 * Launch the application.
	 */
	static ArrayList<hanghoabean> ds=new ArrayList<hanghoabean>();
	hangbo bo=new hangbo();
	hanghoadao dao=new hanghoadao();
	ArrayList<hanghoabean> dshh;
	
	void NapBang(ArrayList<hanghoabean> ds) {
		DefaultTableModel mh= new DefaultTableModel();
		String[] tieude= {"Ma hang hoa","Ten hang hoa","Gia ban","Nha cung cap","Ton kho"};
		mh.setColumnIdentifiers(tieude);
		table.setModel(mh);
		for(hanghoabean hh:ds)
		{
			Object[] t= new Object[7];
			t[0]=hh.getMahang();
			t[1]=hh.getTenhang();
			t[2]=hh.getGiaban();
			t[3]=hh.getNcc();
			t[4]=hh.getTonkho();
			mh.addRow(t);
		}
		
	}
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				
				try {
					
					jfmhang frame = new jfmhang();
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
	public jfmhang() {
		setIconImage(new ImageIcon(getClass().getResource ("clipboard-icon.png")).getImage());
		setTitle("Quản lý hàng");
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) {
				try {
					
					coso cs=new coso();
					cs.KetNoi();
					dshh =bo.getdv();
					NapBang(dshh);
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 537, 376);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("Mã hàng");
		lblNewLabel.setBounds(10, 25, 76, 13);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Tên hàng");
		lblNewLabel_1.setBounds(10, 48, 76, 13);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Giá bán");
		lblNewLabel_2.setBounds(10, 71, 76, 13);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Nhà cung cấp");
		lblNewLabel_3.setBounds(10, 94, 83, 13);
		contentPane.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Tồn kho");
		lblNewLabel_4.setBounds(10, 117, 76, 13);
		contentPane.add(lblNewLabel_4);
		
		txtmh = new JTextField();
		txtmh.setBounds(96, 22, 205, 19);
		contentPane.add(txtmh);
		txtmh.setColumns(10);
		
		txtth = new JTextField();
		txtth.setBounds(96, 45, 205, 19);
		contentPane.add(txtth);
		txtth.setColumns(10);
		
		txtgb = new JTextField();
		txtgb.setBounds(96, 68, 205, 19);
		contentPane.add(txtgb);
		txtgb.setColumns(10);
		
		txtncc = new JTextField();
		txtncc.setBounds(96, 91, 205, 19);
		contentPane.add(txtncc);
		txtncc.setColumns(10);
		
		txttk = new JTextField();
		txttk.setBounds(96, 114, 205, 19);
		contentPane.add(txttk);
		txttk.setColumns(10);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		tabbedPane.setBounds(36, 157, 445, 172);
		contentPane.add(tabbedPane);
		
		JScrollPane scrollPane = new JScrollPane();
		tabbedPane.addTab("Danh sach", null, scrollPane, null);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {
				int d=table.getSelectedRow();
				String th=table.getValueAt(d, 0).toString();
				txtmh.setText(th);
				String th1=table.getValueAt(d, 1).toString();
				txtth.setText(th1);
				String th2=table.getValueAt(d, 2).toString();
				txtgb.setText(th2);
				String th3=table.getValueAt(d, 3).toString();
				txtncc.setText(th3);
				String th4=table.getValueAt(d, 4).toString();
				txttk.setText(th4);
			}
		});
		scrollPane.setViewportView(table);
		//them
		JButton btnNewButton = new JButton("");
		btnNewButton.setIcon(new ImageIcon(jfmhang.class.getResource("/view/icon/add-1-icon.png")));
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String dv=txtmh.getText();
				String dv1=txtth.getText();
				double dv2=Double.parseDouble(txtgb.getText());
				String dv3=txtncc.getText();
				double dv4=Double.parseDouble(txttk.getText());
				if(dv.equals("")||dv1.equals("")||dv3.equals(""))
				{
					JOptionPane.showMessageDialog(null, "Hãy điền đủ thông tin!");
					return;
				}
				try {
					bo.Them(dv, dv1, dv2, dv3, dv4);
					NapBang(dshh);
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		btnNewButton.setBounds(360, 23, 57, 36);
		contentPane.add(btnNewButton);
		//Sua
		JButton btnNewButton_1 = new JButton("");
		btnNewButton_1.setIcon(new ImageIcon(jfmhang.class.getResource("/view/icon/62971-gear-icon.png")));
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
					String dv=txtmh.getText();
					String dv1=txtth.getText();
					double dv2=Double.parseDouble(txtgb.getText());
					String dv3=txtncc.getText();
					double dv4=Double.parseDouble(txttk.getText());
					
					try {
						bo.Sua(dv, dv1, dv2, dv3, dv4);
					    NapBang (dshh);
					 } catch (Exception e2) {
					    e2. printStackTrace();
			}}
			
		});
		btnNewButton_1.setBounds(427, 23, 57, 36);
		contentPane.add(btnNewButton_1);
		//Xoa
		JButton btnNewButton_2 = new JButton("");
		btnNewButton_2.setIcon(new ImageIcon(jfmhang.class.getResource("/view/icon/Button-Delete-icon.png")));
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int a= JOptionPane.showConfirmDialog(null, "Xac nhan xoa!");
				if(a==0) {
				try {
					bo.Xoa(txtmh.getText());
					NapBang(dshh);
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}}
		});
		btnNewButton_2.setBounds(360, 68, 57, 36);
		contentPane.add(btnNewButton_2);
		//tim
		JButton btnNewButton_3 = new JButton("");
		btnNewButton_3.setIcon(new ImageIcon(jfmhang.class.getResource("/view/icon/search-icon.png")));
		btnNewButton_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String key=JOptionPane.showInputDialog("Nhap ma nha cung cap can tim:");
				try {
					NapBang(bo.Tim(key));
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
				
			}
		});
		btnNewButton_3.setBounds(427, 68, 57, 36);
		contentPane.add(btnNewButton_3);
		
		JButton btnNewButton_4 = new JButton("Hiển thị ");
		btnNewButton_4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					NapBang(bo.Hienthi());
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		btnNewButton_4.setBounds(333, 116, 180, 21);
		contentPane.add(btnNewButton_4);
		
		JButton btnNewButton_5 = new JButton("Menu");
		btnNewButton_5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				menu f=new menu();
				f.setVisible(true);
//				dispose();
			}
		});
		btnNewButton_5.setBounds(381, 139, 85, 21);
		contentPane.add(btnNewButton_5);
		
	}
}
