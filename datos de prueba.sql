-- DATOS DE PRUEBA (OPCIONAL) - no modifica el esquema, solo inserta filas.
-- Ejecutar despues de "base de datos.sql".
use SistemaSalud
go

-- Provincias (IdProvincia no es identity)
insert into Provincias (IdProvincia, NombreProvincia)
select v.id, v.nombre from (values
  (1, 'Distrito Nacional'),
  (2, 'Santo Domingo'),
  (3, 'Santiago'),
  (4, 'San Pedro')

) v(id, nombre)
where not exists (select 1 from Provincias p where p.IdProvincia = v.id)

-- Tipos de establecimiento (IdTipo no es identity)
insert into TipoEstablecimiento (IdTipo, Nombre, descripcion)
select v.id, v.nombre, v.descr from (values
  (1, 'Hospital', 'Centro de atencion de alta complejidad'),
  (2, 'Clinica', 'Centro de atencion privado'),
  (3, 'Centro de Atencion Primaria', 'Primer nivel de atencion')
) v(id, nombre, descr)
where not exists (select 1 from TipoEstablecimiento t where t.IdTipo = v.id)

-- Usuarios
insert into Usuarios (Nombre, usuario, contraseña, Rol, IdProvincia)
select v.nombre, v.usr, v.pwd, v.rol, v.prov from (values
  ('Admin Nacional',   'nacional',  '1234', 'AdministradorNacional',   cast(null as int)),
  ('Admin Dist. Nac.', 'dn',        '1234', 'AdministradorProvincial', 1),
  ('Admin Sto. Dgo.',  'sd',        '1234', 'AdministradorProvincial', 2),
  ('Admin San Pedro',  'spm',        '1234', 'AdministradorProvincial', 4)
) v(nombre, usr, pwd, rol, prov)
where not exists (select 1 from Usuarios u where u.usuario = v.usr)

-- Establecimientos 
if not exists (select 1 from Establecimientos)
insert into Establecimientos (Nombre, Direccion, Telefono, IdProvincia, IdTipo) values
  ('Hospital Central DN',   'Av. Independencia 100', '809-555-0001', 1, 1),
  ('Clinica Norte DN',      'Calle 5 #20',           '809-555-0002', 1, 2),
  ('Hospital Sto. Dgo. Este','Autopista San Isidro', '809-555-0003', 2, 1),
  ('Centro Primario Santiago','Calle Duarte 45',     '809-555-0004', 3, 3)
