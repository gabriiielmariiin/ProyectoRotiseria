using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*La carpeta persistence contiene el código para acceder a los datos. El código de persistencia suele utilizar una base de datos, pero también puede utilizar otros métodos, como archivos o memoria.*/

/* La interfaz IGenericRepository<T> es una interfaz genérica que define un conjunto de métodos
 * para trabajar con entidades de tipo T. La cláusula where T : class indica que el tipo T debe ser una clase.
 * Los métodos definidos por la interfaz IGenericRepository<T> se pueden utilizar para realizar las siguientes
 * Obtener todas las entidades de tipo T.obtener una sola entidad,agregar,actualizar o eliminar
 * Un repositorio genérico puede utilizarse para trabajar con cualquier tipo de entidad que cumpla con la cláusula where T : class.*/


namespace Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task <T> Get (int id);

        Task<IReadOnlyList<T>> GetAll ();/* Este metodo se ultiliza para obtener una lista de todos los elementos de un tipo T.
                                          * El método devuelve un Task, que es una unidad de trabajo asincrónico.
                                          * Esto significa que el método no bloquea el hilo actual mientras se obtienen los elementos.
                                          * El método GetAll() se puede utilizar para obtener datos de una base de datos, un archivo o cualquier otra fuente de datos
                                          * pj podriamos usar el metodo para obtener todos los clientes de una base de datos*/

        Task<bool> Exists (int id);
        Task <T> Add (T Entity);

        Task<T> Update (T Entity);

        Task<T> Delete (T Entity);



    }
}
