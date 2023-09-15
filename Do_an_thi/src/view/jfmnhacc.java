package view;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import bean.hanghoabean;
import bean.nhaccbean;
import bo.nhaccbo;
import dao.coso;
import dao.hanghoadao;
import dao.nhaccdao;

import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.Label;
import java.awt.Rectangle;
import java.awt.Choice;
import java.awt.TextField;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import java.awt.Component;
import javax.swing.JButton;
import javax.swing.ImageIcon;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import javax.swing.JTextField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Scrollbar;

public class jfmnhacc extends JFrame {

	private JPanel contentPane;
	private JTable table;
	TextField txttncc = new TextField();
	TextField txtncc = new TextField();
	TextField txtsdt = new TextField();
	TextField txtnht = new TextField();
	TextField txtdc = new TextField();
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					jfmnhacc frame = new jfmnhacc();
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
	nhaccbo bo=new nhaccbo();
	nhaccdao dao=new nhaccdao();
	ArrayList<nhaccbean> dstam;
	void NapBang(ArrayList<nhaccbean> ds) {
		DefaultTableModel mh= new DefaultTableModel();
		String[] tieude= {"Ma nha cung cap","Ten nha cung cap","Dia chi","SDT","Ngay hop tac"};
		mh.setColumnIdentifiers(tieude);
		table.setModel(mh);
		for(nhaccbean hh:ds)
		{
			Object[] t= new Object[7];
			t[0]=hh.getNcc();
			t[1]=hh.getTenncc();
			t[2]=hh.getDiachi();
			t[3]=hh.getSdt();
			t[4]=hh.getNgayhoptac();
			mh.addRow(t);
		}
		
	}
	public jfmnhacc() {
		setIconImage(new ImageIcon(getClass().getResource ("clipboard-icon.png")).getImage());
		setTitle("Quản lý nhà cung cấp");
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) {
				coso cs=new coso();
				cs.KetNoi();
				
				try {
					dstam = bo.getdv();
					NapBang(dstam);
//					for(nhaccbean cc: dao.getdv()) {
//						choice.add(cc.getDiachi());}
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {
				int d=table.getSelectedRow();
				String th=table.getValueAt(d, 1).toString();
				txttncc.setText(th);
				String th1=table.getValueAt(d, 2).toString();
				txtdc.setText(th1);
				String th2=table.getValueAt(d, 3).toString();
				txtsdt.setText(th2);
				String th3=table.getValueAt(d, 4).toString();
				txtnht.setText(th3);
				String th5=table.getValueAt(d, 0).toString();
				txtncc.setText(th5);
				//choice.select(th5);
			}
		});
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 450, 454);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("M\u00E3 nh\u00E0 cung c\u1EA5p");
		lblNewLabel.setBounds(22, 15, 105, 21);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("T\u00EAn nh\u00E0 cung c\u1EA5p");
		lblNewLabel_1.setBounds(21, 38, 105, 21);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("\u0110\u1ECBa ch\u1EC9");
		lblNewLabel_2.setBounds(22, 69, 105, 21);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("S\u1ED1 \u0111i\u1EC7n tho\u1EA1i");
		lblNewLabel_3.setBounds(22, 97, 105, 21);
		contentPane.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Ng\u00E0y h\u1EE3p t\u00E1c");
		lblNewLabel_4.setBounds(22, 124, 105, 21);
		contentPane.add(lblNewLabel_4);
		
		
		txttncc.setBounds(132, 42, 138, 21);
		contentPane.add(txttncc);
		
		
		txtncc.setBounds(133, 15, 138, 21);
		contentPane.add(txtncc);
		
		
		txtsdt.setBounds(133, 97, 138, 21);
		contentPane.add(txtsdt);
		
		
		txtnht.setBounds(133, 124, 138, 21);
		contentPane.add(txtnht);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		tabbedPane.setAlignmentX(Component.RIGHT_ALIGNMENT);
		tabbedPane.setBounds(22, 180, 392, 227);
		contentPane.add(tabbedPane);
		
		tabbedPane.addTab("Nhà cung cấp", null, table, null);
		
		JButton them = new JButton("");
		them.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					String dv=txtncc.getText();
					String dv1=txttncc.getText();
					String dv2=txtdc.getText();
					double dv3=Double.parseDouble(txtsdt.getText());
					SimpleDateFormat d= new SimpleDateFormat("yyyy-MM-dd");
					Date nht = d.parse(txtnht.getText());
					
					if(dv.equals("")||dv1.equals(""))
					{
						JOptionPane.showMessageDialog(null, "Hãy điền đủ thông tin!");
						return;
					}
					bo.Them(dv, dv1, dv2, dv3,  nht);
					NapBang(dstam);
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		them.setIcon(new ImageIcon(jfmnhacc.class.getResource("/view/icon/add-1-icon.png")));
		them.setBounds(314, 27, 45, 32);
		contentPane.add(them);
		
		JButton xoa = new JButton("");
		xoa.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int a= JOptionPane.showConfirmDialog(null, "Xac nhan xoa!");
				if(a==0) {
				try {
					bo.Xoa(txtncc.getText());
					NapBang(dstam);
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}}
		});
		xoa.setIcon(new ImageIcon(jfmnhacc.class.getResource("/view/icon/Button-Delete-icon.png")));
		xoa.setBounds(314, 69, 45, 32);
		contentPane.add(xoa);
		
		JButton btnNewButton_1 = new JButton("Menu");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				menu f=new menu();
				f.setVisible(true);
			}
		});
		btnNewButton_1.setBounds(308, 124, 106, 21);
		contentPane.add(btnNewButton_1);
		
		
		txtdc.setBounds(133, 69, 138, 21);
		contentPane.add(txtdc);
		
		JButton load = new JButton("");
		load.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					NapBang(bo.Load());
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		load.setIcon(new ImageIcon(jfmnhacc.class.getResource("/view/icon/loading-icon.png")));
		load.setBounds(369, 69, 45, 32);
		contentPane.add(load);
		
		JButton tim = new JButton("");
		tim.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String key=JOptionPane.showInputDialog("Nhap dia chi can tim:");
				try {
					NapBang(bo.TimDC(key));
				} catch (Exception e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		tim.setIcon(new ImageIcon(jfmnhacc.class.getResource("/view/icon/search-icon.png")));
		tim.setBounds(369, 27, 45, 32);
		contentPane.add(tim);
	}
}
