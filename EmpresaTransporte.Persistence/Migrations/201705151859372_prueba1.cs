namespace EmpresaTransporte.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        ventaId = c.Int(nullable: false, identity: true),
                        cliente_dni = c.String(),
                        cliente_nombre = c.String(),
                        cliente_apePaterno = c.String(),
                        cliente_apeMaterno = c.String(),
                        cliente_direccion = c.String(),
                        cliente_telefono = c.String(),
                        administrativo_dni = c.String(),
                        administrativo_nombre = c.String(),
                        administrativo_apePaterno = c.String(),
                        administrativo_apeMaterno = c.String(),
                        administrativo_fechaIngreso = c.String(),
                        tipoComprobante = c.Int(nullable: false),
                        tipoPago = c.Int(nullable: false),
                        fechaRegistro = c.String(),
                        montoTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ventaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ventas");
        }
    }
}
