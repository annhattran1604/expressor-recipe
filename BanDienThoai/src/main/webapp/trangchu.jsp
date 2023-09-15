<%@page import="java.util.List"%>
<%@page import="bo.giohang_bo"%>
<%@page import="bean.kh_bean"%>
<%@page import="bean.hangdt_bean"%>
<%@page import="bean.hang_bean"%>
<%@page import="java.text.NumberFormat" import="java.util.Locale"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Cửa hàng</title>
<link rel="icon" type="png" href="img-phone/iconlogo.png">
<link rel="stylesheet"
	href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="trangchu.css">
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<style>
* {
	scroll-behavior: smooth;
}

.home {
	position: fixed;
	bottom: 10px;
	right: 10px;
}

.home a {
	font-size: 20px;
	padding: 5px;
	color: #000000;
}
.container__button a{
	margin-left: 0;}
	.login_icon{
	margin-left: 20px;
	}
	.body--items
	{
	display:grid;}
</style>
<body>
	<%response.setCharacterEncoding("utf-8");
	request.setCharacterEncoding("utf-8"); 
	//số lượng giỏ hàng
	
	long n=(long)request.getAttribute("slgh");
	
	%>
	<div class="home">
		<a href="#login"><i class="fa-solid fa-plane-up"></i></a>
	</div>
	<!-- Login -->

	<div id="login" class="login">
		<div class="login_icon">
			<i class="fa-brands fa-facebook fa-bounce"></i> <i
				class="fa-brands fa-instagram fa-bounce"></i> <i
				class="fa-brands fa-square-twitter fa-bounce"></i>
		</div>
		<div class="container__button">
			<a href="lichsuMHController">
				<i class="fa-solid fa-clock-rotate-left fa-bounce"></i> Lịch sử mua hàng
			</a>
			<%
			if (session.getAttribute("dn") != null) {
				kh_bean name = (kh_bean) session.getAttribute("dn");
				%>
			<a class="dropdown-item" href="#">
				<i class="fa-solid fa-user"></i><%=name.getHoten()%>
			</a>
			<a href="dangxuatController?dx=1">
				<i class="fa-solid fa-right-from-bracket"></i> Out
			</a>
			<%
				} else {
			%> 
			<a href="dangky.jsp"><i class="fa-solid fa-user-plus"></i> Đăng ký</a> 
			<a href="dangnhap.jsp"><i class="fa-solid fa-right-to-bracket"></i> Đăng nhập</a>
			<%} %>
		</div>
			<% 
			String err2=(String)request.getAttribute("err2");
			if(err2!=null )
				out.println("<script>alert('Đăng nhập thành công');</script>");	
			%>

		<!-- Modal dang nhap-->
		
	</div>
	<!-- header -->
	<div id="header">
		<div class="header__logo">
			<a href=""><img src="img-phone/iconlogo.png" alt=""></a>
		</div>
		<div class="header__search">
			<form action="hangController" method="post">
				<input oninput="searchByName(this)" type="text" name="key" placeholder="Bạn muốn gì">
				<button type="submit" class="btn btn-primary">
					<i class="fas fa-search"></i>
				</button>
			</form>
		</div>
		<div class="header--right">
			<div class="header__hotline">
				<i class="fa-solid fa-phone"></i>
				<div class="hotline--text">
					<p>Mua Hàng Online</p>
					<p>
						<b>1919.191.919</b>
					</p>
				</div>
			</div>
			<div class="header__news">
				<i class="fa-solid fa-location-dot"></i>
				<div class="hotline--text">
					<p>12 Chi nhánh toàn quốc</p>
				</div>
			</div>
			<div class="header__cart">
				<a href="giohangController"><i
					class="fa-sharp fa-solid fa-cart-shopping"></i>
				<p> <%=n %></p></a>
				<p class="sl"><%=n %></p>
			</div>
		</div>

	</div>

	<!-- Slide -->
	<div class="slide-bar">
		<div class="slide-bar--left">
			<div id="myCarousel" class="carousel slide" data-ride="carousel">
				<!-- Wrapper for slides -->
				<div class="carousel-inner" role="listbox">

					<div class="item active">
						<img
							src="https://cdn.mobilecity.vn/mobilecity-vn/images/2023/05/w800/xiaomi-redmi-note-12-turbo-slide-01.jpg.webp"
							alt="Chania">
					</div>

					<div class="item">
						<img
							src="https://cdn.mobilecity.vn/mobilecity-vn/images/2023/04/w800/asus-rog-phone-7-1-1.jpg.webp"
							alt="Chania">
					</div>

				</div>

				<!-- Left and right controls -->
				<a class="left carousel-control" href="#myCarousel" role="button"
					data-slide="prev"> <span
					class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
					<span class="sr-only">Previous</span>
				</a> <a class="right carousel-control" href="#myCarousel" role="button"
					data-slide="next"> <span
					class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
					<span class="sr-only">Next</span>
				</a>
			</div>
		</div>
		<div class="slide-bar--right">
			<div id="container2">
				<iframe width="100%" height="100%"
					src="https://www.youtube.com/embed/I1jrf3acJGQ"
					title="YouTube video player" frameborder="0"
					allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
					allowfullscreen></iframe>
				<iframe width="100%" height="100%"
					src="https://www.youtube.com/embed/UUO4DWVlWO0"
					title="YouTube video player" frameborder="0"
					allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
					allowfullscreen></iframe>
			</div>
		</div>
	</div>
	<!-- menubar -->
	<div class="menu-bar">
		<div class="bars">
			<i class="fa-solid fa-bars"></i>
		</div>
		<ul class="ul1">
			<%
  			ArrayList<hangdt_bean> dshang =(ArrayList<hangdt_bean>) request.getAttribute("dshang");
  			for(hangdt_bean hang:dshang){
  			%>
			<li><a href="searchbyAjax?madt=<%=hang.getMahang()%>" class="ajax-link"><%=hang.getTenhang() %></a></li>
			<%} %>
		</ul>
		<ul class="ul2">
			<%
  			for(hangdt_bean hang:dshang){
  			%>
			<li><a href="searchbyAjax?madt=<%=hang.getMahang()%>" class="ajax-link"><%=hang.getTenhang() %></a></li>
			<%} %>
		</ul>
	</div>
	<!-- body -->
	<div class="body">
		<div class="body-left">
			<h3>BÀI VIẾT MỚI NHẤT</h3>
			<div class="body-left--blog">
				<img
					src="http://mauweb.monamedia.net/broshop/wp-content/uploads/2017/12/hinh-nen-mate-10-pro--150x150.jpg"
					alt=""> <a href="">Trọn bộ hình nền Huawei Mate 10 đẹp
					“miễn chê” cho mọi smartphone</a>
			</div>
			<div class="body-left--blog">
				<img
					src="http://mauweb.monamedia.net/broshop/wp-content/uploads/2017/12/Nokia-6-TA-1054-cover-150x150.jpg"
					alt=""> <a href="">Rò rỉ thông tin Nokia 6 (2018): Màn
					hình tràn viền, tỉ lệ 18:9</a>
			</div>
			<div class="body-left--blog">
				<img
					src="http://mauweb.monamedia.net/broshop/wp-content/uploads/2017/12/meizu-note-8-fptshop-150x150.jpg"
					alt=""> <a href="">Meizu Note 8 bất ngờ xuất hiện trong
					diện mạo đẹp hoàn hảo</a>
			</div>
			<div class="body-left--blog">
				<img
					src="http://mauweb.monamedia.net/broshop/wp-content/uploads/2017/12/danh-gia-asus-zenfone-4-max-pro-pin-sieu-trau-kha-bat-ngo-ve-camera-2-150x150.jpg"
					alt=""> <a href="">Tại sao nên mua “phiên bản thu nhỏ”
					Asus Zenfone 4 Max?</a>
			</div>
			<div class="body-left--blog">
				<img
					src="http://mauweb.monamedia.net/broshop/wp-content/uploads/2017/12/Nhung-dieu-tuyet-voi-se-co-tren-smartphone-android-cao-cap-2018-4-150x150.jpg"
					alt=""> <a href="">Những điều tuyệt vời sẽ xuất hiện trên
					smartphone Android đỉnh cao 2018</a>
			</div>
		</div>
		<div class="body-right">
			<div class="body-right--top">
				<ul class="nav navbar-nav">
					<li><a href="hangController?all=1">Tất cả</a></li>
					<li><a href="hangController?new=1">Mới nhất</a></li>
					<li class="dropdown"><a class="dropdown-toggle"
						data-toggle="dropdown" href="#">Giá <span class="caret"></span></a>
						<ul class="dropdown-menu">
							<li><a href="hangController?tang=1">Giá tăng dần</a></li>
							<li><a href="hangController?giam=1">Giá giảm dần</a></li>
						</ul></li>
				</ul>
			</div>

			<!-- Hiển thị hàng bán -->
			<div id="content" class="body-right--bottom">
				<%
  			List<hang_bean> ds =(List<hang_bean>) request.getAttribute("dshientai");
  			String size;
  			int n1=ds.size();
  			for(hang_bean hang:ds){
  				if(hang.getSize()==null){
  					size ="\n";}
  				else{
  					size=hang.getSize();
  				}
  			  long gia = hang.getGia();
  			  NumberFormat format = NumberFormat.getNumberInstance(new Locale("vi", "VN"));
  			  String formattedGia = format.format(gia);
  			%>
				<div class="body--items">
					<img src="<%=hang.getAnh() %>" alt=""> <a href=""><%=hang.getTendt() %></a>
					<p><%=size %></p>
					<p class="cost">
						<i class="fa-solid fa-circle-dollar-to-slot"></i>
						<%=formattedGia %>₫
					</p>
					<a style="width: 50%;" href="giohangController?mdt=<%=hang.getMadt()%>&tendt=<%=hang.getTendt()%>&anh=<%=hang.getAnh()%>&gia=<%=hang.getGia()%>&size=<%=hang.getSize()%>">
						Thêm vào giỏ </a>
				</div>
				
				<%}
  				if(n1==0){%>
  				<h1 style="display: flex;margin: auto;">Không tìm thấy mặt hàng</h1>
  				<%} %>
			</div>
			<%
				//lay so trang hien tai
				int trang = (int) request.getAttribute("tranghientai");%>
				<nav aria-label="Page navigation example" style="text-align: center">
					<ul class="pagination">
						<li class="page-item">
      						<a class="page-link" href="hangController?tab=lui&tht=<%=trang%>" aria-label="Previous">
        						<span aria-hidden="true">&laquo;</span>
      						</a>
    					</li>
						<%  double sotrang = (double) request.getAttribute("sotrang");
							for(int i = 0 ; i < sotrang ; i++) {
							int j = i;
							j = j + 1; %>
						<li class="page-item"><a class="page-link" href="hangController?page=<%=j%>"><%=j %></a></li>
						<%} %>
						<li class="page-item">
      						<a class="page-link" href="hangController?tab=toi&tht=<%=trang%>" aria-label="Next">
        						<span aria-hidden="true">&raquo;</span>
      						</a>
    					</li>
					</ul>
				</nav>
		</div>

	</div>
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
	<script>
		$(document).ready(function() {
			$("#myBtn").click(function() {
				$("#myModal").modal();
			});
		});
		const bars = document.querySelector('.menu-bar .bars');
		const menu = document.querySelector('.menu-bar .ul2');

		bars.addEventListener('click', function() {
			menu.classList.toggle('show'); // Thêm hoặc xóa lớp .show khi click vào .bars
		});
		
		function searchByName(name) {
			var txtSearch = name.value;
			$.ajax({
			    url: "/BanDienThoai/searchbyAjax",
			    data: { 
			    	key: txtSearch
			    },
			    type: "get",
			    success: function(data) {
					var row = document.getElementById("content");
					row.innerHTML =data;
			    },
			    error: function(xhr) {

			    }
			});
		}
		$(document).ready(function() {
		    $(".ajax-link").click(function(e) {
		        e.preventDefault(); // Ngăn chặn hành vi mặc định của liên kết

		        var linkHref = $(this).attr("href"); // Lấy URL liên kết

		        $.ajax({
		            url: linkHref,
		            type: "get",
		            success: function(data) {
		                var row = document.getElementById("content");
		                row.innerHTML = data;
		            },
		            error: function(xhr) {
		                // Xử lý lỗi (nếu cần)
		            }
		        });
		    });
		});
	</script>
</body>
</html>