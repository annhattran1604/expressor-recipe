<%@page import="java.util.Locale"%>
<%@page import="java.text.NumberFormat"%>
<%@page import="bean.kh_bean"%>
<%@page import="bean.lichsu_bean"%>
<%@page import="java.util.ArrayList"%>
<%@page import="bo.giohang_bo"%>
<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>
<!DOCTYPE html>
<html>
<head>
<title>Lịch sử mua hàng</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
<link rel="stylesheet"
	href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
<script
	src="https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js"></script>
<script
	src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
<script
	src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<style>
.gradient-custom {
	background: rgb(238, 174, 202);
	background: radial-gradient(circle, rgba(238, 174, 202, 1) 0%,
		rgba(148, 187, 233, 0.5775560224089635) 100%);
}
/* Header */
#header {
	display: flex;
	cursor: pointer;
	align-items: center;
	background-color: #ffffff;
	position: relative;
	padding: 5px 0;
	background-color: #394777;
}

.header__logo img {
	width: 100px;
	height: 50px;
	margin: 0 100px;
	object-fit: cover;
	scale: 1.2;
	filter: grayscale();
}

.header__logo img:hover {
	scale: 1.5;
	filter: none;
}

.header__search {
	width: 60%;
	padding: 5px 20px;
	border-radius: 10px;
	background-color: #ffffff;
}

.header__search input, button {
	border: none;
	outline: none;
	font-size: 20px;
}

.header__search input {
	width: 90%;
}

.header__search button {
	float: right;
}

.text-center {
	transform: translateX(20%);
	margin-top: 5px;
	width: 70%;
	color: #D1A517;
	padding: 5px 0;
}

.header__history--2 {
	display: none;
}

.header__history a {
	margin-left: 70px;
}

.header__history a, .header__history--2 a:hover {
	color: black;
}

.header__history a, .header__history--2 a {
	padding: 10px;
	background-color: white;
	color: #D1A517;
	border-radius: 5px;
	text-decoration: none;
	font-weight: 700;
}
/* footer */
.footer-row {
	width: 100%;
	margin: 0 auto;
	display: flex;
	justify-content: space-around;
}

.footer-left, .footer-right {
	margin-bottom: 20px;
}

.footer-row h1 {
	line-height: 10px;
	margin-bottom: 20px;
}

.footer-row p {
	line-break: 30px;
}

.footer-between {
	text-align: center;
}
.text-center{
color:black;}

