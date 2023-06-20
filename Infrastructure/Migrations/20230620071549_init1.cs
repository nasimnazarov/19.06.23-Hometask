using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookeditors",
                table: "Bookeditors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookauthors",
                table: "Bookauthors");

            migrationBuilder.DropColumn(
                name: "PubId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "YtdSales",
                table: "Books",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "PubDate",
                table: "Books",
                newName: "PublishedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Books",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "EditorId",
                table: "Bookeditors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Bookauthors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Authors",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Authors",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Authors",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Authors",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookeditors",
                table: "Bookeditors",
                columns: new[] { "Isbn", "EditorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookauthors",
                table: "Bookauthors",
                columns: new[] { "AuthorId", "Isbn" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookeditors_EditorId",
                table: "Bookeditors",
                column: "EditorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookauthors_Isbn",
                table: "Bookauthors",
                column: "Isbn");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookauthors_Authors_AuthorId",
                table: "Bookauthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookauthors_Books_Isbn",
                table: "Bookauthors",
                column: "Isbn",
                principalTable: "Books",
                principalColumn: "Isbn",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookeditors_Books_Isbn",
                table: "Bookeditors",
                column: "Isbn",
                principalTable: "Books",
                principalColumn: "Isbn",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookeditors_Editors_EditorId",
                table: "Bookeditors",
                column: "EditorId",
                principalTable: "Editors",
                principalColumn: "EditorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PubId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookauthors_Authors_AuthorId",
                table: "Bookauthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookauthors_Books_Isbn",
                table: "Bookauthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookeditors_Books_Isbn",
                table: "Bookeditors");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookeditors_Editors_EditorId",
                table: "Bookeditors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookeditors",
                table: "Bookeditors");

            migrationBuilder.DropIndex(
                name: "IX_Bookeditors_EditorId",
                table: "Bookeditors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookauthors",
                table: "Bookauthors");

            migrationBuilder.DropIndex(
                name: "IX_Bookauthors_Isbn",
                table: "Bookauthors");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Books",
                newName: "YtdSales");

            migrationBuilder.RenameColumn(
                name: "PublishedDate",
                table: "Books",
                newName: "PubDate");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Books",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "PubId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "EditorId",
                table: "Bookeditors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Bookauthors",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Authors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookeditors",
                table: "Bookeditors",
                column: "EditorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookauthors",
                table: "Bookauthors",
                column: "AuthorId");
        }
    }
}
