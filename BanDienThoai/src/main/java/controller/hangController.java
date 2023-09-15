package controller;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import bean.hang_bean;
import bean.hangdt_bean;
import bo.giohang_bo;
import bo.hang_bo;

/**
 * Servlet implementation class hangController
 */
@WebServlet("/hangController")
public class hangController extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public hangController() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		response.setCharacterEncoding("utf-8");
		request.setCharacterEncoding("utf-8");
		ArrayList<hang_bean> ds;
		ArrayList<hangdt_bean> dshang;
		hang_bo hbo = new hang_bo();
		HttpSession session =request.getSession();
		try {
			ds = hbo.getHach();
			dshang = hbo.getHangDT();

			String madt = request.getParameter("madt");
			String tendt = request.getParameter("key");
			String all = request.getParameter("all");
			String moinhat = request.getParameter("new");
			String tang = request.getParameter("tang");
			String giam = request.getParameter("giam");
			if (all == null) {
				if (madt != null && tendt == null) {
					ds = hbo.TimMa(madt);
				}
				if (madt == null && tendt != null) {
					ds = hbo.TimDT(tendt);
				}

				if (moinhat != null && madt == null && tendt == null) {
					ds = hbo.MoiNhat();
				} else {
					if (tang != null) {
						hbo.TangDan();
					} else {
						if (giam != null)
							hbo.GiamDan();
					}
				}
			}

			// phan trang
			int trang = 0;
			int sophantu = 8;

			double sotrang = Math.ceil((double) ds.size() / sophantu);

			int phantubatdau = 0;
			int phantuketthuc = 0;

			if (request.getParameter("page") == null) {
				trang = 1;
			} else {
				trang = Integer.parseInt(request.getParameter("page"));
			}
			// bam nut toi va lui
			String tab = request.getParameter("tab");
			if (tab != null) {
				int tht = Integer.parseInt(request.getParameter("tht"));
				if (tab.equals("toi")&&sotrang>tht) {
					trang = tht + 1;
				}
				if (tab.equals("lui")&&sotrang<=tht) {
					trang = tht - 1;
				}
				
			}
			phantubatdau = (trang - 1) * sophantu;
			phantuketthuc = Math.min(phantubatdau + sophantu, ds.size());
			List<hang_bean> dshientai = ds.subList(phantubatdau, phantuketthuc);

			request.setAttribute("tranghientai", trang);
			request.setAttribute("dshientai", dshientai);
			request.setAttribute("sotrang", sotrang);
			// thông báo đăng nhập lỗi

			String err2 = (String) request.getAttribute("err2");
			request.setAttribute("err2", err2);
			//lấy số lượng giỏ hàng
			giohang_bo gio=null;
			long n=0;
			if((giohang_bo)session.getAttribute("giohang")!=null)
			{
				gio=(giohang_bo)session.getAttribute("giohang");
				n= gio.ds.size();
			}
			request.setAttribute("slgh", n);
			//lấy ds hãng điện thoại
			request.setAttribute("dshang", dshang);
			RequestDispatcher rd = request.getRequestDispatcher("trangchu.jsp");
			rd.forward(request, response);

		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

		doGet(request, response);
	}

}
