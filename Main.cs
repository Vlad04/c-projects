using System; 

/*Mariana Enriquez program -Carwash- 'Intro a la programacion'*/
class Program
{
static double dinero_usuario=0;
static double color_precio_detallado_express=400;
static double precio_reparacion_defensa=1000;
static double precio_reparacion_rines=700;
static double costo_aplicacion_carbono=980;
static int result = 0;

//Main method
static void Main(string[] args)
    {

        //Menu options
        while(result!=7){
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("Bienvenido al lavado de autos");
        Console.WriteLine();
        Console.WriteLine("Su cantidad de dinero actual es de: "+dinero_usuario);
        
        Console.WriteLine("Por favor escoga una opcion");
        Console.WriteLine();

        Console.WriteLine("1. Lavado");
        Console.WriteLine("2. Detallado");
        Console.WriteLine("3. Aplicacion de fibra de carbono");
        Console.WriteLine("4. Compra de tarjetas / Recarga de Saldo");
        Console.WriteLine("5. Consulta de saldo");
        Console.WriteLine("6. Cierre de día");
        
        result = int.Parse(Console.ReadLine());     //user interface input-lee el input del usuario y dependiendo de la opcion que quiera
                                                    //se movera a los metodos por medio del switch
        
        switch(result)
        {
                
                case 1:  
                    Console.WriteLine("Lavado");  
                    Lavado();                       //Llama al metodo lavado()
                    break;  
                case 2:  
                    Console.WriteLine("Detallado");
                    Detallado();                    //Llama al metodo Detallado()
                    break;  
                case 3:  
                    Console.WriteLine("Aplicacion de fibra de carono"); 
                    Aplicacion_carbono();           //Llama al metodo Aplicacion_carbono()
                    break;  
                case 4:  
                    Compra_tarjetas();              //Llama al metodo Compra_tarjetas
                    Console.WriteLine("Compra de tarjetas");  
                    break;  
                case 5:  
                    Console.WriteLine("Consulta de saldo");         //DEBE llamar al metodo consulta de saldo
                    /***CAUTION -FALTA IMPLEMENTAR EL METODO***/
                    break; 
                case 6:  
                    Auth_Password();                //Llama al metodo Auth_Password

                    break;  
                
        
        } 
        
        }

    }
    
//Metodo Lavado
static public int Lavado()
{
    
    Console.WriteLine("¿Cual es el tamaño de su vehiculo?");
    Console.WriteLine();
    Console.WriteLine("1. Compacto");
    Console.WriteLine("2. Sedan");
    Console.WriteLine("3. SUV");
    int vehiculo=int.Parse(Console.ReadLine());  
    switch(vehiculo)
    {
        //Cada caso llama al metodo Lavado_opciones()
        case 1:
            Console.WriteLine("Usted escogio Compacto");
            Lavado_opciones();
            break;
        case 2:
            Console.WriteLine("Usted escogio Sedan");
            Lavado_opciones();
            break;
        case 3:
            Console.WriteLine("Usted escogio SUV");
            Lavado_opciones();
            break;

    }
    return 0;
}
    //Metodo Opciones de lavado
    static public int Lavado_opciones()
    {
    Console.WriteLine("¿Que servicio desea?");
    Console.WriteLine();
    Console.WriteLine("1. Lavado completo");
    Console.WriteLine("2. Lavado de tolvas");
    Console.WriteLine("3. Abrillantado de vidrio");
    Console.WriteLine("4. Detallado General");
    Console.WriteLine("5. Paquete completo");
    int option=int.Parse(Console.ReadLine()); 
    //En el caso de que el usuario no cuente con el dinero de 100 puntos (minimo necesario para pagar el servicio mas barato
    //No se le permitira su compra, en caso contrario se realizara la compra dependiendo del servicio
    if(dinero_usuario<=100)
    {
        Console.WriteLine("Usted no cuenta con dinero suficiente.");
    }
    else
    {
    switch(option)
    {
        case 1:
            //Console.WriteLine("Gusta escoger otro servicio?");
            //int otro_servicio=int.Parse(Console.ReadLine());  
            Console.WriteLine("El precio de su servicio sera de: $100");   
            dinero_usuario=dinero_usuario-100;

            //Console.WriteLine("Lavado completo");
            //dinero_usuario=20;
             break;
        case 2:
             //Console.WriteLine("Gusta escoger otro servicio?");
             //otro_servicio=int.Parse(Console.ReadLine());
             Console.WriteLine("El precio de su servicio sera de: $200");   
             dinero_usuario=dinero_usuario-200;
            //Console.WriteLine("Lavado completo");
             break;
        case 3:
             //Console.WriteLine("Gusta escoger otro servicio?"); 
             //otro_servicio=int.Parse(Console.ReadLine());
             Console.WriteLine("El precio de su servicio sera de: $300");   
             dinero_usuario=dinero_usuario-300;
            //Console.WriteLine("Lavado completo");
             break;
        case 4:
             //Console.WriteLine("Gusta escoger otro servicio?");
             //otro_servicio=int.Parse(Console.ReadLine());
             Console.WriteLine("El precio de su servicio sera de: $400");   
             dinero_usuario=dinero_usuario-400;
            //Console.WriteLine("Lavado completo");
             break;
        case 5:
             
             dinero_usuario=dinero_usuario-900;
             Console.WriteLine("El precio de su servicio sera de: $900");   
            //Console.WriteLine("Lavado completo");
             break;
    }
    }
    
    return 0;
    }
//Metodo de Detallado
static public int Detallado()
{
    Console.WriteLine("¿Que color desea?");
    Console.WriteLine();
    Console.WriteLine("1. Rojo");
    Console.WriteLine("2. Negro");
    Console.WriteLine("3. Azul");
    Console.WriteLine("4. Blanco");
    Console.WriteLine("5. Morado");
    Console.WriteLine("6. Naranja");
   //El precio de los servicios de Detallado estan fijos en variables globales arriba, cada uno depende del color que escoge
   //Si escoge Rojo o Negro se aumentara el costo en un 15%
   
   //Si el usuario no cuenta con 400 puntos que es lo minimo para poder pagar el mas barato de los servicios no le permitira realizar 
   //la compra, de caso contrario realiza la compra del servicio deacuerdo al color y a la opcion de Detallado.
    int color_option=int.Parse(Console.ReadLine()); 
    if(dinero_usuario<400)
    {
        Console.WriteLine("Usted no cuenta con saldo suficiente");
        
    }
    else{ 
        switch(color_option)
        {
            case 1:
                color_precio_detallado_express=(color_precio_detallado_express*.15)+color_precio_detallado_express; //precio del servicio-15%
                precio_reparacion_defensa=(precio_reparacion_defensa*.15)+precio_reparacion_defensa;    //precio del servicio-15%
                precio_reparacion_rines=(precio_reparacion_rines*.15)+precio_reparacion_rines;  //precio del servicio-15%
                Detallado_opciones();

                //Console.WriteLine("Lavado completo");
                //dinero_usuario=20;
                 break;
            case 2:
                color_precio_detallado_express=(color_precio_detallado_express*.15)+color_precio_detallado_express; //precio del servicio-15%
                precio_reparacion_defensa=(precio_reparacion_defensa*.15)+precio_reparacion_defensa;    //precio del servicio-15%
                precio_reparacion_rines=(precio_reparacion_rines*.15)+precio_reparacion_rines;  //precio del servicio-15%
                Detallado_opciones();
                
                //Console.WriteLine("Lavado completo");
                 break;
            case 3:
                color_precio_detallado_express=400; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_defensa=1000; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_rines=700; //precio del servicio fijo para que no se sobrescriba
                Detallado_opciones();
                //Console.WriteLine("Lavado completo");
                //dinero_usuario=20;
                 break;
            case 4:
                color_precio_detallado_express=400; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_defensa=1000; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_rines=700; //precio del servicio fijo para que no se sobrescriba
                Detallado_opciones();
                //Console.WriteLine("Lavado completo");
                 break;
            case 5:
                color_precio_detallado_express=400; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_defensa=1000; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_rines=700; //precio del servicio fijo para que no se sobrescriba
                Detallado_opciones();
                //Console.WriteLine("Lavado completo");
                //dinero_usuario=20;
                 break;
            case 6:
                color_precio_detallado_express=400; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_defensa=1000; //precio del servicio fijo para que no se sobrescriba
                precio_reparacion_rines=700; //precio del servicio fijo para que no se sobrescriba
                Detallado_opciones();
                //Console.WriteLine("Lavado completo");
                 break;
            
                 
        }
    }
    
return 0;
}
    //Metodo opciones de Detallado
    static public int Detallado_opciones()
    {

    Console.WriteLine("¿Que servicio desea?");
    Console.WriteLine();
    Console.WriteLine("1. Detallado express         $"+color_precio_detallado_express); //
    Console.WriteLine("2. Reparado de defensa       $"+precio_reparacion_defensa);      //texto del servicio + precio del servicio
    Console.WriteLine("3. Reparacion de rines       $"+precio_reparacion_rines);        //
    int service_option=int.Parse(Console.ReadLine());
    switch(service_option)
    {
        case 1:
            dinero_usuario=dinero_usuario-color_precio_detallado_express;       //cobra el monto gastado
            Console.WriteLine("Gracias por su compra");
            break;
        case 2:
            dinero_usuario=dinero_usuario-precio_reparacion_defensa;       //cobra el monto gastado
            Console.WriteLine("Gracias por su compra");
            break;
        case 3:
            dinero_usuario=dinero_usuario-precio_reparacion_rines;       //cobra el monto gastado
            Console.WriteLine("Gracias por su compra");
            break;
    }
          
    return 0;
    }

//Metodo de Aplicacion de fibra de carbono
static public int Aplicacion_carbono()
{
//Pregunta por la domension de la pieza a aplicar el servicio y dependiendo de la medida se cobrara el servicio
Console.WriteLine("¿De que dimension es la pieza? -medida en centimetros cuadrados");
double dimension=double.Parse(Console.ReadLine());
if(dinero_usuario<=980)
    {
        Console.WriteLine("Usted no cuenta con saldo suficiente");
        
    }
else{
    if(dimension>50){
        costo_aplicacion_carbono=costo_aplicacion_carbono-(costo_aplicacion_carbono*.05);
        Console.WriteLine("El precio de su servicio sera de: "+costo_aplicacion_carbono);  
        Console.WriteLine();
        dinero_usuario=dinero_usuario-costo_aplicacion_carbono;
        Console.WriteLine("Gracias por su compra");
        
     
    }
    else if(dimension>100)
    {
        costo_aplicacion_carbono=costo_aplicacion_carbono-(costo_aplicacion_carbono*.10);
        dinero_usuario=dinero_usuario-costo_aplicacion_carbono;
        Console.WriteLine("Gracias por su compra");
    }
    else if(dimension>150)
    {
        costo_aplicacion_carbono=costo_aplicacion_carbono-(costo_aplicacion_carbono*.15);
        Console.WriteLine("El precio de su servicio sera de: "+costo_aplicacion_carbono);  
        Console.WriteLine();
        dinero_usuario=dinero_usuario-costo_aplicacion_carbono;
        Console.WriteLine("Gracias por su compra");
    }
    else if(dimension<=0)
    {
        Console.WriteLine("Por favor introduzca una dimension valida mayor a 0");
         
        Console.WriteLine();
        return Aplicacion_carbono();
        Console.WriteLine();
    }
    else{
        Console.WriteLine("El precio de su servicio sera de: "+costo_aplicacion_carbono);  
        Console.WriteLine();
        dinero_usuario=dinero_usuario-costo_aplicacion_carbono;
    }
}
return 0;
}
//Metodo de compra de tarjetas
static public int Compra_tarjetas()
{

    Console.WriteLine("Por favor ingrese la cantidad que desee recargar a su saldo");
    //Si el usuario tiene 0 en su cuenta se deduce que no tiene tarjeta, por lo que le da 200 puntos de cortesia
    if(dinero_usuario==0.0)
    {
        dinero_usuario=200;
    }
    //De tener algo de dinero se deduce que si tiene una tarjeta y se le recarga lo que indique el usuario mayor a 150 puntos
    
    int cantidad_recargo=int.Parse(Console.ReadLine());
    if(cantidad_recargo<150)
    {
    Console.WriteLine("La minima cantidad de recargo es de 150.");
    Console.WriteLine("Recarga no autorizada");
    Console.WriteLine();
    }
    else
    {
        //De la manera que la tarjeta cuesta 25 se le quita 25 de su cuenta despues de recargarle lo que pide
    dinero_usuario=(dinero_usuario+cantidad_recargo);
    Console.WriteLine("El costo de la tarjeta es de $25, se le abonaron 200 puntos por ser la primera vez que compro la tarjeta.");

    dinero_usuario=dinero_usuario-25;
    }

return 0;
}
//Mtodo de consulta de saldo
static public int Consulta_saldo()
{
return 0;
}

static public int Auth_Password()
{
    //Se establece un password de tipo string que es quiero100
    //lee el input del usuario, si el input es igual al password ya mencionado, le permite salir del programa
    //De otra manera sigue corriendo el programa
    string password="quiero100";
    Console.WriteLine("Favor de ingresar la contraseña para salir");

    string input_password=Console.ReadLine();
    if(input_password==password){
        Console.WriteLine("Pase un buen dia");  
        Console.WriteLine();  
        result=7;
    }
    else{
        Console.WriteLine("Contraseña incorrecta");
    }
    
return 0;
}

}



