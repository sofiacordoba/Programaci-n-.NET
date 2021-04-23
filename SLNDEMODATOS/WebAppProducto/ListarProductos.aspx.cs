using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibDatosProducto.Models;
using LibDatosProducto.Repositorios;

namespace WebAppProducto
{
    public partial class ListarProductos : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridProducto.DataSource = AdminProducto.listar();
                gridProducto.DataBind();

                cbColor.Items.Add("[TODOS]");

                foreach (var item in AdminUtilitarios.traerColor())
                {
                    cbColor.Items.Add(item);
                }
            }

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto() { Nombre = "Teclado", Color = "Negro", Precio = 850 };

            int resultado = AdminProducto.agregar(producto);

            Producto producto1 = new Producto() { Nombre = "Auriculares", Color = "Rojo", Precio = 750 };

            int resultado1 = AdminProducto.agregar(producto1);

            Producto producto2 = new Producto() { Nombre = "Mouse", Color = "Azul", Precio = 1300 };

            int resultado2 = AdminProducto.agregar(producto2);
        
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto() { Id = 1, Nombre = "Teclado Inalambrico", Color = "Negro", Precio = 850.5m };

            int resultado = AdminProducto.modificar(producto);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = AdminProducto.eliminar(3);
        }

        protected void btnInsertarCategoria_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria() { Nombre = "Hardware", Descripcion = "Componentes para armar una PC" };
            int resultado = AdminCategoria.agregar(nueva);
            Categoria nueva2 = new Categoria() { Nombre = "Software", Descripcion = "Solo programas de Diseño" };
            int resultado2 = AdminCategoria.agregar(nueva2);
            Categoria nueva3 = new Categoria() { Nombre = "Software", Descripcion = "Solo programas de Ofimática" };
            int resultado3 = AdminCategoria.agregar(nueva3);
        }

        protected void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria { Id = 2, Nombre = "Software", Descripcion = " programas de Diseño y de Ofimática" };
            int resultado = AdminCategoria.modificar(categoria);
        }

        protected void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            int resultado = AdminCategoria.eliminar(3);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnTraerColor_Click(object sender, EventArgs e)
        {
            string color = txtColor.Text;

            gridProducto.DataSource = AdminProducto.listar(color);
            gridProducto.DataBind();
        }

        protected void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = cbColor.SelectedItem.ToString();

            if (color == "[TODOS]")
            {
                MostrarTodosProductos();
            }
            else
            {
                gridProducto.DataSource = AdminProducto.listar(color);
                gridProducto.DataBind();
            }
        }
        private void MostrarTodosProductos()
        {
            gridProducto.DataSource = AdminProducto.listar();
            gridProducto.DataBind();

        }
    }
}