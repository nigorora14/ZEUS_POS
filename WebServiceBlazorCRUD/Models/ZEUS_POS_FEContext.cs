using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class ZEUS_POS_FEContext : DbContext
    {
        public ZEUS_POS_FEContext()
        {
        }

        public ZEUS_POS_FEContext(DbContextOptions<ZEUS_POS_FEContext> options) : base(options)
        {
        }

        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<CierreCaja> CierreCajas { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cotizacion> Cotizacions { get; set; }
        public virtual DbSet<Credito> Creditos { get; set; }
        public virtual DbSet<DetalleCredito> DetalleCreditos { get; set; }
        public virtual DbSet<DetalleDocumCompra> DetalleDocumCompras { get; set; }
        public virtual DbSet<DetalleKardex> DetalleKardices { get; set; }
        public virtual DbSet<DetalleNotaCredito> DetalleNotaCreditos { get; set; }
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }
        public virtual DbSet<DetalleTemporal> DetalleTemporals { get; set; }
        public virtual DbSet<Distrito> Distritos { get; set; }
        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<DocumentoCompra> DocumentoCompras { get; set; }
        public virtual DbSet<KardexProducto> KardexProductos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<MenuXUsu> MenuXUsus { get; set; }
        public virtual DbSet<MiEmpresa> MiEmpresas { get; set; }
        public virtual DbSet<NotaCredito> NotaCreditos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedors { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Temporal> Temporals { get; set; }
        public virtual DbSet<TipoDoc> TipoDocs { get; set; }
        public virtual DbSet<Ubigeo> Ubigeos { get; set; }
        public virtual DbSet<Usuarios2> Usuarios2s { get; set; }
        public virtual DbSet<VCajaUsuario> VCajaUsuarios { get; set; }
        public virtual DbSet<VCierreCajaUsu> VCierreCajaUsus { get; set; }
        public virtual DbSet<VClientesDistrito> VClientesDistritos { get; set; }
        public virtual DbSet<VDocumentoCredito> VDocumentoCreditos { get; set; }
        public virtual DbSet<VDocumentoCreditoPrint2> VDocumentoCreditoPrint2s { get; set; }
        public virtual DbSet<VDocumentoCreditoYDetalle> VDocumentoCreditoYDetalles { get; set; }
        public virtual DbSet<VDocumentosCompraDetalle> VDocumentosCompraDetalles { get; set; }
        public virtual DbSet<VDocumentosCompraPrincipal> VDocumentosCompraPrincipals { get; set; }
        public virtual DbSet<VIstaNotacreditoGnral> VIstaNotacreditoGnrals { get; set; }
        public virtual DbSet<VKardexDetalle> VKardexDetalles { get; set; }
        public virtual DbSet<VKardexDetalle2> VKardexDetalle2s { get; set; }
        public virtual DbSet<VKardexDetallePrint> VKardexDetallePrints { get; set; }
        public virtual DbSet<VListadoDocumento> VListadoDocumentos { get; set; }
        public virtual DbSet<VListadoDocumentoDetalle> VListadoDocumentoDetalles { get; set; }
        public virtual DbSet<VListadoNotacredito> VListadoNotacreditos { get; set; }
        public virtual DbSet<VListadoPedidoDetalle> VListadoPedidoDetalles { get; set; }
        public virtual DbSet<VPedidosClienteGeneral> VPedidosClienteGenerals { get; set; }
        public virtual DbSet<VProductosYDependiente> VProductosYDependientes { get; set; }
        public virtual DbSet<VTemporalesDetalle> VTemporalesDetalles { get; set; }
        public virtual DbSet<VUsuariosRoles2> VUsuariosRoles2s { get; set; }
        public virtual DbSet<VVistaCotizacionPedidoCliente> VVistaCotizacionPedidoClientes { get; set; }
        public virtual DbSet<VVistaCotizacionPedidoDetalle> VVistaCotizacionPedidoDetalles { get; set; }
        public virtual DbSet<ValeCompra> ValeCompras { get; set; }
        public virtual DbSet<ZzTablaTest> ZzTablaTests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=192.168.0.100; initial Catalog=ZEUS_POS_FE;uid=SPV;pwd=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.HasKey(e => e.Idcaja)
                    .HasName("PK__Caja__08DCF1BC548FDD05");

                entity.ToTable("Caja");

                entity.Property(e => e.Concepto).HasMaxLength(190);

                entity.Property(e => e.DePara)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("De_Para");

                entity.Property(e => e.EstadoCaja)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaja)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Caja");

                entity.Property(e => e.GeneradoPor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsu)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.NroDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nro_Doc")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Caja");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCat)
                    .HasName("PK__Categori__5EE0B14413EB1D60");

                entity.Property(e => e.IdCat).HasColumnName("Id_Cat");

                entity.Property(e => e.Categoria1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Categoria");
            });

            modelBuilder.Entity<CierreCaja>(entity =>
            {
                entity.HasKey(e => e.IdCierre)
                    .HasName("PK__Cierre_C__B5D9E395F2A213A1");

                entity.ToTable("Cierre_Caja");

                entity.Property(e => e.IdCierre)
                    .HasMaxLength(15)
                    .HasColumnName("Id_cierre");

                entity.Property(e => e.AperturaCaja).HasColumnName("Apertura_Caja");

                entity.Property(e => e.EstadoCierre)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_cierre");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Cierre");

                entity.Property(e => e.IdUsu)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.TotalIngreso).HasColumnName("Total_Ingreso");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__3DD0A8CBA770AEA2");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EMail)
                    .HasMaxLength(150)
                    .HasColumnName("E_Mail");

                entity.Property(e => e.EstadoCli)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cli");

                entity.Property(e => e.FchaNcmntoAnivsrio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fcha_Ncmnto_Anivsrio");

                entity.Property(e => e.Foto)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdDis).HasColumnName("Id_Dis");

                entity.Property(e => e.LimitCredit).HasColumnName("Limit_Credit");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdDisNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdDis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cli_Dis");
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.HasKey(e => e.IdCotiza)
                    .HasName("PK__Cotizaci__D4CCEEA96B2CF0EC");

                entity.ToTable("Cotizacion");

                entity.Property(e => e.IdCotiza)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cotiza");

                entity.Property(e => e.Condiciones)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCoti)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCoti).HasColumnType("datetime");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Ped");

                entity.Property(e => e.PrecioconIgv)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdPedNavigation)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.IdPed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_coti_cli");
            });

            modelBuilder.Entity<Credito>(entity =>
            {
                entity.HasKey(e => e.IdNotaCred)
                    .HasName("PK__Credito__25E448027BB1E92F");

                entity.ToTable("Credito");

                entity.Property(e => e.IdNotaCred).HasMaxLength(15);

                entity.Property(e => e.EstadoCred)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cred");

                entity.Property(e => e.FechaCredito)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Credito");

                entity.Property(e => e.FechaVncimnto)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Vncimnto");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Doc");

                entity.Property(e => e.NomCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Cliente");

                entity.Property(e => e.SaldoPdnte).HasColumnName("Saldo_Pdnte");

                entity.Property(e => e.TotalCre).HasColumnName("Total_Cre");

                entity.HasOne(d => d.IdDocNavigation)
                    .WithMany(p => p.Creditos)
                    .HasForeignKey(d => d.IdDoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cre_doc");
            });

            modelBuilder.Entity<DetalleCredito>(entity =>
            {
                entity.HasKey(e => e.IdDetCred)
                    .HasName("PK__Detalle___ED16654A46A85C68");

                entity.ToTable("Detalle_Credito");

                entity.Property(e => e.IdDetCred).HasColumnName("Id_DetCred");

                entity.Property(e => e.ACuenta).HasColumnName("A_cuenta");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Pago");

                entity.Property(e => e.IdNotaCred)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.NroOperaComent)
                    .HasMaxLength(180)
                    .HasColumnName("Nro_Opera_Coment");

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNotaCredNavigation)
                    .WithMany(p => p.DetalleCreditos)
                    .HasForeignKey(d => d.IdNotaCred)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cre_det");
            });

            modelBuilder.Entity<DetalleDocumCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detalle_DocumCompra");

                entity.Property(e => e.IdDocComp)
                    .HasMaxLength(15)
                    .HasColumnName("Id_DocComp");

                entity.Property(e => e.IdPro)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.HasOne(d => d.IdDocCompNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdDocComp)
                    .HasConstraintName("FK_Detalle_DocumCompra_DocumentoCompras");

                entity.HasOne(d => d.IdProNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPro)
                    .HasConstraintName("FK_Detalle_DocumCompra_Productos");
            });

            modelBuilder.Entity<DetalleKardex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detalle_Kardex");

                entity.Property(e => e.CantidadIn).HasColumnName("Cantidad_In");

                entity.Property(e => e.CantidadOut).HasColumnName("Cantidad_Out");

                entity.Property(e => e.CantidadSaldo).HasColumnName("Cantidad_Saldo");

                entity.Property(e => e.CostoTotalSaldo).HasColumnName("Costo_Total_Saldo");

                entity.Property(e => e.DetOperacion)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Det_Operacion");

                entity.Property(e => e.DocSoporte)
                    .HasMaxLength(20)
                    .HasColumnName("Doc_Soporte")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaKrdx)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Krdx");

                entity.Property(e => e.IdKrdx)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_krdx");

                entity.Property(e => e.PrecioIn).HasColumnName("Precio_In");

                entity.Property(e => e.PrecioOut).HasColumnName("Precio_Out");

                entity.Property(e => e.TotalIn).HasColumnName("Total_In");

                entity.Property(e => e.TotalOut).HasColumnName("Total_Out");

                entity.HasOne(d => d.IdKrdxNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdKrdx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kar_det");
            });

            modelBuilder.Entity<DetalleNotaCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detalle_NotaCredito");

                entity.Property(e => e.CantOrigen).HasColumnName("Cant_Origen");

                entity.Property(e => e.DetalleNotaCredi)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdCre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cre");

                entity.Property(e => e.IdPro)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.TipoProdctonc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCreNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_boleta2_Cod");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detalle_Pedido");

                entity.Property(e => e.AfectoIgv)
                    .HasMaxLength(15)
                    .HasColumnName("AfectoIGV");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'Salida Venta')");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.IgvSubtotal).HasColumnName("Igv_subtotal");

                entity.Property(e => e.ImporteConIgv).HasColumnName("Importe_ConIgv");

                entity.Property(e => e.PCantOriginal).HasColumnName("P_Cant_Original");

                entity.Property(e => e.PrecioConIgv).HasColumnName("Precio_ConIgv");

                entity.Property(e => e.PrecioSinIgv).HasColumnName("Precio_sinIgv");

                entity.Property(e => e.SubtotalSinIgv).HasColumnName("subtotal_sinIgv");

                entity.Property(e => e.TipoProd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Prod");

                entity.Property(e => e.UndMedida)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Und_Medida");

                entity.Property(e => e.UtilidadUnit).HasColumnName("Utilidad_Unit");

                entity.HasOne(d => d.IdProNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_det_Prd");
            });

            modelBuilder.Entity<DetalleTemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detalle_Temporal");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(20)
                    .HasColumnName("cantidad")
                    .IsFixedLength(true);

                entity.Property(e => e.CodPro).HasMaxLength(15);

                entity.Property(e => e.CodTem)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("codTem");

                entity.Property(e => e.ImporteT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreUnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pre_Unt");

                entity.Property(e => e.Producto)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.HasKey(e => e.IdDis)
                    .HasName("PK__Distrito__5EAC31382827C34A");

                entity.ToTable("Distrito");

                entity.Property(e => e.IdDis).HasColumnName("Id_Dis");

                entity.Property(e => e.Distrito1)
                    .HasMaxLength(50)
                    .HasColumnName("Distrito");

                entity.Property(e => e.EstadoDis)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Dis");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDoc)
                    .HasName("PK__Document__6ECABA3ECEB75158");

                entity.ToTable("Documento");

                entity.Property(e => e.IdDoc)
                    .HasMaxLength(15)
                    .HasColumnName("id_Doc");

                entity.Property(e => e.CdrSunat)
                    .HasMaxLength(15)
                    .HasColumnName("CDR_Sunat");

                entity.Property(e => e.EstadoBajada).HasMaxLength(15);

                entity.Property(e => e.EstadoDoc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Doc");

                entity.Property(e => e.FechaEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Emi");

                entity.Property(e => e.HashCpe)
                    .HasMaxLength(50)
                    .HasColumnName("Hash_CPE");

                entity.Property(e => e.HashCpeBaja)
                    .HasMaxLength(55)
                    .HasColumnName("Hash_CPE_Baja");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.NroOperacion)
                    .HasMaxLength(20)
                    .HasColumnName("Nro_Operacion")
                    .IsFixedLength(true);

                entity.Property(e => e.NroTicketBaja)
                    .HasMaxLength(50)
                    .HasColumnName("NroTicket_Baja");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLetra).HasMaxLength(280);

                entity.HasOne(d => d.IdPedNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdPed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_doc_ped");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_doc_tip");
            });

            modelBuilder.Entity<DocumentoCompra>(entity =>
            {
                entity.HasKey(e => e.IdDocComp)
                    .HasName("PK__Document__452875B11A2ACAA1");

                entity.Property(e => e.IdDocComp)
                    .HasMaxLength(15)
                    .HasColumnName("Id_DocComp");

                entity.Property(e => e.DatosAdicional)
                    .HasMaxLength(150)
                    .HasColumnName("Datos_Adicional");

                entity.Property(e => e.EstadoIngre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Ingre");

                entity.Property(e => e.FechaIngre)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Ingre");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Usu");

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.ModalidadPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroFacFisico)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NroFac_Fisico")
                    .IsFixedLength(true);

                entity.Property(e => e.SubTotalIngre).HasColumnName("SubTotal_ingre");

                entity.Property(e => e.TipoDocCompra)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TipoDoc_Compra");

                entity.Property(e => e.TipoIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Ingreso");

                entity.Property(e => e.TotalIngre).HasColumnName("Total_Ingre");
            });

            modelBuilder.Entity<KardexProducto>(entity =>
            {
                entity.HasKey(e => e.IdKrdx)
                    .HasName("PK__KardexPr__92FC038E63AD5DF1");

                entity.ToTable("KardexProducto");

                entity.Property(e => e.IdKrdx)
                    .HasMaxLength(15)
                    .HasColumnName("Id_krdx");

                entity.Property(e => e.EstadoKrdx)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCre).HasColumnType("date");

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProNavigation)
                    .WithMany(p => p.KardexProductos)
                    .HasForeignKey(d => d.IdPro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kar_Prod");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__Marcas__28EFE28A5A8CA291");

                entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");

                entity.Property(e => e.Marca1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Marca");
            });

            modelBuilder.Entity<MenuXUsu>(entity =>
            {
                entity.HasKey(e => e.IdMenuxusu)
                    .HasName("PK__Menu_xUs__C8FF14F0E5B08088");

                entity.ToTable("Menu_xUsu");

                entity.Property(e => e.IdMenuxusu).HasColumnName("Id_menuxusu");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_usu");

                entity.Property(e => e.NombreMenu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_menu");
            });

            modelBuilder.Entity<MiEmpresa>(entity =>
            {
                entity.HasKey(e => e.Idrancho)
                    .HasName("PK__MiEmpres__2B643BD8D7E73421");

                entity.ToTable("MiEmpresa");

                entity.Property(e => e.Idrancho)
                    .ValueGeneratedNever()
                    .HasColumnName("idrancho");

                entity.Property(e => e.Clavecertificado)
                    .HasMaxLength(200)
                    .HasColumnName("clavecertificado");

                entity.Property(e => e.Clavecorreo)
                    .HasMaxLength(20)
                    .HasColumnName("clavecorreo");

                entity.Property(e => e.Clavesol)
                    .HasMaxLength(20)
                    .HasColumnName("clavesol");

                entity.Property(e => e.Correo)
                    .HasMaxLength(200)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccionran)
                    .HasMaxLength(300)
                    .HasColumnName("direccionran");

                entity.Property(e => e.Nombrerancho)
                    .HasMaxLength(300)
                    .HasColumnName("nombrerancho");

                entity.Property(e => e.NroRuc)
                    .HasMaxLength(20)
                    .HasColumnName("nroRuc");

                entity.Property(e => e.Obs)
                    .HasMaxLength(300)
                    .HasColumnName("obs");

                entity.Property(e => e.Usuariosol)
                    .HasMaxLength(20)
                    .HasColumnName("usuariosol");
            });

            modelBuilder.Entity<NotaCredito>(entity =>
            {
                entity.HasKey(e => e.IdCre)
                    .HasName("PK_notaCred");

                entity.ToTable("NotaCredito");

                entity.Property(e => e.IdCre)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cre");

                entity.Property(e => e.CdrSunatNotaCre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CdrSunat_NotaCre");

                entity.Property(e => e.EstadoCr)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cr");

                entity.Property(e => e.EstadoDinero)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Emision");

                entity.Property(e => e.HashCpeNotaCre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("HashCpe_NotaCre");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Doc");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.IgvC).HasColumnName("Igv_C");

                entity.Property(e => e.MotivoEmis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Motivo_Emis");

                entity.Property(e => e.NcEnviadoSunat)
                    .HasMaxLength(15)
                    .HasColumnName("NC_Enviado_Sunat");

                entity.Property(e => e.OtrosDatos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SonCre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotalC).HasColumnName("SubTotal_C");

                entity.Property(e => e.Tipocomprobnte)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VlrTotal).HasColumnName("Vlr_Total");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.NotaCreditos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_cliNC");

                entity.HasOne(d => d.IdDocNavigation)
                    .WithMany(p => p.NotaCreditos)
                    .HasForeignKey(d => d.IdDoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_nota_doc");

                entity.HasOne(d => d.IdUsuNavigation)
                    .WithMany(p => p.NotaCreditos)
                    .HasForeignKey(d => d.IdUsu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_notac_Usuario");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPed)
                    .HasName("PK__Pedido__76CD552B916C5C0D");

                entity.ToTable("Pedido");

                entity.Property(e => e.IdPed)
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_ped");

                entity.Property(e => e.FechaPed)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Ped");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(15)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.SubtotalGravado).HasColumnName("subtotal_Gravado");

                entity.Property(e => e.TotalGravado).HasColumnName("totalGravado");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ped_cli");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdPro)
                    .HasName("PK__Producto__51E35AC99BBD3AF9");

                entity.Property(e => e.IdPro)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.EstadoPro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Pro");

                entity.Property(e => e.FechaCreaProServ)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Foto)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("Id_Cat");

                entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.PreCompra).HasColumnName("Pre_Compra$");

                entity.Property(e => e.PreCompraS).HasColumnName("Pre_CompraS");

                entity.Property(e => e.PreVntadolar).HasColumnName("Pre_Vntadolar");

                entity.Property(e => e.PreVntaxMayor).HasColumnName("Pre_vntaxMayor");

                entity.Property(e => e.PreVntaxMenor).HasColumnName("Pre_vntaxMenor");

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.TipoProdcto)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UndMedida)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ValorPorCant).HasColumnName("Valor_porCant");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.Idprovee)
                    .HasName("PK__Proveedo__A24D5EEA4797950D");

                entity.ToTable("Proveedor");

                entity.Property(e => e.Idprovee)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTO");

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.EstadoProvdr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO_PROVDR");

                entity.Property(e => e.FotoLogo)
                    .IsRequired()
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("FOTO_LOGO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Rubro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RUBRO");

                entity.Property(e => e.Ruc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("RUC")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__55932E869878D29A");

                entity.Property(e => e.IdRol)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Rol");

                entity.Property(e => e.Rol).HasMaxLength(50);
            });

            modelBuilder.Entity<Temporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temporal");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.CodTem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("codTem");

                entity.Property(e => e.CodigoQr).HasColumnName("CodigoQR");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HashCpe)
                    .HasMaxLength(100)
                    .HasColumnName("hash_cpe");

                entity.Property(e => e.IgvT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoEmis)
                    .HasMaxLength(100)
                    .HasColumnName("motivoEmis");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SonT)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTtal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(50)
                    .HasColumnName("tipoComprobante");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .HasColumnName("tipoPago");

                entity.Property(e => e.TotalT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDoc>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipo_Doc__064163922DB9A596");

                entity.ToTable("Tipo_Doc");

                entity.Property(e => e.IdTipo)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Tipo");

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.EstadoTiDoc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_TiDoc");

                entity.Property(e => e.Numero).HasMaxLength(6);

                entity.Property(e => e.Serie).HasMaxLength(4);
            });

            modelBuilder.Entity<Ubigeo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ubigeo");

                entity.Property(e => e.Departamento).HasMaxLength(150);

                entity.Property(e => e.Distrito).HasMaxLength(150);

                entity.Property(e => e.IdUbigeo)
                    .HasMaxLength(6)
                    .HasColumnName("idUbigeo");

                entity.Property(e => e.Provincia).HasMaxLength(150);
            });

            modelBuilder.Entity<Usuarios2>(entity =>
            {
                entity.HasKey(e => e.IdUsu)
                    .HasName("PK__Usuarios__52A331EBE58A50DC");

                entity.ToTable("Usuarios2");

                entity.HasIndex(e => e.Usuario, "UQ__Usuarios__E3237CF7917B0BC0")
                    .IsUnique();

                entity.Property(e => e.IdUsu)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Contraseña).IsRequired();

                entity.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoUsu)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Usu");

                entity.Property(e => e.FechaNcmiento)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Ncmiento");

                entity.Property(e => e.IdDis).HasColumnName("Id_Dis");

                entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("salt");

                entity.Property(e => e.UbicacionFoto)
                    .IsRequired()
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Ubicacion_Foto");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<VCajaUsuario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Caja_Usuario");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Concepto).HasMaxLength(190);

                entity.Property(e => e.DePara)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("De_Para");

                entity.Property(e => e.EstadoCaja)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaja)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Caja");

                entity.Property(e => e.GeneradoPor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NroDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nro_Doc")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoCaja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Caja");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VCierreCajaUsu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_cierreCaja_usu");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AperturaCaja).HasColumnName("Apertura_Caja");

                entity.Property(e => e.EstadoCierre)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_cierre");

                entity.Property(e => e.FechaCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Cierre");

                entity.Property(e => e.IdCierre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_cierre");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalIngreso).HasColumnName("Total_Ingreso");
            });

            modelBuilder.Entity<VClientesDistrito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Clientes_Distritos");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Distrito).HasMaxLength(50);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EMail)
                    .HasMaxLength(150)
                    .HasColumnName("e_mail");

                entity.Property(e => e.EstadoCli)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_cli");

                entity.Property(e => e.FchaNcmntoAnivsrio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fcha_Ncmnto_Anivsrio");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Id_Cliente")
                    .IsFixedLength(true);

                entity.Property(e => e.IdDis).HasColumnName("Id_Dis");

                entity.Property(e => e.LimitCredit).HasColumnName("Limit_Credit");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VDocumentoCredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Documento_Credito");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCred)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cred");

                entity.Property(e => e.EstadoDoc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Doc");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaCredito)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Credito");

                entity.Property(e => e.FechaEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Emi");

                entity.Property(e => e.FechaVncimnto)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Vncimnto");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Id_Cliente")
                    .IsFixedLength(true);

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("id_Doc")
                    .IsFixedLength(true);

                entity.Property(e => e.IdNotaCred)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("id_Ped")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.LimitCredit).HasColumnName("Limit_Credit");

                entity.Property(e => e.NomCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Cliente");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.SaldoPdnte).HasColumnName("Saldo_Pdnte");

                entity.Property(e => e.TotalCre).HasColumnName("Total_Cre");
            });

            modelBuilder.Entity<VDocumentoCreditoPrint2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Documento_Credito_Print2");

                entity.Property(e => e.ACuenta).HasColumnName("A_cuenta");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCred)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cred");

                entity.Property(e => e.EstadoDoc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Doc");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaCredito)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Credito");

                entity.Property(e => e.FechaEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Emi");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Pago");

                entity.Property(e => e.FechaVncimnto)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Vncimnto");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Id_Cliente")
                    .IsFixedLength(true);

                entity.Property(e => e.IdDetCred).HasColumnName("Id_DetCred");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("id_Doc")
                    .IsFixedLength(true);

                entity.Property(e => e.IdNotaCred)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("id_Ped")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.LimitCredit).HasColumnName("Limit_Credit");

                entity.Property(e => e.NomCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Cliente");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.SaldoActual).HasColumnName("Saldo_Actual");

                entity.Property(e => e.SaldoPdnte).HasColumnName("Saldo_Pdnte");

                entity.Property(e => e.TotalCre).HasColumnName("Total_Cre");
            });

            modelBuilder.Entity<VDocumentoCreditoYDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Documento_Credito_yDetalle");

                entity.Property(e => e.ACuenta).HasColumnName("A_cuenta");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCred)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cred");

                entity.Property(e => e.EstadoDoc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Doc");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaCredito)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Credito");

                entity.Property(e => e.FechaEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Emi");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Pago");

                entity.Property(e => e.FechaVncimnto)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Vncimnto");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Doc");

                entity.Property(e => e.IdNotaCred)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.LimitCredit).HasColumnName("Limit_Credit");

                entity.Property(e => e.NomCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Cliente");

                entity.Property(e => e.NroOperaComent)
                    .HasMaxLength(180)
                    .HasColumnName("Nro_Opera_Coment");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.SaldoActual).HasColumnName("saldo_actual");

                entity.Property(e => e.SaldoPdnte).HasColumnName("Saldo_Pdnte");

                entity.Property(e => e.TotalCre).HasColumnName("Total_Cre");
            });

            modelBuilder.Entity<VDocumentosCompraDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Documentos_Compra_Detalle");

                entity.Property(e => e.DatosAdicional)
                    .HasMaxLength(150)
                    .HasColumnName("Datos_Adicional");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.EstadoIngre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Ingre");

                entity.Property(e => e.FechaIngre)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Ingre");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.IdDocComp)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Id_DocComp")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_Pro")
                    .IsFixedLength(true);

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.ModalidadPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NroFacFisico)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NroFac_Fisico")
                    .IsFixedLength(true);

                entity.Property(e => e.PreCompra).HasColumnName("Pre_Compra$");

                entity.Property(e => e.PreCompraS).HasColumnName("Pre_CompraS");

                entity.Property(e => e.Ruc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("RUC")
                    .IsFixedLength(true);

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.SubTotalIngre).HasColumnName("SubTotal_ingre");

                entity.Property(e => e.TipoDocCompra)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TipoDoc_Compra");

                entity.Property(e => e.TotalIngre).HasColumnName("Total_Ingre");
            });

            modelBuilder.Entity<VDocumentosCompraPrincipal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Documentos_CompraPrincipal");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatosAdicional)
                    .HasMaxLength(150)
                    .HasColumnName("Datos_Adicional");

                entity.Property(e => e.EstadoIngre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Ingre");

                entity.Property(e => e.FechaIngre)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Ingre");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.IdDocComp)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Id_DocComp")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.ModalidadPago)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NroFacFisico)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NroFac_Fisico")
                    .IsFixedLength(true);

                entity.Property(e => e.Ruc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("RUC")
                    .IsFixedLength(true);

                entity.Property(e => e.SubTotalIngre).HasColumnName("SubTotal_ingre");

                entity.Property(e => e.TipoDocCompra)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TipoDoc_Compra");

                entity.Property(e => e.TipoIngreso)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Ingreso");

                entity.Property(e => e.TotalIngre).HasColumnName("Total_Ingre");

                entity.Property(e => e.UbicacionFoto)
                    .IsRequired()
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Ubicacion_Foto");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<VIstaNotacreditoGnral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ista_Notacredito_Gnral");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CdrSunatNotaCre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CdrSunat_NotaCre");

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCr)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cr");

                entity.Property(e => e.EstadoDinero)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Emision");

                entity.Property(e => e.HashCpeNotaCre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("HashCpe_NotaCre");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.IdCre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cre");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Doc");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.IgvC).HasColumnName("Igv_C");

                entity.Property(e => e.MotivoEmis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Motivo_Emis");

                entity.Property(e => e.NcEnviadoSunat)
                    .HasMaxLength(15)
                    .HasColumnName("NC_Enviado_Sunat");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtrosDatos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.SonCre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("sonCre");

                entity.Property(e => e.SubTotalC).HasColumnName("SubTotal_C");

                entity.Property(e => e.Tipocomprobnte)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UbicacionFoto)
                    .IsRequired()
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Ubicacion_Foto");

                entity.Property(e => e.VlrTotal).HasColumnName("Vlr_Total");
            });

            modelBuilder.Entity<VKardexDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Kardex_Detalle");

                entity.Property(e => e.CantidadIn).HasColumnName("Cantidad_In");

                entity.Property(e => e.CantidadOut).HasColumnName("Cantidad_Out");

                entity.Property(e => e.CantidadSaldo).HasColumnName("Cantidad_Saldo");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTO");

                entity.Property(e => e.CostoTotalSaldo).HasColumnName("Costo_Total_Saldo");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.DetOperacion)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Det_Operacion");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.DocSoporte)
                    .HasMaxLength(20)
                    .HasColumnName("Doc_Soporte")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoKrdx)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FechaKrdx)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Krdx");

                entity.Property(e => e.IdKrdx)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Id_krdx")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_Pro")
                    .IsFixedLength(true);

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.PrecioIn).HasColumnName("Precio_In");

                entity.Property(e => e.PrecioOut).HasColumnName("Precio_Out");

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength(true);

                entity.Property(e => e.TotalIn).HasColumnName("Total_In");

                entity.Property(e => e.TotalOut).HasColumnName("Total_Out");
            });

            modelBuilder.Entity<VKardexDetalle2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Kardex_Detalle2");

                entity.Property(e => e.CostoEntrada).HasColumnName("costoEntrada");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.DetMovimiento)
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("detMovimiento");

                entity.Property(e => e.DocSoporte)
                    .HasMaxLength(20)
                    .HasColumnName("docSoporte")
                    .IsFixedLength(true);

                entity.Property(e => e.Entrada).HasColumnName("entrada");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_Pro")
                    .IsFixedLength(true);

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.Property(e => e.Salida).HasColumnName("salida");

                entity.Property(e => e.UndMedida)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VKardexDetallePrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Kardex_Detalle_Print");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.Entrada).HasColumnName("entrada");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaIni)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaIni");

                entity.Property(e => e.IdPro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.Property(e => e.Salida).HasColumnName("salida");

                entity.Property(e => e.UndMedida)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VListadoDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Listado_Documento");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CdrSunat)
                    .HasMaxLength(15)
                    .HasColumnName("CDR_Sunat");

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.EstadoBajada).HasMaxLength(15);

                entity.Property(e => e.EstadoDoc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_doc");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaEmi)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Emi");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_Hora");

                entity.Property(e => e.FechaPed)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Ped");

                entity.Property(e => e.HashCpe)
                    .HasMaxLength(50)
                    .HasColumnName("Hash_CPE");

                entity.Property(e => e.HashCpeBaja)
                    .HasMaxLength(55)
                    .HasColumnName("Hash_CPE_Baja");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Doc");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.NombreCompletoUsu)
                    .IsRequired()
                    .HasMaxLength(101);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NroOperacion)
                    .HasMaxLength(20)
                    .HasColumnName("Nro_Operacion")
                    .IsFixedLength(true);

                entity.Property(e => e.NroTicketBaja)
                    .HasMaxLength(50)
                    .HasColumnName("NroTicket_Baja");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.SubtotalGravado).HasColumnName("subtotal_Gravado");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalGravado).HasColumnName("totalGravado");

                entity.Property(e => e.TotalLetra).HasMaxLength(280);
            });

            modelBuilder.Entity<VListadoDocumentoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Listado_Documento_Detalle");

                entity.Property(e => e.AfectoIgv)
                    .HasMaxLength(15)
                    .HasColumnName("AfectoIGV");

                entity.Property(e => e.CdrSunat)
                    .HasMaxLength(15)
                    .HasColumnName("CDR_Sunat");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.EstadoDoc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Estado_doc");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaEmi)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Emi");

                entity.Property(e => e.FechaPed)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Ped");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Doc");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.IdTipo).HasColumnName("Id_Tipo");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(15)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.IgvSubtotal).HasColumnName("Igv_subtotal");

                entity.Property(e => e.ImporteConIgv).HasColumnName("Importe_ConIgv");

                entity.Property(e => e.NroOperacion)
                    .HasMaxLength(20)
                    .HasColumnName("Nro_Operacion")
                    .IsFixedLength(true);

                entity.Property(e => e.PCantOriginal).HasColumnName("P_Cant_Original");

                entity.Property(e => e.PrecioConIgv).HasColumnName("Precio_ConIgv");

                entity.Property(e => e.PrecioSinIgv).HasColumnName("Precio_sinIgv");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.SubtotalSinIgv).HasColumnName("subtotal_sinIgv");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Prod");

                entity.Property(e => e.TotalLetra).HasMaxLength(280);

                entity.Property(e => e.Totalganancia).HasColumnName("totalganancia");

                entity.Property(e => e.UndMedida)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Und_Medida");

                entity.Property(e => e.UtilidadUnit).HasColumnName("Utilidad_Unit");
            });

            modelBuilder.Entity<VListadoNotacredito>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Listado_Notacredito");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CdrSunatNotaCre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CdrSunat_NotaCre");

                entity.Property(e => e.DetalleNotaCredi)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCr)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cr");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Emision");

                entity.Property(e => e.HashCpeNotaCre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("HashCpe_NotaCre");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.IdCre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cre");

                entity.Property(e => e.IdDoc)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Doc");

                entity.Property(e => e.IdPro)
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.IgvC).HasColumnName("Igv_C");

                entity.Property(e => e.MotivoEmis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Motivo_Emis");

                entity.Property(e => e.NcEnviadoSunat)
                    .HasMaxLength(15)
                    .HasColumnName("NC_Enviado_Sunat");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtrosDatos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.SonCre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("sonCre");

                entity.Property(e => e.SubTotalC).HasColumnName("SubTotal_C");

                entity.Property(e => e.TipoProdctonc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tipocomprobnte)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VlrTotal).HasColumnName("Vlr_Total");
            });

            modelBuilder.Entity<VListadoPedidoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Listado_Pedido_Detalle");

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EMail)
                    .HasMaxLength(150)
                    .HasColumnName("E_mail");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaPed)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Ped");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Ped");

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(15)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.ImporteConIgv).HasColumnName("Importe_ConIgv");

                entity.Property(e => e.PrecioConIgv).HasColumnName("Precio_ConIgv");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TipoProd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Prod");

                entity.Property(e => e.UndMedida)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Und_Medida");

                entity.Property(e => e.UtilidadUnit).HasColumnName("Utilidad_Unit");
            });

            modelBuilder.Entity<VPedidosClienteGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Pedidos_Cliente_General");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCli)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Cli");

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaPed)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Ped");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Id_Cliente")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("id_Ped")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");
            });

            modelBuilder.Entity<VProductosYDependiente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Productos_yDependientes");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.EstadoPro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Pro");

                entity.Property(e => e.Foto)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("Id_Cat");

                entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");

                entity.Property(e => e.IdPro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.Idprovee)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("IDPROVEE")
                    .IsFixedLength(true);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.PreCompra).HasColumnName("Pre_Compra$");

                entity.Property(e => e.PreCompraS).HasColumnName("Pre_CompraS");

                entity.Property(e => e.PreVntadolar).HasColumnName("Pre_Vntadolar");

                entity.Property(e => e.PreVntaxMayor).HasColumnName("Pre_vntaxMayor");

                entity.Property(e => e.PreVntaxMenor).HasColumnName("Pre_vntaxMenor");

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoProdcto)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UndMedida)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ValorPorCant).HasColumnName("Valor_porCant");
            });

            modelBuilder.Entity<VTemporalesDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Temporales_Detalle");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(20)
                    .HasColumnName("cantidad")
                    .IsFixedLength(true);

                entity.Property(e => e.Cliente)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.CodPro).HasMaxLength(15);

                entity.Property(e => e.CodTem)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CodigoQr).HasColumnName("codigoQR");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HashCpe)
                    .HasMaxLength(100)
                    .HasColumnName("hash_cpe");

                entity.Property(e => e.IgvT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoEmis)
                    .HasMaxLength(100)
                    .HasColumnName("motivoEmis");

                entity.Property(e => e.PreUnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pre_Unt");

                entity.Property(e => e.Producto)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SonT)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTtal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobante)
                    .HasMaxLength(30)
                    .HasColumnName("tipoComprobante");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .HasColumnName("tipoPago");

                entity.Property(e => e.TotalT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VUsuariosRoles2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Usuarios_Roles2");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Contraseña).IsRequired();

                entity.Property(e => e.EstadoUsu)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Estado_usu");

                entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rol).HasMaxLength(50);

                entity.Property(e => e.UbicacionFoto)
                    .IsRequired()
                    .HasMaxLength(180)
                    .IsUnicode(false)
                    .HasColumnName("Ubicacion_Foto");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VVistaCotizacionPedidoCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Vista_Cotizacion_Pedido_Cliente");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Condiciones)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCoti)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaCoti).HasColumnType("date");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Id_Cliente")
                    .IsFixedLength(true);

                entity.Property(e => e.IdCotiza)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Id_Cotiza")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("id_Ped")
                    .IsFixedLength(true);

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrecioconIgv)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VVistaCotizacionPedidoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Vista_Cotizacion_Pedido_Detalle");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Condiciones)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Descripcion_Larga");

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoCoti)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoPed)
                    .HasMaxLength(12)
                    .HasColumnName("Estado_Ped");

                entity.Property(e => e.FechaCoti).HasColumnType("datetime");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.IdCotiza)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cotiza");

                entity.Property(e => e.IdPed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id_Ped");

                entity.Property(e => e.IdPro)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Pro");

                entity.Property(e => e.IdUsu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Usu");

                entity.Property(e => e.ImporteConIgv).HasColumnName("Importe_ConIgv");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrecioConIgv).HasColumnName("Precio_ConIgv");

                entity.Property(e => e.RazonSocialNombres)
                    .HasMaxLength(250)
                    .HasColumnName("Razon_Social_Nombres");

                entity.Property(e => e.StockActual).HasColumnName("Stock_Actual");

                entity.Property(e => e.TipoProd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Prod");

                entity.Property(e => e.UndMedida)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Und_Medida");

                entity.Property(e => e.UtilidadUnit).HasColumnName("Utilidad_Unit");
            });

            modelBuilder.Entity<ValeCompra>(entity =>
            {
                entity.HasKey(e => e.IdVale)
                    .HasName("PK__ValeComp__A84977C224666F6C");

                entity.ToTable("ValeCompra");

                entity.Property(e => e.IdVale).HasMaxLength(15);

                entity.Property(e => e.DetalleVale)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoVale)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Id_Cliente");

                entity.Property(e => e.NroDoc)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ValeCompras)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_val_cli");
            });

            modelBuilder.Entity<ZzTablaTest>(entity =>
            {
                entity.HasKey(e => e.Titulo);

                entity.ToTable("zz_tablaTest");

                entity.Property(e => e.Titulo).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
