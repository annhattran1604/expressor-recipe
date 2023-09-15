<%@page import="java.util.ArrayList"%>
<%@page import="bean.giohang_bean"%>
<%@page import="bo.giohang_bo"%>
<%@page import="bean.kh_bean"%>
<%@page import="java.text.NumberFormat" import="java.util.Locale"%>
<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Giỏ hàng</title>
<link rel="icon" type="png" href="img-phone/logo-carts.png">
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
<link rel="stylesheet" href="${pageContext.request.contextPath}/gh.css">
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
/* login */
.login {
	display: flex;
	justify-content: space-evenly;
	width: 100%;
	background-color: rgb(255, 255, 255);
	padding: 5px 0;
}

.container__button {
	transform: translateX(300px);
}

.login_icon {
	transform: translateX(-300px);
	font-size: 20px;
}

.login a {
	font-size: 15px;
	padding: 10px;
	color: #000000;
	text-decoration: none;
}

.container__button a:hover {
	color: rgb(255, 0, 0);
}

.container__button a {
	margin-left: 0;
}

.login_icon {
	margin-left: 20px;
}

.body--items {
	display: grid;
}
</style>
<body>
	<!-- header -->
	<%
	response.setCharacterEncoding("utf-8");
	request.setCharacterEncoding("utf-8");
	%>
	<div id="login" class="login">
		<div class="login_icon">
			<i class="fa-brands fa-facebook fa-bounce"></i> <i
				class="fa-brands fa-instagram fa-bounce"></i> <i
				class="fa-brands fa-square-twitter fa-bounce"></i>
		</div>
		<div class="container__button">

			<%
			if (session.getAttribute("dn") != null) {
				kh_bean name = (kh_bean) session.getAttribute("dn");
			%>
			<a href="#"> <i class="fa-solid fa-user"></i> <%=name.getHoten()%>
			</a> <a href="dangxuatController?dx=1"> <i
				class="fa-solid fa-right-from-bracket"></i> Out
			</a>
			<%
			} else {
			%>
			<a href="dangky.jsp"><i class="fa-solid fa-user-plus"></i> Đăng
				ký</a> <a href="dangnhap.jsp"><i
				class="fa-solid fa-right-to-bracket"></i> Đăng nhập</a>
			<%
			}
			%>
		</div>
		<%
		String err2 = (String) request.getAttribute("err2");
		if (err2 != null)
			out.println("<script>alert('Đăng nhập thành công');</script>");
		%>

	</div>
	<div id="header">
		<div class="header__logo">
			<%
			long n=0;
			ArrayList<giohang_bean> gio = (ArrayList<giohang_bean>) session.getAttribute("giohang1");
			if (gio != null) {
				n=gio.size();
			%>
			<a href="hangController?slh=<%=gio.size()%>"><img
				src="img-phone/iconlogo.png" alt=""></a>
			<%
			} else {
			%>
			<a href="hangController?slh=0"><img src="img-phone/iconlogo.png"
				alt=""></a>
			<%
			}
			%>
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
			<a href="lichsuMHController"> <i class="fa-solid fa-clock-rotate-left"></i>
			</a>
		</div>
		<div class="header__history">
			<a href="lichsuMHController"> <i
				class="fa-solid fa-clock-rotate-left"></i> Lịch sử
			</a>
		</div>
	</div>
	<!-- carts -->
	<%
	if (n>0) {
	%>
	<div class="text-center">
		<h2>
			Shopping Carts(<%=gio.size()%>)
		</h2>
	</div>
	<section style="display: flex;justify-content: center;flex-wrap: wrap;" class="h-100 h-custom">
		<form style="width: 80%" class="form" action="xoaController?xoacb=1" method="post"
			class="h-100" style="background-color: #eee;">
			<div class="container py-5 h-100">
				<div
					class="row d-flex justify-content-center align-items-center h-100">
					<div class="col-12">
						<div class="card card-registration card-registration-2"
							style="border-radius: 15px;">
							<div class="card-body p-0">
								<div class="row g-0">
									<div class="col-lg-8">
										<div class="p-5">
											<div
												class="d-flex justify-content-between align-items-center mb-5">
												<h1 class="fw-bold mb-0 text-black">Shopping Cart</h1>
												<h6 class="mb-0 text-muted"><%=gio.size()%>
													items
												</h6>
											</div>
											<hr class="my-4">
											<%
											NumberFormat format = NumberFormat.getNumberInstance(new Locale("vi", "VN"));
											long tt=0;
											for (giohang_bean i : gio) {
												tt+=i.getThanhgia();
												long gia = i.getThanhgia();
												String formattedGia = format.format(gia);
											%>
											<div
												class="row mb-4 d-flex justify-content-between align-items-center">
												<div class="col-md-2 col-lg-2 col-xl-2">
													<input type="checkbox" name="checkb"
														value="<%=i.getHang().getMadt()%>"> <img
														src="<%=i.getHang().getAnh()%>"
														class="img-fluid rounded-3" alt="Ảnh điện thoại">
												</div>
												<div class="col-md-3 col-lg-3 col-xl-3">
													<h6 class="text-black mb-0"><%=i.getHang().getTendt()%></h6>
												</div>
												<div class="col-md-3 col-lg-3 col-xl-2 d-flex">
													<p class="id" style="display: none"><%=i.getHang().getMadt()%></p>
													<input class="inputNumber" style="width: 50px"
														type="number" min="1" value="<%=i.getSl()%>"> <a
														style="padding: 0 5px; margin-left: 5px"
														class="link btn-outline-warning"> <i
														class="fa-solid fa-wrench"></i>
													</a>
												</div>
												<div class="col-md-4 col-lg-2 col-xl-3 offset-lg-1">
													<h6 class="mb-0"><%=formattedGia%>
														VND
													</h6>
												</div>
												<div class="col-md-1 col-lg-1 col-xl-1 text-end">
													<a href="xoaController?ms=<%=i.getHang().getMadt()%>"
														class="text-danger"><i class="fas fa-trash fa-lg"></i></a>
												</div>
											</div>
											<%
											}
											%>

											<div class="pt-5">
												<h6 class="mb-0">
													<a class="btn btn-outline-warning"
														href="xoaController?xoaAll=1">Xoá giỏ hàng</a> <input
														class="btn btn-outline-warning" type="submit"
														value="Xoá hàng đã chọn">
												</h6>
											</div>
										</div>
									</div>
									<div class="col-lg-4 bg-grey">
										<div class="p-5">
											<h3 class="fw-bold mb-5 mt-2 pt-1">Summary</h3>
											<hr class="my-4">

											<div class="d-flex justify-content-between mb-4">
												<h5 class="text-uppercase">
													<i class="fa-solid fa-wallet"></i>
												</h5>
												<%String formattedTongTien = format.format(tt); %>
												<h5><%=formattedTongTien%>
													VNĐ
												</h5>
											</div>

										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</form>
		<form style="width: 50%;text-align: center;margin: 10px 0;" 
			action="xacnhanGioController" method="post">
			<button type="submit" class="btn btn-dark btn-block btn-lg"
				data-mdb-ripple-color="dark">Xác nhận thanh toán</button>
		</form>
	</section>
	<%
	} else {
	%>
	<div
		style="text-align:center; padding: 15px 0; color: #D1A517">
		<img alt="" src="https://nhasachtrinhan.vn/images/emptycart.png">
		<h1>Giỏ hàng hiện đang trống!</h1>
	</div>
	<a
		style="display: flex; justify-content: center; padding: 10px 0; color: #D1A517; font-weight: 700; text-decoration: none;"
		href="hangController?slh=0"> Quay lại cửa hàng!</a>
	<%
	}
	%>
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
	<script type="text/javascript">
		const links = document.querySelectorAll(".link");
		const inputNumbers = document.querySelectorAll(".inputNumber");
		const ids = document.querySelectorAll(".id");

		for (let i = 0; i < links.length; i++) {
			links[i].addEventListener("click", function(event) {
				event.preventDefault();
				const inputValue = inputNumbers[i].value; // Lấy giá trị từ input tương ứng với thẻ a được click

				if (inputValue !== "") {
					window.location.href = "suaController?ms="
							+ ids[i].innerHTML + "&txtsl=" + inputValue;
				}
			});
		}
	</script>
</body>
</html>