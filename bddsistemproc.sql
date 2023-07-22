drop database if exists bddsistemproc;
create database bddsistemproc;
use bddsistemproc;
-- TIPO USUARIO
create table Usuario(
id_usu int primary key not null auto_increment,
user_usu varchar (10) not null,
pass_usu varchar(10)
);
-- Clientes
create table Clientes(
id_Cli int primary key not null auto_increment,
nom_Cli varchar (30) not null,
apell_Cli varchar (30) not null,
CI_Cli varchar (15) not null,
fono_Cli varchar (15) not null,
direc_Cli varchar (100) not null,
E_Cli boolean
);
-- Maquiladores
create table Maquiladores(
id_Maqui int primary key not null auto_increment,
CI_Maqui varchar (15) not null,
nom_Maqui varchar (30) not null,
apell_Maqui varchar (30) not null,
fechaNaci date not null,
mail_Maqui varchar (50) not null,
fono_Maqui varchar (15) not null,
direc_Maqui varchar (100) not null,
cargo_Maqui varchar (30) not null,
E_Maqui boolean
);
select * from Maquiladores;
-- MOLDES
create table TipoMolde(
id_TMold int primary key not null auto_increment,
nom_TMold varchar (30) not null);

create table Molde(
id_Mold int primary key not null auto_increment,
color_Mold varchar (30) not null,
Talla_Mold varchar (5) not null,
Cantidad_Mold int not null,
precio_Mold decimal(5,2)not null,
TotalC_Mold decimal(5,2)not null,
fkid_TMold int not null,
foreign key (fkid_TMold) references TipoMolde(id_TMold)
);
-- ARTICULO
create table Articulos(
id_Art int primary key not null auto_increment,
nom_Art varchar (30) not null,
cantidad_Art int not null,
material_Art varchar (30) not null,
categoria_Art varchar (30) not null,
FechAdquisicion_Art date,
costo_Art decimal(5,2) not null,
descripcion_ART varchar (200) not null,
proveedor_ART varchar (30),
E_ART boolean
);
-- SERVICIO DE MAQUILACION
create table ServicioMaquilacion(
id_SMaqui int primary key not null auto_increment,
FechaI_SMaqui date,
FechaF_SMaqui date,
fkid_Maqui int not null,
fkid_Mold int not null,
foreign key (fkid_Maqui) references Maquiladores(id_Maqui),
foreign key (fkid_Mold) references Molde(id_Mold)
);
-- ORDEN DE TRABAJO
create table OrdTrabajo(
id_OT int primary key not null auto_increment,
descr_OT varchar(150) not null,
fkid_Maqui int not null,
fkid_Cli int not null,
fkid_TMold int not null,
foreign key (fkid_Maqui) references Maquiladores(id_Maqui),
foreign key (fkid_Cli) references Clientes(id_Cli),
foreign key (fkid_TMold) references TipoMolde(id_TMold)
);
-- VENTAS Y PAGOS
create table VentasyPagos(
id_Vp int primary key not null auto_increment,
descript_Vp varchar(150) not null,
fkid_Maqui int not null,
fkid_Cli int not null,
fkid_TMold int not null,
foreign key (fkid_Maqui) references Maquiladores(id_Maqui),
foreign key (fkid_Cli) references Clientes(id_Cli),
foreign key (fkid_TMold) references TipoMolde(id_TMold)
);
-- REPORTES
create table Sreportes(
id_rep int primary key not null auto_increment,
descript_rep varchar(150) not null,
fkid_Maqui int not null,
fkid_Cli int not null,
fkid_TMold int not null,
fkid_Vp int not null,
foreign key (fkid_Maqui) references Maquiladores(id_Maqui),
foreign key (fkid_Cli) references Clientes(id_Cli),
foreign key (fkid_TMold) references TipoMolde(id_TMold),
foreign key (fkid_Vp) references VentasyPagos(id_Vp)
);

insert into Usuario (user_usu,pass_usu) values('Patricio1','Patricio1');
Select * from Molde;