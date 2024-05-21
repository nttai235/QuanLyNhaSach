--Tạo CSDL--
create database QLNhaSach
--Sử dụng CSDL--
use QLNhaSach
--Tạo bảng--
create table ChucVu(
	macv char(2) primary key,
	tencv nvarchar(20) not null
)
create table NhanVien(
	manv char(10) primary key,
	tentk char(20) unique not null,
	matkhau char(50) not null default('202cb962ac59075b964b07152d234b70'),
	holot nvarchar(20) not null,
	ten nvarchar(10) not null,
	email nvarchar(50) not null,
	ngaysinh smalldatetime,
	phai nvarchar(3),
	quequan nvarchar(100),
	macv char(2) not null foreign key(macv) references ChucVu(macv)
)
create table TheLoai(
	matheloai char(10) primary key,
	tentheloai nvarchar(50)
)
create table NXB(
	manxb char(10) primary key,
	tennxb nvarchar(30),
	diachi nvarchar(100),
	sdt char(11)
)
create table Sach(
	masach char(20) primary key,
	tensach nvarchar(100) not null,
	matheloai char(10) foreign key(matheloai) references TheLoai(matheloai) on delete cascade on update cascade,
	tacgia nvarchar(50),
	manxb char(10) foreign key(manxb) references NXB(manxb) on delete cascade on update cascade,
	soluong int not null check (soluong>=0) default(0),
	dongianhap float not null check (dongianhap>=0),
	dongiaban float not null check (dongiaban>=0)
)
create table HoaDon(
	mahd char(20) primary key,
	manv char(10) foreign key(manv) references NhanVien(manv) on delete cascade on update cascade,
	ngaylap datetime not null,
	tongtien float not null
)
create table ChiTietHoaDon(
	mahd char(20) foreign key(mahd) references HoaDon(mahd) on delete cascade,
	masach char(20) not null foreign key(masach) references Sach(masach) on delete cascade on update cascade,
	soluong int not null check (soluong>0),
	thanhtien float not null,
	primary key(mahd, masach)
)
create table NhaCungCap(
	mancc char(10) primary key,
	tenncc nvarchar(50) not null,
	diachi nvarchar(100),
	sdt char(11)
)
create table PhieuNhap(
	maphieu char(20) primary key,
	manv char(10) foreign key(manv) references NhanVien(manv) on delete cascade on update cascade,
	mancc char(10) foreign key(mancc) references NhaCungCap(mancc) on delete cascade on update cascade,
	tongtien float not null,
	ngaylap datetime not null
)
create table ChiTietPhieuNhap(
	maphieu char(20) foreign key(maphieu) references PhieuNhap(maphieu) on delete cascade,
	masach char(20) not null foreign key(masach) references Sach(masach) on delete cascade on update cascade,
	soluong int not null check (soluong>0),
	thanhtien float not null,
	primary key(maphieu, masach)
)
--Nhập dữ liệu--
insert into ChucVu(macv, tencv) values
('QL', N'Quản lý'),
('BH', N'Nhân viên bán hàng'),
('KH', N'Nhân viên kho')
insert into NhanVien(manv, tentk, matkhau, holot, ten, email, ngaysinh, phai, quequan, macv) values
('NV01', 'ntt', '149815eb972b3c370dee3b89d645ae14', N'Nguyễn Tấn', N'Tài', N'tantai@gmail.com', '2003-05-23', N'Nam', N'Hội An, Chợ Mới, An Giang', 'QL'),
('NV02', 'tqk', '202cb962ac59075b964b07152d234b70', N'Trương Quốc', N'Khánh', N'quockhanh@gmail.com', '2003-01-30', N'Nam', N'Bình Phước Xuân, Chợ Mới, An Giang', 'BH'),
('NV03', 'nhd', '202cb962ac59075b964b07152d234b70', N'Nguyễn Hải', N'Đăng', N'haidang@gmail.com', '2001-05-24', N'Nam', N'Mỹ Đức, Châu Phú, An Giang', 'KH')
insert into NXB(manxb, tennxb, diachi, sdt) values
('KD', N'Kim Đồng', N'55 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', '1900571595'),
('TR', N'Trẻ', N'161B Lý Chính Thắng, Phường Võ Thị Sáu, Quận 3 , TP. Hồ Chí Minh', '02839316289'),
('IPM', N'IPM', N'110 Nguyễn Ngọc Nại, Khương Mai, Thanh Xuân, Hà Nội', '0328383979'),
('THHCM', N'Tổng hợp thành phố Hồ Chí Minh', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP. Hồ Chí Minh', '02838256804'),
('ST', N'Chính trị quốc gia Sự thật', N'6/86 Duy tân, Cầu Giấy, Hà Nội', '02438221581'),
('LD', N'Lao Động', N'175 Giảng Võ, Đống Đa, Hà Nội', '0438515380'),
('HN', N'Hà Nội', N'Số 4, phố Tống Duy Tân, phường Hàng Bông, quận Hoàn Kiếm, TP. Hà Nội', '02438252916'),
('GD', N'Giáo dục Việt Nam', N'81 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', '02438220801'),
('TN', N'Thanh Niên', N'D29 Khu đô thị mới Cầu Giấy, Yên Hòa, Cầu Giấy, Hà Nội', '02422147815')
insert into TheLoai(matheloai, tentheloai) values
('SGK', N'Sách giáo khoa'),
('GT', N'Giáo trình'),
('TKhao', N'Tham khảo'),
('TTranh', N'Truyện tranh'),
('TThuyet', N'Tiểu thuyết'),
('KT', N'Kinh tế'),
('TL', N'Tâm lý'),
('TNhi', N'Thiếu nhi'),
('CTPL', N'Chính trị - Pháp luật'),
('NN', N'Ngoại ngữ'),
('KNS', N'Kỹ năng sống'),
('TNgan', N'Truyện ngắn'),
('TS', N'Tiểu sử')
insert into Sach(masach, tensach, matheloai, tacgia, manxb, soluong, dongianhap, dongiaban) values
('TNCMN', N'Tiếng Nhật Cho Mọi Người - Sơ Cấp 2 - Bản Tiếng Nhật', 'NN', N'Nhiều tác giả', 'TR', 50, 100000, 150000),
('NGE', N'Neon Genesis Evangelion - Collector’s Edition - Tập 1', 'TTranh', N'Yoshiyuki Sadamoto', 'HN', 40, 150000, 200000),
('TLHTP', N'Tâm Lý Học Tội Phạm - Phác Họa Chân Dung Kẻ Phạm Tội', 'TL', N'Diệp Hồng Vũ', 'TN', 45, 60000, 120000),
('BLDS', N'Bộ Luật Dân Sự (Hiện Hành)', 'CTPL', N'Quốc Hội', 'ST', 60, 45000, 93000)
insert into NhaCungCap(mancc, tenncc, diachi, sdt) values
('KD', N'Kim Đồng', N'55 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội', '1900571595'),
('IPM', N'IPM', N'110 Nguyễn Ngọc Nại, Khương Mai, Thanh Xuân, Hà Nội', '0328383979'),
('TR', N'Trẻ', N'161B Lý Chính Thắng, Phường Võ Thị Sáu, Quận 3 , TP. Hồ Chí Minh', '02839316289'),
('AZ', N'AZ VIETNAM', N'65 Đường 9, Khu Tập Thể F361, An Dương, Tây Hồ, Hà Nội', '0964484633'),
('AMAK', N'Amak Books', N'96 Ngõ 40 Tạ Quang Bửu, Bách Khoa, Hai Bà Trưng, Hà Nội, Việt Nam', '0366979591'),
('NN', N'Nhã Nam', N'59, Đỗ Quang, Trung Hoà, Cầu Giấy, Hà Nội', '02435146876'),
('1980', N'1980 Books', N'42/35 Nguyễn Minh Hoàng-Phường 12, Quận Tân Bình, Thành Phố Hồ Chí Minh', '02839333216')