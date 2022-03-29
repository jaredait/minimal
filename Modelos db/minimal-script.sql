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


/*==============================================================*/
/* Table: CATEGORIA_PRODUCTO                                    */
/*==============================================================*/
create table CATEGORIA_PRODUCTO (
   CAT_ID               varchar(15)          not null,
   PRD_ID               varchar(25)          not null
)
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
   CLI_SEXO             char(1)              null,
   CLI_DIRECCION        varchar(250)         null,
   CLI_CIUDAD           varchar(50)          null,
   CLI_PROVINCIA        varchar(50)          null,
   CLI_TELEFONO         varchar(10)          null,
   constraint PK_CLIENTE primary key (CLI_USUARIO)
)
go

/*==============================================================*/
/* Table: DETALLE_FACTURA                                       */
/*==============================================================*/
create table DETALLE_FACTURA (
   PRD_ID               varchar(25)          not null,
   FAC_NUMERO           varchar(15)          not null,
   DET_PRECIO_PRD       decimal(9,2)         not null,
   DET_CANTIDAD         int                  not null
)
go


/*==============================================================*/
/* Index: PRODUCTO_PERTENECE_DETALLE_FACTURA_FK                 */
/*==============================================================*/


create nonclustered index PRODUCTO_PERTENECE_DETALLE_FACTURA_FK on DETALLE_FACTURA (PRD_ID ASC)
go

/*==============================================================*/
/* Index: DETALLE_FACTURA_PERTENECE_FACTURA_FK                  */
/*==============================================================*/


create nonclustered index DETALLE_FACTURA_PERTENECE_FACTURA_FK on DETALLE_FACTURA (FAC_NUMERO ASC)
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


/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA (
   FAC_NUMERO           varchar(15)          not null,
   CLI_USUARIO          varchar(50)          not null,
   TIP_ID               varchar(15)          not null,
   ENV_NUMERO           varchar(15)          null,
   FAC_FECHA            datetime             not null,
   FAC_DIRECCION_CLI    varchar(250)         not null,
   FAC_EMAIL_CLI        varchar(50)          not null,
   FAC_MONTO_SUBTOTAL   decimal(9,2)         null,
   FAC_MONTO_TOTAL      decimal(9,2)         null,
   constraint PK_FACTURA primary key (FAC_NUMERO)
)
go

/*==============================================================*/
/* Index: FACTURA_PERTENECE_CLIENTE_FK                          */
/*==============================================================*/




create nonclustered index FACTURA_PERTENECE_CLIENTE_FK on FACTURA (CLI_USUARIO ASC)
go

/*==============================================================*/
/* Index: FACTURA_TIENE_TIPO_PAGO_FK                            */
/*==============================================================*/




create nonclustered index FACTURA_TIENE_TIPO_PAGO_FK on FACTURA (TIP_ID ASC)
go

/*==============================================================*/
/* Index: FACTURA_TIENE_ENVIO_FK                                */
/*==============================================================*/




create nonclustered index FACTURA_TIENE_ENVIO_FK on FACTURA (ENV_NUMERO ASC)
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



/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO (
   PRD_ID               varchar(25)          not null,
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

/*==============================================================*/
/* Table: TIPO_PAGO                                             */
/*==============================================================*/
create table TIPO_PAGO (
   TIP_ID               varchar(15)          not null,
   TIP_DESC             varchar(250)         null,
   constraint PK_TIPO_PAGO primary key (TIP_ID)
)
go


alter table CATEGORIA_PRODUCTO
   add constraint FK_CATEGORI_CATEGORIA_CATEGORI foreign key (CAT_ID)
      references CATEGORIA (CAT_ID)
go

alter table CATEGORIA_PRODUCTO
   add constraint FK_CATEGORI_PRODUCTO__PRODUCTO foreign key (PRD_ID)
      references PRODUCTO (PRD_ID)
go

alter table DETALLE_FACTURA
   add constraint FK_DETALLE__DETALLE_F_FACTURA foreign key (FAC_NUMERO)
      references FACTURA (FAC_NUMERO)
go

alter table DETALLE_FACTURA
   add constraint FK_DETALLE__PRODUCTO__PRODUCTO foreign key (PRD_ID)
      references PRODUCTO (PRD_ID)
go

alter table FACTURA
   add constraint FK_FACTURA_FACTURA_P_CLIENTE foreign key (CLI_USUARIO)
      references CLIENTE (CLI_USUARIO)
go

alter table FACTURA
   add constraint FK_FACTURA_FACTURA_T_ENVIO foreign key (ENV_NUMERO)
      references ENVIO (ENV_NUMERO)
go

alter table FACTURA
   add constraint FK_FACTURA_FACTURA_T_TIPO_PAG foreign key (TIP_ID)
      references TIPO_PAGO (TIP_ID)
go
