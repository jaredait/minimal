/* INSERTAR CATEGORIAS */

INSERT INTO CATEGORIA VALUES('CAMREG', 'Camiseta', 'Camisetas regulares cuello redondo', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('CAMPOL', 'Polo', 'Camisetas polo', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('PANTJEAN', 'Jean', 'Pantalones Jeans - Vaqueros', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('PANTCHI', 'Chino', 'Pantalones Chinos', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('PANTCARG', 'Cargo', 'Pantalones cargo', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('PANTVEST', 'Vestir', 'Pantalones de vestir', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('ZAPTEN', 'Tennis', 'Tennis', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('ZAPDEP', 'Deportivo', 'Zapatos deportivos', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('MED', 'Medias', 'Medias', 0x222222, 'imagen');
INSERT INTO CATEGORIA VALUES('GAF', 'Lentes de Sol', 'Lentes de sol', 0x222222, 'imagen');

/* INSERTAR PRODUCTOS */

INSERT INTO PRODUCTO VALUES('CAMNEGM', 'Camiseta', 15.99, 100, 'Camiseta negra talla M', 0x222222, 'imagen', '2022-04-03', 100);
INSERT INTO PRODUCTO VALUES('POLCELS', 'Polo', 24.99, 200, 'Polo celeste talla S', 0x222222, 'imagen', '2022-04-03', 55);
INSERT INTO PRODUCTO VALUES('JEANAZU38', 'Jean', 45.99, 700, 'Jean azul talla 38', 0x222222, 'imagen', '2022-04-03', 95);
INSERT INTO PRODUCTO VALUES('CHIVERO36', 'Chino', 39.99, 700, 'Chino verde olivo talla 36', 0x222222, 'imagen', '2022-04-03', 75);
INSERT INTO PRODUCTO VALUES('CARGBEI38', 'Cargo', 49.99, 700, 'Cargo beige talla 38', 0x222222, 'imagen', '2022-04-03', 62);
INSERT INTO PRODUCTO VALUES('PANTVESTGRI40', 'Vestir', 44.99, 400, 'Pantalon de vestir gris talla 40', 0x222222, 'imagen', '2022-04-03', 55);
INSERT INTO PRODUCTO VALUES('TENBLA8', 'Tennis', 59.99, 300, 'Tennis blanco talla 8', 0x222222, 'imagen', '2022-04-03', 50);
INSERT INTO PRODUCTO VALUES('DEPNEG8', 'Deportivo', 44.99, 400, 'Zapatos deportivos negros talla 8', 0x222222, 'imagen', '2022-04-03', 45);
INSERT INTO PRODUCTO VALUES('MEDROJ1012', 'Medias', 9.99, 50, 'Medias rojas talla 10-12', 0x222222, 'imagen', '2022-04-03', 74);
INSERT INTO PRODUCTO VALUES('GAFCAF', 'Lentes de sol', 39.99, 8, 'Lentes de sol cafes', 0x222222, 'imagen', '2022-04-03', 45);

/* INSERTAR CLIENTES */

INSERT INTO CLIENTE VALUES('1726547531', 'Aagarciar9173', '1726547531', 'aagarciar@hotmail.com', 'Alberth', 'Garcia', 22, 'M', 'San Pedro conjunto Arupos de la hacienda', 'Quito', 'Pichincha', '0986257891');
INSERT INTO CLIENTE VALUES('1765498751', 'Xlcaceres5737', '1765498751', 'xlcaceres@hotmail.com', 'Ximena', 'Caceres', 24, 'F', 'Conocoto Av Lola Quintana conjunto Juan Pablo II', 'Quito', 'Pichincha', '0986857423');
INSERT INTO CLIENTE VALUES('1710218475', 'Jampudiam8528', '1710218475', 'jampudiam@hotmail.com', 'Jared', 'Ampudia', 24, 'M', 'Armenia 1, Alfredo Baquerizo Moreno y Pablo Palacios', 'Quito', 'Pichincha', '0985478523');
INSERT INTO CLIENTE VALUES('1775315987', 'Valvarez7582', '1775315987', 'valvarez@hotmail.com', 'Victor', 'Alvarez', 20, 'M', 'Conocoto Garcia Moreno y Juan Montalvo', 'Quito', 'Pichincha', '0987625413');
INSERT INTO CLIENTE VALUES('1711254878', 'Fborja7469', '1711254878', 'fborja@hotmail.com', 'Fausto', 'Borja', 21, 'M', 'Barrio Selva Alegre Conjunto Alcantara', 'Quito', 'Pichincha', '0985791324');
INSERT INTO CLIENTE VALUES('1752486953', 'Imolina4916', '1752486953', 'imolina@hotmail.com', 'Ivan', 'Molina', 21, 'M', 'Tumbaco conjunto Agua Marina', 'Quito', 'Pichincha', '0991910178');
INSERT INTO CLIENTE VALUES('1783924657', 'Nmayanquer7982', '1783924657', 'nmayanquer@hotmail.com', 'Nicolas', 'Mayanquer', 21, 'M', 'Armenia 2 Juan Berrezueta y Pinos', 'Quito', 'Pichincha', '0991984759');
INSERT INTO CLIENTE VALUES('1793248651', 'Aguijarro8276', '1793248651', 'aguijarro@hotmail.com', 'Alan', 'Guijarro', 20, 'M', 'Armenia 2 Manuela Cañizares y Lola Quintana', 'Quito', 'Pichincha', '0985792453');
INSERT INTO CLIENTE VALUES('1756982567', 'Mletere8237', '1756982567', 'mletere@hotmail.com', 'Matias', 'Letere', 22, 'M', 'Av. Mariscal Sucre Sur de Quito', 'Quito', 'Pichincha', '0989755789');
INSERT INTO CLIENTE VALUES('1739286491', 'Mmales4652', '1739286491', 'mmales@hotmail.com', 'Micaela', 'Males', 22, 'M', 'Armenia 2 conjunto tehia', 'Quito', 'Pichincha', '0991998620');

/* INSERTAR ENVIOS */

INSERT INTO ENVIO VALUES('1', 'Armenia 1, Alfredo Baquerizo Moreno y Pablo Palacios', 4.99);
INSERT INTO ENVIO VALUES('2', 'Barrio Selva Alegre Conjunto Alcantara', 4.99);
INSERT INTO ENVIO VALUES('3', 'San Pedro conjunto Arupos de la hacienda', 4.99);
INSERT INTO ENVIO VALUES('4', 'Armenia 2 conjunto tehia', 4.99);
INSERT INTO ENVIO VALUES('5', 'Tumbaco conjunto Agua Marina', 4.99);
INSERT INTO ENVIO VALUES('6', 'Av. Mariscal Sucre Sur de Quito', 4.99);
INSERT INTO ENVIO VALUES('7', 'Conocoto Garcia Moreno y Juan Montalvo', 4.99);
INSERT INTO ENVIO VALUES('8', 'Conocoto Av Lola Quintana conjunto Juan Pablo II', 4.99);
INSERT INTO ENVIO VALUES('9', 'Armenia 2 Manuela Cañizares y Lola Quintana', 4.99);
INSERT INTO ENVIO VALUES('10', 'Armenia 2 Juan Berrezueta y Pinos', 4.99);

/* INSERTAR TIPOS DE PAGO */

INSERT INTO TIPO_PAGO VALUES('1', 'Tarjeta de credito');
INSERT INTO TIPO_PAGO VALUES('2', 'Tarjeta de debito');
INSERT INTO TIPO_PAGO VALUES('3', 'Transferencia');

/* INSERTAR PARAMETROS GENERALES */

INSERT INTO PARAMETROS_GENERALES VALUES('IVA', '0.12');

/* INSERTAR FACTURAS */

INSERT INTO FACTURA VALUES('001001000000001', '1710218475', '1', '1', '2022-04-03', 'Armenia 1', 'jampudiam@hotmail.com', 15.99, 17.91);
INSERT INTO FACTURA VALUES('001001000000002', '1711254878', '2', '2', '2022-04-03', 'Barrio Selva Alegre', 'fborja@hotmail.com', 24.99, 27.99);
INSERT INTO FACTURA VALUES('001001000000003', '1726547531', '3', '3', '2022-04-03', 'San Pedro', 'aagarciar@hotmail.com', 45.99, 51.51);
INSERT INTO FACTURA VALUES('001001000000004', '1739286491', '1', '4', '2022-04-03', 'Armenia 2', 'mmales@hotmail.com', 39.99, 44.79);
INSERT INTO FACTURA VALUES('001001000000005', '1752486953', '2', '5', '2022-04-03', 'Tumbaco', 'imolina@hotmail.com', 49.99, 55.99);
INSERT INTO FACTURA VALUES('001001000000006', '1756982567', '3', '6', '2022-04-03', 'La Magdalena', 'mletere@hotmail.com', 49.99, 55.99);
INSERT INTO FACTURA VALUES('001001000000007', '1765498751', '1', '7', '2022-04-03', 'Conocoto', 'xlcaceres@hotmail.com', 59.99, 67.19);
INSERT INTO FACTURA VALUES('001001000000008', '1775315987', '2', '8', '2022-04-03', 'Conocoto', 'valvarez@hotmail.com', 44.99, 55.99);
INSERT INTO FACTURA VALUES('001001000000009', '1783924657', '3', '9', '2022-04-03', 'Armenia 2', 'nmayanquer@hotmail.com', 9.99, 11.19);
INSERT INTO FACTURA VALUES('001001000000010', '1793248651', '1', '10', '2022-04-03', 'Armenia 2', 'aguijarro@hotmail.com', 39.99, 44.79);

/* INSERTAR DETALLES DE FACTURAS */

INSERT INTO DETALLE_FACTURA VALUES('CAMNEGM', '001001000000001', 15.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('POLCELS', '001001000000002', 24.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('JEANAZU38', '001001000000003', 45.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('CHIVERO36', '001001000000004', 39.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('CARGBEI38', '001001000000005', 49.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('PANTVESTGRI40', '001001000000006', 49.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('TENBLA8', '001001000000007', 59.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('DEPNEG8', '001001000000008', 44.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('MEDROJ1012', '001001000000009', 9.99, 1);
INSERT INTO DETALLE_FACTURA VALUES('GAFCAF', '001001000000010', 39.99, 1);

/* INSERTAR CATEGORIA_PRODUCTO */

INSERT INTO CATEGORIA_PRODUCTO VALUES('CAMREG', 'CAMNEGM');
INSERT INTO CATEGORIA_PRODUCTO VALUES('CAMPOL', 'POLCELS');
INSERT INTO CATEGORIA_PRODUCTO VALUES('PANTJEAN', 'JEANAZU38');
INSERT INTO CATEGORIA_PRODUCTO VALUES('PANTCHI', 'CHIVERO36');
INSERT INTO CATEGORIA_PRODUCTO VALUES('PANTCARG', 'CARGBEI38');
INSERT INTO CATEGORIA_PRODUCTO VALUES('PANTVEST', 'PANTVESTGRI40');
INSERT INTO CATEGORIA_PRODUCTO VALUES('ZAPTEN', 'TENBLA8');
INSERT INTO CATEGORIA_PRODUCTO VALUES('ZAPDEP', 'DEPNEG8');
INSERT INTO CATEGORIA_PRODUCTO VALUES('MED', 'MEDROJ1012');
INSERT INTO CATEGORIA_PRODUCTO VALUES('GAF', 'GAFCAF');
