package controller;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import bean.hangdt_bean;
import bo.hang_bo;
import bo.hangdt_bo;

/**
 * Servlet implementation class AdminQLLoaiController
 */
@WebServlet("/AdminQLLoaiController")
public class AdminQLLoaiController extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public AdminQLLoaiController() {
        super();
        // TODO Auto-generated constructor stub
    }

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		try {
			response.setCharacterEncoding("utf-8");
			request.setCharacterEncoding("utf-8");
			ArrayList<hangdt_bean> dsh = new ArrayList<hangdt_bean>();
			hang_bo hbo=new hang_bo();
			hangdt_bo hdtbo=new hangdt_bo();
			String tab=request.getParameter("tab");
			String mahang=request.getParameter("txtmaloai");
			String tenhang=request.getParameter("txttenloai");
			if(request.getParameter("butadd")!=null)
			{
				hdtbo.ThemLoai(mahang, tenhang);
			}
			else {
				if(request.getParameter("butupdate")!=null) {
					hdtbo.SuaLoai(mahang, tenhang);
				}else {
					String maloaic=request.getParameter("ml");
					String tenloaic=request.getParameter("tl");
					if(tab!=null && tab.equals("xoa"))
					{
						hdtbo.XoaLoai(maloaic);
					}
					else
						if(tab!=null && tab.equals("chon"))
						{
							request.setAttribute("ml", maloaic.trim());
							request.setAttribute("tl", tenloaic);
						}
				}
			}
			request.setAttribute("dsloai",hbo.getHangDT());	
			RequestDispatcher rd=request.getRequestDispatcher("AdminQLLoai.jsp");
			rd.forward(request, response);
		} catch (Exception e) {
			// TODO: handle exception
		}
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
