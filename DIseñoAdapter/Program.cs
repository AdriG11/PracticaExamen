using DIseñoAdapter;

ILectorDatos lectorOriginal = new LectorDatos();

Cliente cliente1  = new Cliente(lectorOriginal);
cliente1.RealizarOperacionLectura();

StreamReader streamReader = new StreamReader("archivo.txt");
ILectorDatos adaptadorStreamReader = new AdaptadorStrreamReader(streamReader);

Cliente cliente2 = new Cliente(adaptadorStreamReader);
cliente2.RealizarOperacionLectura();
