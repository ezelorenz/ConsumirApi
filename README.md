# ConsumirApi
Consumo de api, por método GET, obteniendo una lista de los títulos.

-Creacion de clase con lo parametros que tiene el Json de la API.
  -ObjetoObtenido
  
-En HomeController:
  - Se modifica la seccion que conecta con la vista Index.
    - Como vamos a utilizar programacion acincrona, tenemos que usar async.
      - Por ende, modificar para que devuelva Task<ActiconResult>
  - Se crea:
    - Objeto httpClient, donde se declara que es una nueva instancia de HttpClient.
    - Este objeto nos va a devolver algo, de manera asincrona, entonces:
      - Se crea variable json_respuesta
    -Este resultado va a ser guardado en una variable (se aclara tuvo que se tuvo que deserializar)
      - Aca entra en juego la clase que creamos anteriormente (ObjetoObtenido)
    -Retornamos la vista con el resultado obtenido.

-En Home.Index:
  -Se crea un bucle, en donde vamos a iterar el Objeto recibido, obteniendo, en este caso, el TITLE, puede ser cualquier otra propiedad del ObjetoObtenido.
  
