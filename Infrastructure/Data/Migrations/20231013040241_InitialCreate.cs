using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "auditoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auditoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estadonotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEstado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadonotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreFormato = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formato", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hilorespuestanotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hilorespuestanotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "radicado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_radicado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tiponotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiponotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tiporequerimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiporequerimiento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "blockchain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdTipoNotificacion = table.Column<int>(type: "int", nullable: false),
                    IdHiloRespuestaNotificacion = table.Column<int>(type: "int", nullable: false),
                    IdAuditoria = table.Column<int>(type: "int", nullable: false),
                    HashGenerado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blockchain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blockchain_auditoria_IdAuditoria",
                        column: x => x.IdAuditoria,
                        principalTable: "auditoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blockchain_hilorespuestanotificacion_IdHiloRespuestaNotifica~",
                        column: x => x.IdHiloRespuestaNotificacion,
                        principalTable: "hilorespuestanotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blockchain_tiponotificacion_IdTipoNotificacion",
                        column: x => x.IdTipoNotificacion,
                        principalTable: "tiponotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "modulonotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AsuntoNotificacion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdtpRequerimientoFk = table.Column<int>(type: "int", nullable: false),
                    IdRadicadoFk = table.Column<int>(type: "int", nullable: false),
                    IdEstadoNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    IdHiloNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    IdFormatoFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    TextoNotificacion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulonotificacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_modulonotificacion_estadonotificacion_IdEstadoNotificacionFk",
                        column: x => x.IdEstadoNotificacionFk,
                        principalTable: "estadonotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modulonotificacion_formato_IdFormatoFk",
                        column: x => x.IdFormatoFk,
                        principalTable: "formato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modulonotificacion_hilorespuestanotificacion_IdHiloNotificac~",
                        column: x => x.IdHiloNotificacionFk,
                        principalTable: "hilorespuestanotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modulonotificacion_radicado_IdRadicadoFk",
                        column: x => x.IdRadicadoFk,
                        principalTable: "radicado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modulonotificacion_tiponotificacion_IdTipoNotificacionFk",
                        column: x => x.IdTipoNotificacionFk,
                        principalTable: "tiponotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modulonotificacion_tiporequerimiento_IdtpRequerimientoFk",
                        column: x => x.IdtpRequerimientoFk,
                        principalTable: "tiporequerimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_blockchain_IdAuditoria",
                table: "blockchain",
                column: "IdAuditoria");

            migrationBuilder.CreateIndex(
                name: "IX_blockchain_IdHiloRespuestaNotificacion",
                table: "blockchain",
                column: "IdHiloRespuestaNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_blockchain_IdTipoNotificacion",
                table: "blockchain",
                column: "IdTipoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_modulonotificacion_IdEstadoNotificacionFk",
                table: "modulonotificacion",
                column: "IdEstadoNotificacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_modulonotificacion_IdFormatoFk",
                table: "modulonotificacion",
                column: "IdFormatoFk");

            migrationBuilder.CreateIndex(
                name: "IX_modulonotificacion_IdHiloNotificacionFk",
                table: "modulonotificacion",
                column: "IdHiloNotificacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_modulonotificacion_IdRadicadoFk",
                table: "modulonotificacion",
                column: "IdRadicadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_modulonotificacion_IdTipoNotificacionFk",
                table: "modulonotificacion",
                column: "IdTipoNotificacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_modulonotificacion_IdtpRequerimientoFk",
                table: "modulonotificacion",
                column: "IdtpRequerimientoFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blockchain");

            migrationBuilder.DropTable(
                name: "modulonotificacion");

            migrationBuilder.DropTable(
                name: "auditoria");

            migrationBuilder.DropTable(
                name: "estadonotificacion");

            migrationBuilder.DropTable(
                name: "formato");

            migrationBuilder.DropTable(
                name: "hilorespuestanotificacion");

            migrationBuilder.DropTable(
                name: "radicado");

            migrationBuilder.DropTable(
                name: "tiponotificacion");

            migrationBuilder.DropTable(
                name: "tiporequerimiento");
        }
    }
}
