using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class dbtwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "modulomaestro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreModulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulomaestro", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "permisogenerico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePermiso = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permisogenerico", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRol = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "submodulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreSubModulo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submodulos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rolvsmaestro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    IdModuloMaestroFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolvsmaestro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rolvsmaestro_modulomaestro_IdModuloMaestroFk",
                        column: x => x.IdModuloMaestroFk,
                        principalTable: "modulomaestro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rolvsmaestro_rol_IdRolFk",
                        column: x => x.IdRolFk,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "maestrovssubmodulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdModuloMaestroFk = table.Column<int>(type: "int", nullable: false),
                    IdSubmoduloFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maestrovssubmodulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_maestrovssubmodulo_modulomaestro_IdModuloMaestroFk",
                        column: x => x.IdModuloMaestroFk,
                        principalTable: "modulomaestro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_maestrovssubmodulo_submodulos_IdSubmoduloFk",
                        column: x => x.IdSubmoduloFk,
                        principalTable: "submodulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genericovssubmodulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPermisoGenericoFk = table.Column<int>(type: "int", nullable: false),
                    IdMaestroSubModulosFk = table.Column<int>(type: "int", nullable: false),
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genericovssubmodulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_genericovssubmodulo_maestrovssubmodulo_IdMaestroSubModulosFk",
                        column: x => x.IdMaestroSubModulosFk,
                        principalTable: "maestrovssubmodulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_genericovssubmodulo_permisogenerico_IdPermisoGenericoFk",
                        column: x => x.IdPermisoGenericoFk,
                        principalTable: "permisogenerico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_genericovssubmodulo_rol_IdRolFk",
                        column: x => x.IdRolFk,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_genericovssubmodulo_IdMaestroSubModulosFk",
                table: "genericovssubmodulo",
                column: "IdMaestroSubModulosFk");

            migrationBuilder.CreateIndex(
                name: "IX_genericovssubmodulo_IdPermisoGenericoFk",
                table: "genericovssubmodulo",
                column: "IdPermisoGenericoFk");

            migrationBuilder.CreateIndex(
                name: "IX_genericovssubmodulo_IdRolFk",
                table: "genericovssubmodulo",
                column: "IdRolFk");

            migrationBuilder.CreateIndex(
                name: "IX_maestrovssubmodulo_IdModuloMaestroFk",
                table: "maestrovssubmodulo",
                column: "IdModuloMaestroFk");

            migrationBuilder.CreateIndex(
                name: "IX_maestrovssubmodulo_IdSubmoduloFk",
                table: "maestrovssubmodulo",
                column: "IdSubmoduloFk");

            migrationBuilder.CreateIndex(
                name: "IX_rolvsmaestro_IdModuloMaestroFk",
                table: "rolvsmaestro",
                column: "IdModuloMaestroFk");

            migrationBuilder.CreateIndex(
                name: "IX_rolvsmaestro_IdRolFk",
                table: "rolvsmaestro",
                column: "IdRolFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "genericovssubmodulo");

            migrationBuilder.DropTable(
                name: "rolvsmaestro");

            migrationBuilder.DropTable(
                name: "maestrovssubmodulo");

            migrationBuilder.DropTable(
                name: "permisogenerico");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "modulomaestro");

            migrationBuilder.DropTable(
                name: "submodulos");
        }
    }
}
