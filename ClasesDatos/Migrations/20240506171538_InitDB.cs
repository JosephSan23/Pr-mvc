using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesDatos.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restablecerContraseña = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    idMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    restablecerContraseña = table.Column<bool>(type: "bit", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    totalCompra = table.Column<int>(type: "int", nullable: false),
                    montoTotal = table.Column<float>(type: "real", nullable: false),
                    contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.idVenta);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oMarcaidMarca = table.Column<int>(type: "int", nullable: false),
                    oCategoriaidCategoria = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<float>(type: "real", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    rutaImagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreImagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_oCategoriaidCategoria",
                        column: x => x.oCategoriaidCategoria,
                        principalTable: "Categoria",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_oMarcaidMarca",
                        column: x => x.oMarcaidMarca,
                        principalTable: "Marca",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrito",
                columns: table => new
                {
                    idCarrito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oClienteidCliente = table.Column<int>(type: "int", nullable: false),
                    oProductoidProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrito", x => x.idCarrito);
                    table.ForeignKey(
                        name: "FK_Carrito_Cliente_oClienteidCliente",
                        column: x => x.oClienteidCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carrito_Producto_oProductoidProducto",
                        column: x => x.oProductoidProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    idDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idVenta = table.Column<int>(type: "int", nullable: false),
                    oProductoidProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<float>(type: "real", nullable: false),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VentaidVenta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.idDetalleVenta);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Producto_oProductoidProducto",
                        column: x => x.oProductoidProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Venta_VentaidVenta",
                        column: x => x.VentaidVenta,
                        principalTable: "Venta",
                        principalColumn: "idVenta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_oClienteidCliente",
                table: "Carrito",
                column: "oClienteidCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_oProductoidProducto",
                table: "Carrito",
                column: "oProductoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_oProductoidProducto",
                table: "DetalleVenta",
                column: "oProductoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_VentaidVenta",
                table: "DetalleVenta",
                column: "VentaidVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_oCategoriaidCategoria",
                table: "Producto",
                column: "oCategoriaidCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_oMarcaidMarca",
                table: "Producto",
                column: "oMarcaidMarca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrito");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
