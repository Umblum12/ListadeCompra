int opcion = 0;

//crear la lista donde meteremos los productos
List<string> listaproductos = new List<string>();
while (opcion != 4)
{
    Console.Clear();//limpiamos la lista

    Console.WriteLine("Programa de lista de compras");
    Console.WriteLine("---By: Abelardo ---");
    Console.WriteLine();

    //Creando el menu de opociones que contendra el programa
    Console.WriteLine("Menu de opciones: ");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Ver producto");
    Console.WriteLine("3. Eliminar producto");
    Console.WriteLine("4. Salir de la aplicacion");

    opcion = Convert.ToInt32(Console.ReadLine());

    //empezamos a leer las opciones seleccionadas
    if (opcion == 1)
    {
        //configurando la opcion para agregar porducto
        Console.Clear();//limpiamos la lista
        Console.WriteLine("---Agregar producto---");
        Console.WriteLine();

        Console.WriteLine("Introduzca el producto que agregará: ");
        string producto = Console.ReadLine();
        listaproductos.Add(producto); //agregar el producto a la listaproductos de productos
        Console.WriteLine("Producto agregado.presione cualquier tecla para continuar");
        Console.ReadKey(true);
    }
    else if (opcion == 2)
    {
        Console.Clear();//limpiamos la lista
        Console.WriteLine("--- Ver Producto ---");
        Console.WriteLine();

        foreach (string produc in listaproductos)
        {
            Console.WriteLine(produc);
        }
        Console.ReadKey(true);
    }
    else if (opcion == 3)//Eliminar producto
    {
        Console.Clear();//limpiamos la lista
        Console.WriteLine("--- Eliminar Producto ---");
        Console.WriteLine();
        Console.WriteLine("Introduzca el producto que desea eliminar: ");

        foreach (string produc in listaproductos)//crear una variable para buscar los productos
        {
            Console.WriteLine($"{listaproductos.IndexOf(produc) + 1}.{produc}");//se le agrega mas 1 para que lo considere como 1 no cero
        }
        int producAeliminar = Convert.ToInt32(Console.ReadLine());

        if (producAeliminar > 0 && producAeliminar <= listaproductos.Count)
        {
            listaproductos.RemoveAt(producAeliminar - 1);
            Console.WriteLine("El producto se ha eliminado");
        }
        else
        {
            Console.WriteLine("El producto no existe");//Verificar su funcionamiento
        }
    }
    else if (opcion == 4)
    {
        Console.WriteLine("Usted ha cerrando la aplicación");
        Console.ReadKey(true);
    }
}