</style>
<body>
	<%
	response.setCharacterEncoding("utf-8");
	request.setCharacterEncoding("utf-8");
	giohang_bo s = new giohang_bo();
	if (session.getAttribute("giohang") != null) {
		s = (giohang_bo) session.getAttribute("giohang");
	}
	%>
	<div id="header">
		<div class="header__logo">
			<a href="hangController"><img src="img-phone/iconlogo.png" alt=""></a>
		</div>
		<div class="header__search">
			<form action="hangController" method="post">
				<input type="text" name="key" placeholder="Bạn muốn gì">
				<button type="submit" class="btn btn-primary">
					<i class="fas fa-search"></i>
				</button>
			</form>
		</div>
		<div class="header__history--2">
			<a href=""> <i class="fa-solid fa-clock-rotate-left"></i>
			</a>
		</div>
		<div class="header__history">
			<a href="giohangController"><i class="fa-solid fa-cart-shopping"></i>
				Giỏ hàng </a>
		</div>
	</div>

	<section class="h-100 gradient-custom">
		<div style="width: 100%" class="py-5 h-100">
			<div
				class="row d-flex justify-content-center align-items-center h-100">
				<div class="col-lg-10 col-xl-8">
					<div class="card" style="border-radius: 10px;">
						<div class="card-header px-4 py-5">
							<%
							if (session.getAttribute("dn") != null) {
							kh_bean name = (kh_bean) session.getAttribute("dn");
							%>
							<h5 class="text-muted mb-0">
								Thanks for your Order, <span style="color: #a8729a;"><%=name.getHoten()%></span>!
							</h5>
							<%} %>
						</div>
						<div class="card-body p-4">

							<div class="card shadow-0 border mb-4">
								<div class="card-body">
									<div class="row">
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="text-muted mb-0">Ngày Mua</p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="text-muted mb-0">Tên sản phẩm</p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="text-muted mb-0 small">Số lượng</p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="text-muted mb-0 small">Giá</p>
										</div>
										
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="text-muted mb-0 small">Thanh Toán</p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="text-muted mb-0 small">Thành Tiền</p>
										</div>
									</div>
									<hr class="mb-4" style="background-color: #e0e0e0; opacity: 1;">
									<%
									ArrayList<lichsu_bean> dsmh = (ArrayList<lichsu_bean>) request.getAttribute("lichsuMH");
									long size=dsmh.size();
									kh_bean kh = (kh_bean) session.getAttribute("dn");
									NumberFormat format = NumberFormat.getNumberInstance(new Locale("vi", "VN"));
									if (session.getAttribute("dn") != null) {
										for (lichsu_bean ls : dsmh) {
											String formatted = format.format(ls.getGia());
											String formattedTT = format.format(ls.getThanhTien());
									%>
									<div class="row">
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="mb-0"><%=ls.getNgaymua() %></p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="mb-0"><%=ls.getTendt() %></p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="mb-0 small"><%=ls.getSoluongmua() %></p>
										</div>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="mb-0 small"><%=formatted %></p>
										</div>
										
										<%
										if (ls.isDamua()) {
										%>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p style="color:green;" class="mb-0 small">Paid</p>
										</div>
										<%
										} else {
										%>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p style="color:red;" class="mb-0 small">Unpaid</p>
										</div>
										<%
										}
										%>
										<div
											class="col-md-2 text-center d-flex justify-content-center align-items-center">
											<p class="mb-0 small"><%=formattedTT %></p>
										</div>
									</div>
									<%
									}
									}
									if(size==0)
									{
									%>
									<div
											class="text-center d-flex justify-content-center align-items-center">
											<h3>Chưa mua hàng!</h3>
										</div>
									<%} %>
									<hr class="mb-4" style="background-color: #e0e0e0; opacity: 1;">
									<div class="row d-flex align-items-center"></div>
								</div>
							</div>


						</div>
						<%long tong=(long)request.getAttribute("tong"); 
						String formattedTong = format.format(tong);%>
						<div class="card-footer border-0 px-4 py-5"
							style="background-color: #093779; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px;">
							<h5
								class="d-flex align-items-center justify-content-end text-white text-uppercase mb-0">
								Total : <span class="h2 mb-0 ms-2"> <%=formattedTong %></span>
							</h5>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- footer -->
	<div class="footer-row">
		<div class="footer-left">
			<h3>Hỗ trợ</h3>
			<p>
				<i class="fa-solid fa-headset"></i> Mua hàng trực tuyến
			</p>
			<p>
				<i class="fa-solid fa-headset"></i> Các hình thức thanh toán
			</p>
			<p>
				<i class="fa-solid fa-headset"></i> Chính sách đổi trả
			</p>
			<p>
				<i class="fa-solid fa-headset"></i> Chính sách bảo hành
			</p>
		</div>

		<div class="footer-right">
			<h3>Thông tin liên hệ</h3>
			<p>
				<i class="fa-solid fa-location-dot"></i> Nơi nào đó ở Huế
			</p>
			<p>
				<i class="fa-solid fa-envelope"></i> shoptelephone@mail.com
			</p>
			<p>
				<i class="fa-solid fa-phone"></i> +084 191919191 <i
					class="bi bi-phone"></i>
			</p>
		</div>
		<div class="footer-between">
			<h3>Thanh Toán</h3>
			<img
				src="http://mauweb.monamedia.net/fptshop/wp-content/uploads/2017/12/icon_cong_nhan.png"
				alt=""><br> <img
				src="http://mauweb.monamedia.net/broshop/wp-content/uploads/2019/03/payment.png"
				alt="">
		</div>
	</div>
</body>
</html>