create database ASM_C#2;

use ASM_C#2;

create table Class(
	idClass int identity (1,1) Primary key not null,
	NameClass nvarchar(50)
);

create table Student(
	StID int identity(1,1) Primary key not null,
	Name nvarchar(50),
	Mark float,
	Email varchar(50),
	idClass int references Class(idClass)
);

insert into Class
values
('UDPM C#'),
('UDPM Java'),
('Thiet Ke WEB'),
('Thiet ke do hoa'),
('Digital Marketing'),
('Tu dong hoa');

INSERT INTO Student
VALUES
  ('Nguyen Van Anh', 9.5, 'anhnvps20501@fpt.edu.vn', 1),
  ('Tran Thi Minh', 8, 'minhttps20338@fpt.edu.vn', 1),
  ('Le Quang Huy', 7.5, 'huylqps20526@fpt.edu.vn', 2),
  ('Phan Thi Thanh', 9, 'thanhtpps19894@fpt.edu.vn', 1),
  ('Vo Duc Tien', 8.5, 'tienvdps26001@fpt.edu.vn', 1),
  ('Nguyen Hoai Nam', 9.5, 'namnhops27001@fpt.edu.vn', 1),
  ('Trinh Van Linh', 7, 'linhtvps28001@fpt.edu.vn', 1),
  ('Hoang Thi Kim', 8, 'kimhtps19841@fpt.edu.vn', 1),
  ('Do Van Phong', 7.5, 'phongdvps19001@fpt.edu.vn', 2),
  ('Quan Bich Van', 6.5, 'thanhnv@fpt.edu.vn', 3),
  ('Le Thi Ngoc', 7.5, 'ngocltps19998@fpt.edu.vn', 4),
  ('Pham Van Quoc', 9, 'quocpvps24544@fpt.edu.vn', 5),
  ('Tran Thi Thu', 8.5, 'thuttps20556@fpt.edu.vn', 6);
