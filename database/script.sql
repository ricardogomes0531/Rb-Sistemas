use rb_sistemas
go

create table estabelecimento(id int identity, nome varchar(200) not null, documento varchar(20) not null, tipo_documento char(4) not null, categoria int not null)