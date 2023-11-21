¤
qC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Contratos\IServicioCorreo.cs
	namespace 	
	Contratos
 
{ 
[ 
ServiceContract 
] 
public 

	interface 
IServicioCorreo $
{ 
[ 	
OperationContract	 
] 
bool		 #
ExisteCorreoElectronico		 $
(		$ %
string		% +
correoElectronico		, =
)		= >
;		> ?
[ 	
OperationContract	 
] 
bool 
EnviarMensajeCorreo  
(  !
string! '

encabezado( 2
,2 3
string4 :
correoDestino; H
,H I
string 
asunto 
, 
string !
mensaje" )
)) *
;* +
} 
} ê
rC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Contratos\IServicioPartida.cs
	namespace 	
	Contratos
 
{ 
[ 
ServiceContract 
( 
CallbackContract %
=& '
typeof( .
(. /$
IServicioPartidaCallback/ G
)G H
)H I
]I J
public 

	interface 
IServicioPartida %
{ 
[		 	
OperationContract			 
]		 
bool

 
CrearNuevaPartida

 
(

 
string

 %

codigoSala

& 0
)

0 1
;

1 2
[ 	
OperationContract	 
] 
bool 
IniciarPartida 
( 
string "

codigoSala# -
)- .
;. /
[ 	
OperationContract	 
] 
bool 
FinalizarPartida 
( 
string $

codigoSala% /
,/ 0
CuentaJugador 
cuentaJugador '
,' (
bool) -
	esGanador. 7
)7 8
;8 9
[ 	
OperationContract	 
] 
bool 
GenerarTablero 
( 
string "

codigoSala# -
)- .
;. /
[ 	
OperationContract	 
] 
void 
MoverPiezaPosicionX  
(  !
double! '
	posicionX( 1
)1 2
;2 3
[ 	
OperationContract	 
] 
void 
MoverPiezaPosicionY  
(  !
bool! %
	posicionY& /
)/ 0
;0 1
[ 	
OperationContract	 
] 
bool %
NotificarJugadorPreparado &
(& '
string' -

codigoSala. 8
,8 9
string 
nombreJugador  
)  !
;! "
[   	
OperationContract  	 
]   
bool!! "
ExpulsarJugadorPartida!! #
(!!# $
string!!$ *

codigoSala!!+ 5
,!!5 6
string"" 
nombreJugador""  
)""  !
;""! "
[$$ 	
OperationContract$$	 
]$$ 
int%% (
ObtenerNumeroPartidasJugadas%% (
(%%( )
string%%) /
nombreJugador%%0 =
)%%= >
;%%> ?
['' 	
OperationContract''	 
]'' 
int(( (
ObtenerNumeroPartidasGanadas(( (
(((( )
string(() /
nombreJugador((0 =
)((= >
;((> ?
})) 
[++ 
ServiceContract++ 
]++ 
public,, 

	interface,, $
IServicioPartidaCallback,, -
{-- 
[.. 	
OperationContract..	 
(.. 
IsOneWay.. #
=..$ %
true..& *
)..* +
]..+ ,
void// *
ActualizarNuevaPosicionDePieza// +
(//+ ,
double//, 2
	posicionX//3 <
,//< =
double//> D
	posicionY//E N
)//N O
;//O P
}00 
}11 ³&
tC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Contratos\IServicioAmistades.cs
	namespace 	
	Contratos
 
{ 
[ 
ServiceContract 
( 
CallbackContract %
=& '
typeof( .
(. /&
IServicioAmistadesCallback/ I
)I J
)J K
]K L
public 

	interface 
IServicioAmistades '
{		 
[

 	
OperationContract

	 
]

 
List 
< 
CuentaJugador 
> 1
%ObtenerJugadoresConSolicitudPendiente A
(A B
stringB H
nombreJugadorI V
)V W
;W X
[ 	
OperationContract	 
] 
List 
< 
CuentaJugador 
> "
ObtenerAmigosDeJugador 2
(2 3
string3 9
nombreJugador: G
)G H
;H I
[ 	
OperationContract	 
] 
bool $
EnviarSolicitudDeAmistad %
(% &
string& ,
nombreJugadorOrigen- @
,@ A
stringB H 
nombreJugadorDestinoI ]
)] ^
;^ _
[ 	
OperationContract	 
] 
bool %
AceptarSolicitudDeAmistad &
(& '
string' -
nombreJugadorOrigen. A
,A B
stringC I 
nombreJugadorDestinoJ ^
)^ _
;_ `
[ 	
OperationContract	 
] 
bool &
RechazarSolicitudDeAmistad '
(' (
string( .
nombreJugadorOrigen/ B
,B C
stringD J 
nombreJugadorDestinoK _
)_ `
;` a
[ 	
OperationContract	 
] 
bool $
ExisteSolicitudDeAmistad %
(% &
string& ,
nombreJugadorOrigen- @
,@ A
string  
nombreJugadorDestino '
)' (
;( )
[ 	
OperationContract	 
] 
bool #
ExisteAmistadConJugador $
($ %
string% +
nombreJugadorA, :
,: ;
string< B
nombreJugadorBC Q
)Q R
;R S
[   	
OperationContract  	 
]   
bool!! )
EliminarAmistadEntreJugadores!! *
(!!* +
string!!+ 1
nombreJugadorA!!2 @
,!!@ A
string!!B H
nombreJugadorB!!I W
)!!W X
;!!X Y
[## 	
OperationContract##	 
]## 
bool$$ 4
(SuscribirJugadorANotificacionesAmistades$$ 5
($$5 6
string$$6 <
nombreJugador$$= J
)$$J K
;$$K L
[&& 	
OperationContract&&	 
]&& 
bool'' 7
+DesuscribirJugadorDeNotificacionesAmistades'' 8
(''8 9
string''9 ?
nombreJugador''@ M
)''M N
;''N O
[)) 	
OperationContract))	 
])) 
bool** 7
+EsJugadorSuscritoANotififacionesDeAmistades** 8
(**8 9
string**9 ?
nombreJugador**@ M
)**M N
;**N O
}++ 
[-- 
ServiceContract-- 
]-- 
public.. 

	interface.. &
IServicioAmistadesCallback.. /
{// 
[00 	
OperationContract00	 
(00 
IsOneWay00 #
=00$ %
true00& *
)00* +
]00+ ,
void11 ,
 NotificarSolicitudAmistadEnviada11 -
(11- .
CuentaJugador11. ; 
cuentaNuevaSolicitud11< P
)11P Q
;11Q R
[33 	
OperationContract33	 
(33 
IsOneWay33 #
=33$ %
true33& *
)33* +
]33+ ,
void44 -
!NotificarSolicitudAmistadAceptada44 .
(44. /
CuentaJugador44/ <
cuentaNuevoAmigo44= M
)44M N
;44N O
[66 	
OperationContract66	 
(66 
IsOneWay66 #
=66$ %
true66& *
)66* +
]66+ ,
void77 %
NotificarAmistadEliminada77 &
(77& '
string77' -"
nombreAmigoEliminacion77. D
)77D E
;77E F
[99 	
OperationContract99	 
(99 
IsOneWay99 #
=99$ %
true99& *
)99* +
]99+ ,
void:: 0
$NotificarEstadoConectividadDeJugador:: 1
(::1 2
string::2 8
nombreJugador::9 F
,::F G%
EstadoConectividadJugador;; %
estado;;& ,
);;, -
;;;- .
}<< 
}== ‹
rC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Contratos\IServicioJugador.cs
	namespace 	
	Contratos
 
{ 
[ 
ServiceContract 
] 
public 

	interface 
IServicioJugador %
{ 
[		 	
OperationContract			 
]		 
bool

 
	Registrar

 
(

 
CuentaJugador

 $
cuentaJugador

% 2
)

2 3
;

3 4
[ 	
OperationContract	 
] 
bool 
ExisteNombreJugador  
(  !
string! '
nombreJugador( 5
)5 6
;6 7
[ 	
OperationContract	 
] 
CuentaJugador 
IniciarSesion #
(# $
string$ *
nombreJugador+ 8
,8 9
string: @

contrasenaA K
)K L
;L M
[ 	
OperationContract	 
] 
bool 
CerrarSesion 
( 
string  
nombreUsuario! .
). /
;/ 0
[ 	
OperationContract	 
] 
bool !
ActualizarInformacion "
(" #
string# )
nombreAnterior* 8
,8 9
string: @
nuevoNombreA L
,L M
int 
nuevoNumeroAvatar !
)! "
;" #
[ 	
OperationContract	 
] 
bool  
ActualizarContrasena !
(! "
string" (
correo) /
,/ 0
string1 7

contrasena8 B
)B C
;C D
} 
} Ý
oC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Contratos\IServicioSala.cs
	namespace 	
	Contratos
 
{ 
[ 
ServiceContract 
( 
CallbackContract %
=& '
typeof( .
(. /"
IServicioJuegoCallback/ E
)E F
)F G
]G H
public 

	interface 
IServicioSala "
{		 
[

 	
OperationContract

	 
]

 
bool 
CrearNuevaSala 
( 
string "
nombreAnfitrion# 2
,2 3
string4 :

codigoSala; E
)E F
;F G
[ 	
OperationContract	 
] 
void &
ConectarCuentaJugadorASala '
(' (
string( .
nombreJugador/ <
,< =
string> D

codigoSalaE O
,O P
string 
mensajeBienvenida $
)$ %
;% &
[ 	
OperationContract	 
] 
void *
DesconectarCuentaJugadorDeSala +
(+ ,
string, 2
nombreJugador3 @
,@ A
stringB H

codigoSalaI S
,S T
string 
mensajeDespedida #
)# $
;$ %
[ 	
OperationContract	 
] 
List 
< 
CuentaJugador 
> ,
 ObtenerJugadoresConectadosEnSala <
(< =
string= C

codigoSalaD N
)N O
;O P
[ 	
OperationContract	 
( 
IsOneWay #
=$ %
true& *
)* +
]+ ,
void 
EnviarMensajeDeSala  
(  !
string! '
nombreJugador( 5
,5 6
string7 =

codigoSala> H
,H I
stringJ P
mensajeQ X
)X Y
;Y Z
[ 	
OperationContract	 
] 
string &
GenerarCodigoParaNuevaSala )
() *
)* +
;+ ,
[ 	
OperationContract	 
] 
bool  
ExisteSalaDisponible !
(! "
string" (

codigoSala) 3
)3 4
;4 5
}   
["" 
ServiceContract"" 
]"" 
public## 

	interface## "
IServicioJuegoCallback## +
{$$ 
[%% 	
OperationContract%%	 
(%% 
IsOneWay%% #
=%%$ %
true%%& *
)%%* +
]%%+ ,
void&&  
MostrarMensajeDeSala&& !
(&&! "
string&&" (
mensaje&&) 0
)&&0 1
;&&1 2
[(( 	
OperationContract((	 
((( 
IsOneWay(( #
=(($ %
true((& *
)((* +
]((+ ,
void)) 0
$NotificarNuevoJugadorConectadoEnSala)) 1
())1 2
CuentaJugador))2 ?
nuevoJugador))@ L
)))L M
;))M N
[++ 	
OperationContract++	 
(++ 
IsOneWay++ #
=++$ %
true++& *
)++* +
]+++ ,
void,, .
"NotificarJugadorDesconectadoDeSala,, /
(,,/ 0
string,,0 6
nombreJugador,,7 D
),,D E
;,,E F
}-- 
}.. ¤
yC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Contratos\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str $
)$ %
]% &
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str &
)& '
]' (
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *