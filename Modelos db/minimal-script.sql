if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CATEGORIA_PRODUCTO') and o.name = 'FK_CATEGORI_CATEGORIA_CATEGORI')
alter table CATEGORIA_PRODUCTO
   drop constraint FK_CATEGORI_CATEGORIA_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CATEGORIA_PRODUCTO') and o.name = 'FK_CATEGORI_PRODUCTO__PRODUCTO')
alter table CATEGORIA_PRODUCTO
   drop constraint FK_CATEGORI_PRODUCTO__PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_VENTA') and o.name = 'FK_DETALLE__DETALLE_V_VENTA')
alter table DETALLE_VENTA
   drop constraint FK_DETALLE__DETALLE_V_VENTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLE_VENTA') and o.name = 'FK_DETALLE__PRODUCTO__PRODUCTO')
alter table DETALLE_VENTA
   drop constraint FK_DETALLE__PRODUCTO__PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OPCIONES_PRODUCTO') and o.name = 'FK_OPCIONES_OPCIONES__OPCIONES')
alter table OPCIONES_PRODUCTO
   drop constraint FK_OPCIONES_OPCIONES__OPCIONES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OPCIONES_PRODUCTO') and o.name = 'FK_OPCIONES_PRODUCTO__PRODUCTO')
alter table OPCIONES_PRODUCTO
   drop constraint FK_OPCIONES_PRODUCTO__PRODUCTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VENTA') and o.name = 'FK_VENTA_VENTA_PER_CLIENTE')
alter table VENTA
   drop constraint FK_VENTA_VENTA_PER_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VENTA') and o.name = 'FK_VENTA_VENTA_TIE_ENVIO')
alter table VENTA
   drop constraint FK_VENTA_VENTA_TIE_ENVIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VENTA') and o.name = 'FK_VENTA_VENTA_TIE_TIPO_PAG')
alter table VENTA
   drop constraint FK_VENTA_VENTA_TIE_TIPO_PAG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORIA')
            and   type = 'U')
   drop table CATEGORIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CATEGORIA_PRODUCTO')
            and   name  = 'PRODUCTO_PERTENECE_CATEGORIA_FK'
            and   indid > 0
            and   indid < 255)
   drop index CATEGORIA_PRODUCTO.PRODUCTO_PERTENECE_CATEGORIA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CATEGORIA_PRODUCTO')
            and   name  = 'CATEGORIA_TIENE_PRODUCTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index CATEGORIA_PRODUCTO.CATEGORIA_TIENE_PRODUCTO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORIA_PRODUCTO')
            and   type = 'U')
   drop table CATEGORIA_PRODUCTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_VENTA')
            and   name  = 'DETALLE_VENTA_PERTENECE_VENTA_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_VENTA.DETALLE_VENTA_PERTENECE_VENTA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETALLE_VENTA')
            and   name  = 'PRODUCTO_PERTENECE_DETALLE_FACTURA_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETALLE_VENTA.PRODUCTO_PERTENECE_DETALLE_FACTURA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLE_VENTA')
            and   type = 'U')
   drop table DETALLE_VENTA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENVIO')
            and   type = 'U')
   drop table ENVIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPCIONES')
            and   type = 'U')
   drop table OPCIONES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OPCIONES_PRODUCTO')
            and   name  = 'OPCIONES_PERTENECEN_PRODUCTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index OPCIONES_PRODUCTO.OPCIONES_PERTENECEN_PRODUCTO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OPCIONES_PRODUCTO')
            and   name  = 'PRODUCTO_TIENE_OPCIONES_FK'
            and   indid > 0
            and   indid < 255)
   drop index OPCIONES_PRODUCTO.PRODUCTO_TIENE_OPCIONES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OPCIONES_PRODUCTO')
            and   type = 'U')
   drop table OPCIONES_PRODUCTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PARAMETROS_GENERALES')
            and   type = 'U')
   drop table PARAMETROS_GENERALES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCTO')
            and   type = 'U')
   drop table PRODUCTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_PAGO')
            and   type = 'U')
   drop table TIPO_PAGO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VENTA')
            and   name  = 'VENTA_TIENE_ENVIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index VENTA.VENTA_TIENE_ENVIO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VENTA')
            and   name  = 'VENTA_TIENE_TIPO_PAGO_FK'
            and   indid > 0
            and   indid < 255)
   drop index VENTA.VENTA_TIENE_TIPO_PAGO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VENTA')
            and   name  = 'VENTA_PERTENECE_CLIENTE_FK'
            and   indid > 0
            and   indid < 255)
   drop index VENTA.VENTA_PERTENECE_CLIENTE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VENTA')
            and   type = 'U')
   drop table VENTA
go

if exists(select 1 from systypes where name='DOMAIN_1')
   drop type DOMAIN_1
go

/*==============================================================*/
/* Domain: DOMAIN_1                                             */
/*==============================================================*/
create type DOMAIN_1
   from char(10)
go

/*==============================================================*/
/* Table: CATEGORIA                                             */
/*==============================================================*/
create table CATEGORIA (
   CAT_ID               varchar(15)          not null,
   CAT_NOMBRE           varchar(50)          not null,
   CAT_DESCRIPCION      varchar(250)         null,
   CAT_MINIATURA        varbinary(8000)      null,
   CAT_RUTA_IMAGEN      varchar(250)         null,
   constraint PK_CATEGORIA primary key (CAT_ID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('CATEGORIA') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'CATEGORIA' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene generalizaciones de un mismo tipo de producto con el fin de agrupar productos segun su tipo', 
   'user', @CurrentUser, 'table', 'CATEGORIA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAT_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Codigo alfanumerico que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAT_NOMBRE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_NOMBRE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Codigo alfanumerico que contiene el nombre de la categoria',
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_NOMBRE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAT_DESCRIPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_DESCRIPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Secuencia alfanumerica que contiene el descripcion de la categoria',
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_DESCRIPCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAT_MINIATURA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_MINIATURA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene un icono, miniatura o imagen referencial de baja calidad',
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_MINIATURA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAT_RUTA_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_RUTA_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la ruta de la imagen que hace referencia a su categoria',
   'user', @CurrentUser, 'table', 'CATEGORIA', 'column', 'CAT_RUTA_IMAGEN'
go

/*==============================================================*/
/* Table: CATEGORIA_PRODUCTO                                    */
/*==============================================================*/
create table CATEGORIA_PRODUCTO (
   CAT_ID               varchar(15)          not null,
   PRD_ID               varchar(15)          not null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('CATEGORIA_PRODUCTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'CATEGORIA_PRODUCTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Tabla interseccion que relaciona un producto a la categoria que pertenece
   ', 
   'user', @CurrentUser, 'table', 'CATEGORIA_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA_PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CAT_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA_PRODUCTO', 'column', 'CAT_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Codigo alfanumerico que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'CATEGORIA_PRODUCTO', 'column', 'CAT_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CATEGORIA_PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CATEGORIA_PRODUCTO', 'column', 'PRD_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'CATEGORIA_PRODUCTO', 'column', 'PRD_ID'
go

/*==============================================================*/
/* Index: CATEGORIA_TIENE_PRODUCTO_FK                           */
/*==============================================================*/




create nonclustered index CATEGORIA_TIENE_PRODUCTO_FK on CATEGORIA_PRODUCTO (CAT_ID ASC)
go

/*==============================================================*/
/* Index: PRODUCTO_PERTENECE_CATEGORIA_FK                       */
/*==============================================================*/




create nonclustered index PRODUCTO_PERTENECE_CATEGORIA_FK on CATEGORIA_PRODUCTO (PRD_ID ASC)
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   CLI_USUARIO          varchar(50)          not null,
   CLI_CONTRASENA       varchar(25)          not null,
   CLI_CEDULA_RUC       varchar(13)          not null,
   CLI_EMAIL            varchar(50)          not null,
   CLI_NOMBRE           varchar(50)          not null,
   CLI_APELLIDO         varchar(50)          null,
   CLI_EDAD             int                  null,
   CLI_GENERO           varchar(50)          null,
   CLI_DIRECCION        varchar(250)         null,
   CLI_CIUDAD           varchar(50)          null,
   CLI_PROVINCIA        varchar(50)          null,
   CLI_TELEFONO         varchar(10)          null,
   constraint PK_CLIENTE primary key (CLI_USUARIO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('CLIENTE') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'CLIENTE' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene informacion con respecto a los clientes del negocio', 
   'user', @CurrentUser, 'table', 'CLIENTE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene una secuencia alfanumerica que sirve como identificador de la cuenta del usuario y define la unicidad del registro',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_CONTRASENA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_CONTRASENA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la contrasena del usuario',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_CONTRASENA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_CEDULA_RUC')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_CEDULA_RUC'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene una secuencia numerica de caracteres que indican la identificacion del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_CEDULA_RUC'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_EMAIL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_EMAIL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el correo electronico del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_EMAIL'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_NOMBRE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_NOMBRE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el nombre de pila del cliente o el nombre de la empresa',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_NOMBRE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_APELLIDO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_APELLIDO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el apellido del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_APELLIDO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_EDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_EDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la edad del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_EDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_GENERO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_GENERO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el genero del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_GENERO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_DIRECCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_DIRECCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la direccion domiciliaria del cliente que se usara como valor por defecto a menos que se especifique otra en los distintos formularios en los que sea requerida',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_DIRECCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_CIUDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_CIUDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la ciudad de residencia del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_CIUDAD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_PROVINCIA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_PROVINCIA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la provincia de residencia del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_PROVINCIA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CLIENTE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_TELEFONO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_TELEFONO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el numero de telefono de contacto del cliente',
   'user', @CurrentUser, 'table', 'CLIENTE', 'column', 'CLI_TELEFONO'
go

/*==============================================================*/
/* Table: DETALLE_VENTA                                         */
/*==============================================================*/
create table DETALLE_VENTA (
   PRD_ID               varchar(15)          not null,
   VEN_NUMERO           varchar(15)          not null,
   DET_PRECIO_PRD       decimal(9,2)         not null,
   DET_CANTIDAD         int                  not null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('DETALLE_VENTA') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'DETALLE_VENTA' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Tabla interseccion que relaciona una venta con los productos', 
   'user', @CurrentUser, 'table', 'DETALLE_VENTA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'PRD_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'PRD_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VEN_NUMERO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'VEN_NUMERO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el numero de venta que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'VEN_NUMERO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DET_PRECIO_PRD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'DET_PRECIO_PRD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene una copia del precio del producto al momento de la venta',
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'DET_PRECIO_PRD'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('DETALLE_VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'DET_CANTIDAD')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'DET_CANTIDAD'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la numero de elementos vendidos de un mismo articulo',
   'user', @CurrentUser, 'table', 'DETALLE_VENTA', 'column', 'DET_CANTIDAD'
go

/*==============================================================*/
/* Index: PRODUCTO_PERTENECE_DETALLE_FACTURA_FK                 */
/*==============================================================*/




create nonclustered index PRODUCTO_PERTENECE_DETALLE_FACTURA_FK on DETALLE_VENTA (PRD_ID ASC)
go

/*==============================================================*/
/* Index: DETALLE_VENTA_PERTENECE_VENTA_FK                      */
/*==============================================================*/




create nonclustered index DETALLE_VENTA_PERTENECE_VENTA_FK on DETALLE_VENTA (VEN_NUMERO ASC)
go

/*==============================================================*/
/* Table: ENVIO                                                 */
/*==============================================================*/
create table ENVIO (
   ENV_NUMERO           varchar(15)          not null,
   ENV_DIRECCION        varchar(250)         not null,
   ENV_PRECIO           decimal(9,2)         not null,
   constraint PK_ENVIO primary key (ENV_NUMERO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('ENVIO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'ENVIO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene informacion acerca del envio (delivery) de la venta del cliente', 
   'user', @CurrentUser, 'table', 'ENVIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ENVIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ENV_NUMERO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ENVIO', 'column', 'ENV_NUMERO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el numero de envio que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'ENVIO', 'column', 'ENV_NUMERO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ENVIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ENV_DIRECCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ENVIO', 'column', 'ENV_DIRECCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la direccion domiciliaria a la que sera enviada la orden',
   'user', @CurrentUser, 'table', 'ENVIO', 'column', 'ENV_DIRECCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('ENVIO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ENV_PRECIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'ENVIO', 'column', 'ENV_PRECIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el costo de transporte de la orden',
   'user', @CurrentUser, 'table', 'ENVIO', 'column', 'ENV_PRECIO'
go

/*==============================================================*/
/* Table: OPCIONES                                              */
/*==============================================================*/
create table OPCIONES (
   OPC_ID               varchar(15)          not null,
   OPC_DESCRIPCION      varchar(250)         null,
   constraint PK_OPCIONES primary key (OPC_ID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('OPCIONES') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'OPCIONES' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene diferentes caracteristicas de un mismo producto, puede ser: talla, color, tela, etc.', 
   'user', @CurrentUser, 'table', 'OPCIONES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('OPCIONES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OPC_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'OPCIONES', 'column', 'OPC_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador que defini la unicidad del registro',
   'user', @CurrentUser, 'table', 'OPCIONES', 'column', 'OPC_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('OPCIONES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OPC_DESCRIPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'OPCIONES', 'column', 'OPC_DESCRIPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la descripcion de la opcion a la que hace referencia',
   'user', @CurrentUser, 'table', 'OPCIONES', 'column', 'OPC_DESCRIPCION'
go

/*==============================================================*/
/* Table: OPCIONES_PRODUCTO                                     */
/*==============================================================*/
create table OPCIONES_PRODUCTO (
   PRD_ID               varchar(15)          not null,
   OPC_ID               varchar(15)          not null
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('OPCIONES_PRODUCTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'OPCIONES_PRODUCTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Tabla interseccion que relaciona un producto con una determinada opcion', 
   'user', @CurrentUser, 'table', 'OPCIONES_PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('OPCIONES_PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'OPCIONES_PRODUCTO', 'column', 'PRD_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'OPCIONES_PRODUCTO', 'column', 'PRD_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('OPCIONES_PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'OPC_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'OPCIONES_PRODUCTO', 'column', 'OPC_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador que defini la unicidad del registro',
   'user', @CurrentUser, 'table', 'OPCIONES_PRODUCTO', 'column', 'OPC_ID'
go

/*==============================================================*/
/* Index: PRODUCTO_TIENE_OPCIONES_FK                            */
/*==============================================================*/




create nonclustered index PRODUCTO_TIENE_OPCIONES_FK on OPCIONES_PRODUCTO (PRD_ID ASC)
go

/*==============================================================*/
/* Index: OPCIONES_PERTENECEN_PRODUCTO_FK                       */
/*==============================================================*/




create nonclustered index OPCIONES_PERTENECEN_PRODUCTO_FK on OPCIONES_PRODUCTO (OPC_ID ASC)
go

/*==============================================================*/
/* Table: PARAMETROS_GENERALES                                  */
/*==============================================================*/
create table PARAMETROS_GENERALES (
   PAR_NOMBRE           varchar(50)          not null,
   PAR_VALOR            varchar(50)          not null,
   constraint PK_PARAMETROS_GENERALES primary key (PAR_NOMBRE)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('PARAMETROS_GENERALES') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'PARAMETROS_GENERALES' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene valores generales para la organización', 
   'user', @CurrentUser, 'table', 'PARAMETROS_GENERALES'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PARAMETROS_GENERALES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PAR_NOMBRE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PARAMETROS_GENERALES', 'column', 'PAR_NOMBRE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el nombre del parametro que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'PARAMETROS_GENERALES', 'column', 'PAR_NOMBRE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PARAMETROS_GENERALES')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PAR_VALOR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PARAMETROS_GENERALES', 'column', 'PAR_VALOR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el valor del parametro',
   'user', @CurrentUser, 'table', 'PARAMETROS_GENERALES', 'column', 'PAR_VALOR'
go

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   PRD_ID               varchar(15)          not null,
   PRD_NOMBRE           varchar(25)          null,
   PRD_PRECIO           decimal(9,2)         not null,
   PRD_PESO             decimal(9,2)         null,
   PRD_DESCRIPCION      varchar(100)         null,
   PRD_MINIATURA        binary(8000)         null,
   PRD_RUTA_IMAGEN      varchar(250)         null,
   PRD_FECHA_CREACION   datetime             null,
   PRD_STOCK            int                  null default 0
      constraint CKC_PRD_STOCK_PRODUCTO check (PRD_STOCK is null or (PRD_STOCK >= 0)),
   constraint PK_PRODUCTO primary key (PRD_ID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('PRODUCTO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'PRODUCTO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene los articulos que se ofrecen al publico', 
   'user', @CurrentUser, 'table', 'PRODUCTO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_NOMBRE')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_NOMBRE'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el nombre del producto',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_NOMBRE'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_PRECIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_PRECIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el precio del producto',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_PRECIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_PESO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_PESO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el peso del producto en kilogramos',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_PESO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_DESCRIPCION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_DESCRIPCION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la descripcion del producto',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_DESCRIPCION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_MINIATURA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_MINIATURA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene una imagen de baja resolucion que hace referencia al producto',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_MINIATURA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_RUTA_IMAGEN')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_RUTA_IMAGEN'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la ruta en el servidor de la imagen del producto',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_RUTA_IMAGEN'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_FECHA_CREACION')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_FECHA_CREACION'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la fecha en que el producto fue creado',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_FECHA_CREACION'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('PRODUCTO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PRD_STOCK')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_STOCK'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el numero de unidades existentes en el inventario',
   'user', @CurrentUser, 'table', 'PRODUCTO', 'column', 'PRD_STOCK'
go

/*==============================================================*/
/* Table: TIPO_PAGO                                             */
/*==============================================================*/
create table TIPO_PAGO (
   TIP_ID               varchar(15)          not null,
   TIP_DESC             varchar(250)         null,
   constraint PK_TIPO_PAGO primary key (TIP_ID)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TIPO_PAGO') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TIPO_PAGO' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene informacion de la manera en que el cliente efectua el pago sobre la venta', 
   'user', @CurrentUser, 'table', 'TIPO_PAGO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_PAGO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TIP_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_PAGO', 'column', 'TIP_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador del tipo de pago que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'TIPO_PAGO', 'column', 'TIP_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TIPO_PAGO')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TIP_DESC')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TIPO_PAGO', 'column', 'TIP_DESC'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la descripcion del tipo de pago',
   'user', @CurrentUser, 'table', 'TIPO_PAGO', 'column', 'TIP_DESC'
go

/*==============================================================*/
/* Table: VENTA                                                 */
/*==============================================================*/
create table VENTA (
   VEN_NUMERO           varchar(15)          not null,
   CLI_USUARIO          varchar(50)          not null,
   TIP_ID               varchar(15)          not null,
   ENV_NUMERO           varchar(15)          null,
   VEN_FECHA            datetime             not null,
   VEN_DIRECCION_CLI    varchar(250)         not null,
   VEN_EMAIL_CLI        varchar(50)          not null,
   VEN_PRECIO_TOTAL     decimal(9,2)         null,
   constraint PK_VENTA primary key (VEN_NUMERO)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('VENTA') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'VENTA' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contiene informacion acerca de la compra', 
   'user', @CurrentUser, 'table', 'VENTA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VEN_NUMERO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_NUMERO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el numero de venta que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_NUMERO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'CLI_USUARIO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'CLI_USUARIO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene una secuencia alfanumerica que sirve como identificador de la cuenta del usuario y define la unicidad del registro',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'CLI_USUARIO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TIP_ID')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'TIP_ID'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el identificador del tipo de pago que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'TIP_ID'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'ENV_NUMERO')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'ENV_NUMERO'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el numero de envio que define la unicidad del registro',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'ENV_NUMERO'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VEN_FECHA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_FECHA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la fecha en que fue efectuada la venta',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_FECHA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VEN_DIRECCION_CLI')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_DIRECCION_CLI'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene la direccion que el cliente desea registrar en la venta',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_DIRECCION_CLI'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VEN_EMAIL_CLI')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_EMAIL_CLI'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el correo electronico que proporciona el cliente para la venta',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_EMAIL_CLI'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('VENTA')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'VEN_PRECIO_TOTAL')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_PRECIO_TOTAL'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Contiene el monto total por el cual se efectua la venta',
   'user', @CurrentUser, 'table', 'VENTA', 'column', 'VEN_PRECIO_TOTAL'
go

/*==============================================================*/
/* Index: VENTA_PERTENECE_CLIENTE_FK                            */
/*==============================================================*/




create nonclustered index VENTA_PERTENECE_CLIENTE_FK on VENTA (CLI_USUARIO ASC)
go

/*==============================================================*/
/* Index: VENTA_TIENE_TIPO_PAGO_FK                              */
/*==============================================================*/




create nonclustered index VENTA_TIENE_TIPO_PAGO_FK on VENTA (TIP_ID ASC)
go

/*==============================================================*/
/* Index: VENTA_TIENE_ENVIO_FK                                  */
/*==============================================================*/




create nonclustered index VENTA_TIENE_ENVIO_FK on VENTA (ENV_NUMERO ASC)
go

alter table CATEGORIA_PRODUCTO
   add constraint FK_CATEGORI_CATEGORIA_CATEGORI foreign key (CAT_ID)
      references CATEGORIA (CAT_ID)
go

alter table CATEGORIA_PRODUCTO
   add constraint FK_CATEGORI_PRODUCTO__PRODUCTO foreign key (PRD_ID)
      references PRODUCTO (PRD_ID)
go

alter table DETALLE_VENTA
   add constraint FK_DETALLE__DETALLE_V_VENTA foreign key (VEN_NUMERO)
      references VENTA (VEN_NUMERO)
go

alter table DETALLE_VENTA
   add constraint FK_DETALLE__PRODUCTO__PRODUCTO foreign key (PRD_ID)
      references PRODUCTO (PRD_ID)
go

alter table OPCIONES_PRODUCTO
   add constraint FK_OPCIONES_OPCIONES__OPCIONES foreign key (OPC_ID)
      references OPCIONES (OPC_ID)
go

alter table OPCIONES_PRODUCTO
   add constraint FK_OPCIONES_PRODUCTO__PRODUCTO foreign key (PRD_ID)
      references PRODUCTO (PRD_ID)
go

alter table VENTA
   add constraint FK_VENTA_VENTA_PER_CLIENTE foreign key (CLI_USUARIO)
      references CLIENTE (CLI_USUARIO)
go

alter table VENTA
   add constraint FK_VENTA_VENTA_TIE_ENVIO foreign key (ENV_NUMERO)
      references ENVIO (ENV_NUMERO)
go

alter table VENTA
   add constraint FK_VENTA_VENTA_TIE_TIPO_PAG foreign key (TIP_ID)
      references TIPO_PAGO (TIP_ID)
go
