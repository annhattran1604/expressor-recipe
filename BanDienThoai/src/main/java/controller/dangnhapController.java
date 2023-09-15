package controller;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import bean.kh_bean;
import bo.KH_bo;
import nl.captcha.Captcha;

/**
 * Servlet implementation class dangnhapController
 */
@WebServlet("/dangnhapController")
public class dangnhapController extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public dangnhapController() {
		super();

	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String un = request.getParameter("txtus");
		String pass = request.getParameter("txtpass");
		KH_bo khbo = new KH_bo();
		HttpSession session = request.getSession();
		Integer loginAttempts = (Integer) session.getAttribute("loginAttempts");
	    Captcha captcha = (Captcha) session.getAttribute(Captcha.NAME);
	    request.setCharacterEncoding("UTF-8");
	    String answer = request.getParameter("answer");
	    if (loginAttempts == null) {
	        loginAttempts = 0;
	    }
		try {
		if (un != "" && pass != "") {
				kh_bean kh = khbo.ktdn(un, pass);			
				if (kh != null || (kh != null && captcha.isCorrect(answer))) {
					if(khbo.ktadmin(un)!=0)
					{
						session.setAttribute("loginAttempts",0);
						response.sendRedirect("AdminQLDTController");
					}
					session.setAttribute("dn", kh);
					request.setAttribute("err2", "Đăng nhập thành công!");
					session.setAttribute("loginAttempts",0);
					System.out.println(khbo.ktadmin(un));
					RequestDispatcher rd = request.getRequestDispatcher("hangController");
					rd.forward(request, response);
					
				}
				else {
					// trả về thông báo lỗi
					request.setAttribute("err", "Tài khoản mật khẩu không đúng!");
					loginAttempts++;
					session.setAttribute("loginAttempts",loginAttempts);
					RequestDispatcher rd = request.getRequestDispatcher("dangnhap.jsp");
					rd.forward(request, response);
				}	
		}
		else{
			request.setAttribute("err", "Phải điền đủ thông tin!");
			loginAttempts++;
			session.setAttribute("loginAttempts",loginAttempts);
			RequestDispatcher rd = request.getRequestDispatcher("dangnhap.jsp");
			rd.forward(request, response);
		}
		String dx = request.getParameter("dx");
		if (dx != null) 
		{
			session.removeAttribute("dn");
			response.sendRedirect("hangController");
		}
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		//đăng xuất
		
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
