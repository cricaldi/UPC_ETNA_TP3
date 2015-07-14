using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain.Venta
{
    public class ProductoBE
    {
          
     private Int32 _Id;
	public Int32 Id {
		get { return _Id; }

		set { _Id = value; }
	}


    private Int32 _LineaId;
    public Int32 LineaId
    {
        get { return _LineaId; }

        set { _LineaId = value; }
    }


	private string _CodigoProducto;
	public string CodigoProducto {
		get { return _CodigoProducto; }

		set { _CodigoProducto = value; }
	}

	private string _Nombre;
	public string Nombre {
		get { return _Nombre; }

		set { _Nombre = value; }
	}

	private string _DescripcionCorta;
	public string DescripcionCorta {
		get { return _DescripcionCorta; }

		set { _DescripcionCorta = value; }
	}

	private string _DescripcionLarga;
	public string DescripcionLarga {
		get { return _DescripcionLarga; }

		set { _DescripcionLarga = value; }
	}

	private string _Unidad;
	public string Unidad {
		get { return _Unidad; }

		set { _Unidad = value; }
	}

	private double _PrecioListaCompra;
	public double PrecioListaCompra {
		get { return _PrecioListaCompra; }

		set { _PrecioListaCompra = value; }
	}

	private double _PrecioListaVenta;
	public double PrecioListaVenta {
		get { return _PrecioListaVenta; }

		set { _PrecioListaVenta = value; }
	}

	private Int32 _Estado;
	public Int32 Estado {
		get { return _Estado; }

		set { _Estado = value; }
	}
    
    }
}
