�
oC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Servicios\Properties\AssemblyInfo.cs
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
]$$) *�
oC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Servicios\ServicioRompecabezasFei.cs
	namespace		 	
	Servicios		
 
{

 
[ 
ServiceBehavior 
( 
ConcurrencyMode $
=% &
ConcurrencyMode' 6
.6 7
Multiple7 ?
,? @
InstanceContextMode 
= 
InstanceContextMode 1
.1 2
Single2 8
)8 9
]9 :
public 

partial 
class #
ServicioRompecabezasFei 0
:1 2
IServicioJugador3 C
{ 
public 
bool 
	Registrar 
( 
CuentaJugador +
cuentaJugador, 9
)9 :
{ 	
Registro 
registro 
= 
new  #
Registro$ ,
(, -
)- .
;. /
bool 
	resultado 
= 
false "
;" #
try 
{ 
	resultado 
= 
registro $
.$ %
	Registrar% .
(. /
cuentaJugador/ <
)< =
;= >
} 
catch 
( 
EntityException "
)" #
{ 
} 
return 
	resultado 
; 
} 	
public!! 
bool!! !
ActualizarInformacion!! )
(!!) *
string!!* 0
nombreAnterior!!1 ?
,!!? @
string"" 
nuevoNombre"" 
,"" 
int""  #
nuevoNumeroAvatar""$ 5
)""5 6
{## 	
Registro$$ 
registro$$ 
=$$ 
new$$  #
Registro$$$ ,
($$, -
)$$- .
;$$. /
bool%% 
	resultado%% 
=%% 
false%% "
;%%" #
try'' 
{(( 
	resultado)) 
=)) 
registro)) $
.))$ %!
ActualizarInformacion))% :
()): ;
nombreAnterior)); I
,))I J
nuevoNombre** 
,**  
nuevoNumeroAvatar**! 2
)**2 3
;**3 4
}++ 
catch,, 
(,, 
EntityException,, "
),," #
{-- 
}// 
return11 
	resultado11 
;11 
}22 	
public44 
bool44  
ActualizarContrasena44 (
(44( )
string44) /
correo440 6
,446 7
string448 >

contrasena44? I
)44I J
{55 	
Registro66 
registro66 
=66 
new66  #
Registro66$ ,
(66, -
)66- .
;66. /
bool77 
	resultado77 
=77 
false77 "
;77" #
try99 
{:: 
	resultado;; 
=;; 
registro;; $
.;;$ % 
ActualizarContrasena;;% 9
(;;9 :
correo;;: @
,;;@ A

contrasena;;B L
);;L M
;;;M N
}<< 
catch== 
(== 
EntityException== "
)==" #
{>> 
}@@ 
returnBB 
	resultadoBB 
;BB 
}CC 	
publicEE 
boolEE 
ExisteNombreJugadorEE '
(EE' (
stringEE( .
nombreJugadorEE/ <
)EE< =
{FF 	
ConsultasJugadorGG 
consultasJugadorGG -
=GG. /
newGG0 3
ConsultasJugadorGG4 D
(GGD E
)GGE F
;GGF G
boolHH 
	resultadoHH 
=HH 
falseHH "
;HH" #
tryJJ 
{KK 
	resultadoLL 
=LL 
consultasJugadorLL ,
.LL, -
ExisteNombreJugadorLL- @
(LL@ A
nombreJugadorLLA N
)LLN O
;LLO P
}MM 
catchNN 
(NN 
EntityExceptionNN "
)NN" #
{OO 
}QQ 
returnSS 
	resultadoSS 
;SS 
}TT 	
publicVV 
CuentaJugadorVV 
IniciarSesionVV *
(VV* +
stringVV+ 1
nombreJugadorVV2 ?
,VV? @
stringVVA G

contrasenaVVH R
)VVR S
{WW 	
CuentaJugadorXX 
cuentaRecuperadaXX *
=XX+ ,
nullXX- 1
;XX1 2
ifZZ 
(ZZ 
ExisteNombreJugadorZZ #
(ZZ# $
nombreJugadorZZ$ 1
)ZZ1 2
&&ZZ3 5
![[ 
jugadoresConectados[[ $
.[[$ %
ContainsKey[[% 0
([[0 1
nombreJugador[[1 >
)[[> ?
)[[? @
{\\ 
try]] 
{^^ 
Autenticacion__ !
autenticacion__" /
=__0 1
new__2 5
Autenticacion__6 C
(__C D
)__D E
;__E F
cuentaRecuperada`` $
=``% &
autenticacion``' 4
.``4 5
IniciarSesion``5 B
(``B C
nombreJugador``C P
,``P Q

contrasena``R \
)``\ ]
;``] ^
ifbb 
(bb 
cuentaRecuperadabb (
!=bb) +
nullbb, 0
)bb0 1
{cc 
cuentaRecuperadadd (
.dd( )
EstadoConectividaddd) ;
=dd< =%
EstadoConectividadJugadordd> W
.ddW X
	ConectadoddX a
;dda b
cuentaRecuperadaee (
.ee( )
OperacionesContextoee) <
=ee= >
newee? B
GestionContextoeeC R
(eeR S
)eeS T
;eeT U
CuentaJugadorff %
cuentaAutenticadaff& 7
=ff8 9
newff: =
CuentaJugadorff> K
{gg 
	IdJugadorhh %
=hh& '
cuentaRecuperadahh( 8
.hh8 9
	IdJugadorhh9 B
,hhB C
NombreJugadorii )
=ii* +
cuentaRecuperadaii, <
.ii< =
NombreJugadorii= J
,iiJ K
NumeroAvatarjj (
=jj) *
cuentaRecuperadajj+ ;
.jj; <
NumeroAvatarjj< H
,jjH I
EstadoConectividadkk .
=kk/ 0
cuentaRecuperadakk1 A
.kkA B
EstadoConectividadkkB T
,kkT U
OperacionesContextoll /
=ll0 1
cuentaRecuperadall2 B
.llB C
OperacionesContextollC V
,llV W
}mm 
;mm 
jugadoresConectadosnn +
[nn+ ,
cuentaRecuperadann, <
.nn< =
NombreJugadornn= J
]nnJ K
=nnL M
cuentaAutenticadannN _
;nn_ `3
'NotificarConexionJugadorAOtrosJugadoresoo ?
(oo? @
cuentaRecuperadaoo@ P
.ooP Q
NombreJugadorooQ ^
,oo^ _
cuentaRecuperadapp ,
.pp, -
EstadoConectividadpp- ?
)pp? @
;pp@ A
}qq 
}rr 
catchss 
(ss 
EntityExceptionss &
)ss& '
{tt 
}vv 
}ww 
returnyy 
cuentaRecuperadayy #
;yy# $
}zz 	
public|| 
bool|| 
CerrarSesion||  
(||  !
string||! '
nombreJugador||( 5
)||5 6
{}} 	
bool~~ 
	resultado~~ 
=~~ 
false~~ "
;~~" #
if
�� 
(
�� !
jugadoresConectados
�� #
.
��# $
ContainsKey
��$ /
(
��/ 0
nombreJugador
��0 =
)
��= >
)
��> ?
{
�� 
	resultado
�� 
=
�� !
jugadoresConectados
�� /
.
��/ 0
Remove
��0 6
(
��6 7
nombreJugador
��7 D
)
��D E
;
��E F5
'NotificarConexionJugadorAOtrosJugadores
�� ;
(
��; <
nombreJugador
�� !
,
��! "'
EstadoConectividadJugador
��# <
.
��< =
Desconectado
��= I
)
��I J
;
��J K
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
}
�� 
public
�� 

partial
�� 
class
�� %
ServicioRompecabezasFei
�� 0
:
��1 2
IServicioCorreo
��3 B
{
�� 
public
�� 
bool
�� %
ExisteCorreoElectronico
�� +
(
��+ ,
string
��, 2
correoElectronico
��3 D
)
��D E
{
�� 	
ConsultasJugador
�� 
consultasJugador
�� -
=
��. /
new
��0 3
ConsultasJugador
��4 D
(
��D E
)
��E F
;
��F G
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
consultasJugador
�� ,
.
��, -%
ExisteCorreoElectronico
��- D
(
��D E
correoElectronico
��E V
)
��V W
;
��W X
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� !
EnviarMensajeCorreo
�� '
(
��' (
string
��( .

encabezado
��/ 9
,
��9 :
string
��; A
correoDestino
��B O
,
��O P
string
�� 
asunto
�� 
,
�� 
string
�� !
mensaje
��" )
)
��) *
{
�� 	%
GeneradorMensajesCorreo
�� #%
generadorMensajesCorreo
��$ ;
=
��< =
new
��> A%
GeneradorMensajesCorreo
��B Y
(
��Y Z
)
��Z [
;
��[ \
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� %
generadorMensajesCorreo
�� 3
.
��3 4
EnviarMensaje
��4 A
(
��A B

encabezado
�� 
,
�� 
correoDestino
��  -
,
��- .
asunto
��/ 5
,
��5 6
mensaje
��7 >
)
��> ?
;
��? @
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
}
�� 
public
�� 

partial
�� 
class
�� %
ServicioRompecabezasFei
�� 0
:
��1 2
IServicioSala
��3 @
{
�� 
private
�� 
readonly
�� 
List
�� 
<
�� 
Sala
�� "
>
��" #
salasActivas
��$ 0
=
��1 2
new
��3 6
List
��7 ;
<
��; <
Sala
��< @
>
��@ A
(
��A B
)
��B C
;
��C D
public
�� 
bool
�� 
CrearNuevaSala
�� "
(
��" #
string
��# )
nombreAnfitrion
��* 9
,
��9 :
string
��; A

codigoSala
��B L
)
��L M
{
�� 	
GestionSala
�� 
gestionSala
�� #
=
��$ %
new
��& )
GestionSala
��* 5
(
��5 6
)
��6 7
;
��7 8
bool
�� #
registroSalaRealizado
�� &
=
��' (
false
��) .
;
��. /
try
�� 
{
�� #
registroSalaRealizado
�� %
=
��& '
gestionSala
��( 3
.
��3 4
CrearNuevaSala
��4 B
(
��B C
nombreAnfitrion
�� #
,
��# $

codigoSala
��% /
)
��/ 0
;
��0 1
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
if
�� 
(
�� #
registroSalaRealizado
�� %
)
��% &
{
�� 
Sala
�� 
salaConectada
�� "
=
��# $
new
��% (
Sala
��) -
(
��- .
)
��. /
{
�� 

CodigoSala
�� 
=
��  

codigoSala
��! +
,
��+ ,
NombreAnfitrion
�� #
=
��$ %
nombreAnfitrion
��& 5
,
��5 6'
ContadorJugadoresActuales
�� -
=
��. /
$num
��0 1
,
��1 2
	Jugadores
�� 
=
�� 
new
��  #
List
��$ (
<
��( )
CuentaJugador
��) 6
>
��6 7
(
��7 8
)
��8 9
}
�� 
;
�� 
salasActivas
�� 
.
�� 
Add
��  
(
��  !
salaConectada
��! .
)
��. /
;
��/ 0
}
�� 
return
�� #
registroSalaRealizado
�� (
;
��( )
}
�� 	
public
�� 
bool
�� "
ExisteSalaDisponible
�� (
(
��( )
string
��) /

codigoSala
��0 :
)
��: ;
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
Sala
�� 
salaEncontrada
�� 
=
��  !
salasActivas
��" .
.
��. /
First
��/ 4
(
��4 5
sala
�� 
=>
�� 
sala
�� 
.
�� 

CodigoSala
�� '
.
��' (
Equals
��( .
(
��. /

codigoSala
��/ 9
)
��9 :
)
��: ;
;
��; <
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� %
(
��% &
salaEncontrada
��& 4
.
��4 5

CodigoSala
��5 ?
)
��? @
&&
��A C
salaEncontrada
�� 
.
�� !
ExisteCupoJugadores
�� 2
(
��2 3
)
��3 4
)
��4 5
{
�� 
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
void
�� (
ConectarCuentaJugadorASala
�� .
(
��. /
string
��/ 5
nombreJugador
��6 C
,
��C D
string
��E K

codigoSala
��L V
,
��V W
string
�� 
mensajeBienvenida
�� $
)
��$ %
{
�� 	
if
�� 
(
�� !
jugadoresConectados
�� #
.
��# $
ContainsKey
��$ /
(
��/ 0
nombreJugador
��0 =
)
��= >
)
��> ?
{
�� !
jugadoresConectados
�� #
[
��# $
nombreJugador
��$ 1
]
��1 2
.
��2 3!
OperacionesContexto
��3 F
.
��F G#
ContextoIServicioSala
�� )
=
��* +
OperationContext
��, <
.
��< =
Current
��= D
;
��D E
Sala
�� 
salaEncontrada
�� #
=
��$ %
salasActivas
��& 2
.
��2 3
First
��3 8
(
��8 9
sala
��9 =
=>
��> @
sala
�� 
.
�� 

CodigoSala
�� #
.
��# $
Equals
��$ *
(
��* +

codigoSala
��+ 5
)
��5 6
)
��6 7
;
��7 8
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� )
(
��) *
salaEncontrada
��* 8
.
��8 9

CodigoSala
��9 C
)
��C D
&&
��E G
salaEncontrada
�� "
.
��" #!
ExisteCupoJugadores
��# 6
(
��6 7
)
��7 8
)
��8 9
{
�� !
EnviarMensajeDeSala
�� '
(
��' (
nombreJugador
��( 5
,
��5 6

codigoSala
��7 A
,
��A B
mensajeBienvenida
��C T
)
��T U
;
��U V1
#NotificarNuevoJugadorConectadoASala
�� 7
(
��7 8!
jugadoresConectados
�� +
[
��+ ,
nombreJugador
��, 9
]
��9 :
,
��: ;

codigoSala
��< F
)
��F G
;
��G H
}
�� 
salaEncontrada
�� 
.
�� 
	Jugadores
�� (
.
��( )
Add
��) ,
(
��, -!
jugadoresConectados
��- @
[
��@ A
nombreJugador
��A N
]
��N O
)
��O P
;
��P Q
salaEncontrada
�� 
.
�� '
ContadorJugadoresActuales
�� 8
++
��8 :
;
��: ;
}
�� 
}
�� 	
public
�� 
void
�� ,
DesconectarCuentaJugadorDeSala
�� 2
(
��2 3
string
��3 9
nombreJugador
��: G
,
��G H
string
�� 

codigoSala
�� 
,
�� 
string
�� %
mensajeDespedida
��& 6
)
��6 7
{
�� 	
CuentaJugador
�� %
cuentaJugadorEncontrada
�� 1
=
��2 3
null
��4 8
;
��8 9
Sala
�� 
salaEncontrada
�� 
=
��  !
salasActivas
��" .
.
��. /
First
��/ 4
(
��4 5
sala
��5 9
=>
��: <
sala
�� 
.
�� 

CodigoSala
�� 
.
��  
Equals
��  &
(
��& '

codigoSala
��' 1
)
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� %
(
��% &
salaEncontrada
��& 4
.
��4 5

CodigoSala
��5 ?
)
��? @
)
��@ A
{
�� %
cuentaJugadorEncontrada
�� '
=
��( )
salaEncontrada
��* 8
.
��8 9
	Jugadores
��9 B
.
��B C
First
�� 
(
�� 
cuentaJugador
�� '
=>
��( *
cuentaJugador
�� !
.
��! "
NombreJugador
��" /
==
��0 2
nombreJugador
��3 @
)
��@ A
;
��A B
}
�� 
if
�� 
(
�� %
cuentaJugadorEncontrada
�� '
!=
��' )
null
��* .
&&
��/ 1
!
��2 3
string
��3 9
.
��9 :
IsNullOrEmpty
��: G
(
��G H%
cuentaJugadorEncontrada
�� '
.
��' (
NombreJugador
��( 5
)
��5 6
)
��6 7
{
�� 
if
�� 
(
�� !
jugadoresConectados
�� '
.
��' (
ContainsKey
��( 3
(
��3 4
nombreJugador
��4 A
)
��A B
)
��B C
{
�� !
jugadoresConectados
�� '
[
��' (
nombreJugador
��( 5
]
��5 6
.
��6 7!
OperacionesContexto
��7 J
.
��J K#
ContextoIServicioSala
�� -
=
��. /
null
��0 4
;
��4 5
}
�� 
salaEncontrada
�� 
.
�� 
	Jugadores
�� (
.
��( )
Remove
��) /
(
��/ 0%
cuentaJugadorEncontrada
��0 G
)
��G H
;
��H I
salaEncontrada
�� 
.
�� '
ContadorJugadoresActuales
�� 8
--
��8 :
;
��: ;
if
�� 
(
�� 
salaEncontrada
�� "
.
��" #
	EstaVacia
��# ,
(
��, -
)
��- .
)
��. /
{
�� 
salasActivas
��  
.
��  !
Remove
��! '
(
��' (
salaEncontrada
��( 6
)
��6 7
;
��7 8
}
�� 
else
�� 
{
�� !
EnviarMensajeDeSala
�� '
(
��' (
nombreJugador
��( 5
,
��5 6

codigoSala
��7 A
,
��A B
mensajeDespedida
��C S
)
��S T
;
��T U0
"NotificarJugadorDesconectadoDeSala
�� 6
(
��6 7
nombreJugador
��7 D
,
��D E

codigoSala
��F P
)
��P Q
;
��Q R
}
�� 
}
�� 
}
�� 	
public
�� 
void
�� !
EnviarMensajeDeSala
�� '
(
��' (
string
��( .
nombreJugador
��/ <
,
��< =
string
��> D

codigoSala
��E O
,
��O P
string
�� 
mensaje
�� 
)
�� 
{
�� 	
Sala
�� 
salaEncontrada
�� 
=
��  !
salasActivas
��" .
.
��. /
First
��/ 4
(
��4 5
sala
��5 9
=>
��: <
sala
�� 
.
�� 

CodigoSala
�� 
.
��  
Equals
��  &
(
��& '

codigoSala
��' 1
)
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� %
(
��% &
salaEncontrada
��& 4
.
��4 5

CodigoSala
��5 ?
)
��? @
)
��@ A
{
�� 
foreach
�� 
(
�� 
GestionContexto
�� ((
gestionadorContextoJugador
��) C
in
��D F
salaEncontrada
�� "
.
��" #
	Jugadores
��# ,
.
��, -
Select
��- 3
(
��3 4
cuentaJugador
��4 A
=>
��B D
cuentaJugador
�� !
.
��! "!
OperacionesContexto
��" 5
)
��5 6
)
��6 7
{
�� 
string
�� 

horaActual
�� %
=
��& '
DateTime
��( 0
.
��0 1
Now
��1 4
.
��4 5
ToShortTimeString
��5 F
(
��F G
)
��G H
;
��H I
string
�� 
mensajeFinal
�� '
=
��( )

horaActual
��* 4
+
��5 6
$"
��7 9
$str
��9 :
{
��: ;
nombreJugador
��; H
}
��H I
$str
��I K
{
��K L
mensaje
��L S
}
��S T
"
��T U
;
��U V
if
�� 
(
�� (
gestionadorContextoJugador
�� 2
.
��2 3#
ContextoIServicioSala
��3 H
!=
��I K
null
��L P
)
��P Q
{
�� (
gestionadorContextoJugador
�� 2
.
��2 3#
ContextoIServicioSala
��3 H
.
��H I 
GetCallbackChannel
�� .
<
��. /$
IServicioJuegoCallback
��/ E
>
��E F
(
��F G
)
��G H
.
��H I"
MostrarMensajeDeSala
�� 0
(
��0 1
mensajeFinal
��1 =
)
��= >
;
��> ?
}
�� 
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� 1
#NotificarNuevoJugadorConectadoASala
�� 8
(
��8 9
CuentaJugador
��9 F
nuevoJugador
��G S
,
��S T
string
�� 

codigoSala
�� 
)
�� 
{
�� 	
Sala
�� 
salaEncontrada
�� 
=
��  !
salasActivas
��" .
.
��. /
First
��/ 4
(
��4 5
sala
��5 9
=>
��: <
sala
�� 
.
�� 

CodigoSala
�� 
.
��  
Equals
��  &
(
��& '

codigoSala
��' 1
)
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� %
(
��% &
salaEncontrada
��& 4
.
��4 5

CodigoSala
��5 ?
)
��? @
)
��@ A
{
�� 
foreach
�� 
(
�� 
CuentaJugador
�� &
jugador
��' .
in
��/ 1
salaEncontrada
��2 @
.
��@ A
	Jugadores
��A J
)
��J K
{
�� 
jugador
�� 
.
�� !
OperacionesContexto
�� /
.
��/ 0#
ContextoIServicioSala
��0 E
.
��E F 
GetCallbackChannel
��F X
<
��X Y$
IServicioJuegoCallback
�� .
>
��. /
(
��/ 0
)
��0 1
.
��1 22
$NotificarNuevoJugadorConectadoEnSala
��2 V
(
��V W
nuevoJugador
�� $
)
��$ %
;
��% &
}
�� 
}
�� 
}
�� 	
private
�� 
void
�� 0
"NotificarJugadorDesconectadoDeSala
�� 7
(
��7 8
string
��8 >
nombreJugador
��? L
,
��L M
string
�� 

codigoSala
�� 
)
�� 
{
�� 	
Sala
�� 
salaEncontrada
�� 
=
��  !
salasActivas
��" .
.
��. /
First
��/ 4
(
��4 5
sala
��5 9
=>
��: <
sala
�� 
.
�� 

CodigoSala
�� 
.
��  
Equals
��  &
(
��& '

codigoSala
��' 1
)
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� %
(
��% &
salaEncontrada
��& 4
.
��4 5

CodigoSala
��5 ?
)
��? @
)
��@ A
{
�� 
foreach
�� 
(
�� 
CuentaJugador
�� &
jugador
��' .
in
��/ 1
salaEncontrada
��2 @
.
��@ A
	Jugadores
��A J
)
��J K
{
�� 
jugador
�� 
.
�� !
OperacionesContexto
�� /
.
��/ 0#
ContextoIServicioSala
��0 E
.
��E F 
GetCallbackChannel
��F X
<
��X Y$
IServicioJuegoCallback
�� .
>
��. /
(
��/ 0
)
��0 1
.
��1 20
"NotificarJugadorDesconectadoDeSala
��2 T
(
��T U
nombreJugador
�� %
)
��% &
;
��& '
}
�� 
}
�� 
}
�� 	
public
�� 
string
�� (
GenerarCodigoParaNuevaSala
�� 0
(
��0 1
)
��1 2
{
�� 	
return
�� 
Guid
�� 
.
�� 
NewGuid
�� 
(
��  
)
��  !
.
��! "
ToString
��" *
(
��* +
)
��+ ,
;
��, -
}
�� 	
public
�� 
List
�� 
<
�� 
CuentaJugador
�� !
>
��! ".
 ObtenerJugadoresConectadosEnSala
��# C
(
��C D
string
��D J

codigoSala
��K U
)
��U V
{
�� 	
List
�� 
<
�� 
CuentaJugador
�� 
>
�� 
jugadoresEnSala
��  /
=
��0 1
new
��2 5
List
��6 :
<
��: ;
CuentaJugador
��; H
>
��H I
(
��I J
)
��J K
;
��K L
Sala
�� 
salaEncontrada
�� 
=
��  !
salasActivas
��" .
.
��. /
First
��/ 4
(
��4 5
sala
��5 9
=>
��: <
sala
�� 
.
�� 

CodigoSala
�� 
.
��  
Equals
��  &
(
��& '

codigoSala
��' 1
)
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
IsNullOrEmpty
�� %
(
��% &
salaEncontrada
��& 4
.
��4 5

CodigoSala
��5 ?
)
��? @
)
��@ A
{
�� 
jugadoresEnSala
�� 
=
��  !
salaEncontrada
��" 0
.
��0 1
	Jugadores
��1 :
;
��: ;
}
�� 
return
�� 
jugadoresEnSala
�� "
;
��" #
}
�� 	
}
�� 
public
�� 

partial
�� 
class
�� %
ServicioRompecabezasFei
�� 0
:
��1 2 
IServicioAmistades
��3 E
{
�� 
private
�� 
readonly
�� 

Dictionary
�� #
<
��# $
string
��$ *
,
��* +
CuentaJugador
��, 9
>
��9 :!
jugadoresConectados
��; N
=
��O P
new
�� 

Dictionary
�� 
<
�� 
string
�� !
,
��! "
CuentaJugador
��# 0
>
��0 1
(
��1 2
)
��2 3
;
��3 4
private
�� 
void
�� 5
'NotificarConexionJugadorAOtrosJugadores
�� <
(
��< =
string
��= C
nombreJugador
��D Q
,
��Q R'
EstadoConectividadJugador
�� %
estado
��& ,
)
��, -
{
�� 	
foreach
�� 
(
�� 
CuentaJugador
�� "
cuenta
��# )
in
��* ,!
jugadoresConectados
��- @
.
��@ A
Values
��A G
)
��G H
{
�� 
if
�� 
(
�� %
ExisteAmistadConJugador
�� +
(
��+ ,
nombreJugador
��, 9
,
��9 :
cuenta
��; A
.
��A B
NombreJugador
��B O
)
��O P
&&
��Q S9
+EsJugadorSuscritoANotififacionesDeAmistades
�� ?
(
��? @
cuenta
��@ F
.
��F G
NombreJugador
��G T
)
��T U
)
��U V
{
�� 
cuenta
�� 
.
�� !
OperacionesContexto
�� .
.
��. /(
ContextoIServicioAmistades
��/ I
.
��I J 
GetCallbackChannel
�� *
<
��* +(
IServicioAmistadesCallback
��+ E
>
��E F
(
��F G
)
��G H
.
��H I2
$NotificarEstadoConectividadDeJugador
�� <
(
��< =
nombreJugador
��= J
,
��J K
estado
��L R
)
��R S
;
��S T
}
�� 
}
�� 
}
�� 	
public
�� 
List
�� 
<
�� 
CuentaJugador
�� !
>
��! "$
ObtenerAmigosDeJugador
��# 9
(
��9 :
string
��: @
nombreJugador
��A N
)
��N O
{
�� 	
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
List
�� 
<
�� 
CuentaJugador
�� 
>
�� 
cuentasJugador
��  .
=
��/ 0
null
��1 5
;
��5 6
try
�� 
{
�� 
cuentasJugador
�� 
=
��  
gestionAmistades
��! 1
.
��1 2$
ObtenerAmigosDeJugador
��2 H
(
��H I
nombreJugador
��I V
)
��V W
;
��W X
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
if
�� 
(
�� 
cuentasJugador
�� 
!=
�� !
null
��" &
)
��& '
{
�� 
cuentasJugador
�� 
=
��  8
*AgregarEstadoConectividadACuentasDeJugador
��! K
(
��K L
cuentasJugador
��L Z
)
��Z [
;
��[ \
}
�� 
return
�� 
cuentasJugador
�� !
;
��! "
}
�� 	
private
�� 
List
�� 
<
�� 
CuentaJugador
�� "
>
��" #8
*AgregarEstadoConectividadACuentasDeJugador
��$ N
(
��N O
List
�� 
<
�� 
CuentaJugador
�� 
>
�� 
cuentasJugador
��  .
)
��. /
{
�� 	
List
�� 
<
�� 
CuentaJugador
�� 
>
�� *
cuentasConEstadoConectividad
��  <
=
��= >
new
��? B
List
��C G
<
��G H
CuentaJugador
��H U
>
��U V
(
��V W
)
��W X
;
��X Y
foreach
�� 
(
�� 
CuentaJugador
�� "
cuenta
��# )
in
��* ,
cuentasJugador
��- ;
)
��; <
{
�� 
if
�� 
(
�� !
jugadoresConectados
�� '
.
��' (
ContainsKey
��( 3
(
��3 4
cuenta
��4 :
.
��: ;
NombreJugador
��; H
)
��H I
)
��I J
{
�� 
cuenta
�� 
.
��  
EstadoConectividad
�� -
=
��. /!
jugadoresConectados
��0 C
[
��C D
cuenta
��D J
.
��J K
NombreJugador
��K X
]
��X Y
.
��Y Z 
EstadoConectividad
�� *
;
��* +
}
�� 
else
�� 
{
�� 
cuenta
�� 
.
��  
EstadoConectividad
�� -
=
��. /'
EstadoConectividadJugador
��0 I
.
��I J
Desconectado
��J V
;
��V W
}
�� *
cuentasConEstadoConectividad
�� ,
.
��, -
Add
��- 0
(
��0 1
cuenta
��1 7
)
��7 8
;
��8 9
}
�� 
return
�� *
cuentasConEstadoConectividad
�� /
;
��/ 0
}
�� 	
public
�� 
List
�� 
<
�� 
CuentaJugador
�� !
>
��! "3
%ObtenerJugadoresConSolicitudPendiente
��# H
(
��H I
string
��I O
nombreJugador
��P ]
)
��] ^
{
�� 	
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
List
�� 
<
�� 
CuentaJugador
�� 
>
�� 
cuentasJugador
��  .
=
��/ 0
null
��1 5
;
��5 6
try
�� 
{
�� 
cuentasJugador
�� 
=
��  
gestionAmistades
��! 1
.
��1 23
%ObtenerJugadoresConSolicitudPendiente
�� 9
(
��9 :
nombreJugador
��: G
)
��G H
;
��H I
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
if
�� 
(
�� 
cuentasJugador
�� 
!=
�� !
null
��" &
)
��& '
{
�� 
cuentasJugador
�� 
=
��  8
*AgregarEstadoConectividadACuentasDeJugador
��! K
(
��K L
cuentasJugador
��L Z
)
��Z [
;
��[ \
}
�� 
return
�� 
cuentasJugador
�� !
;
��! "
}
�� 	
public
�� 
bool
�� &
EnviarSolicitudDeAmistad
�� ,
(
��, -
string
��- 3!
nombreJugadorOrigen
��4 G
,
��G H
string
�� "
nombreJugadorDestino
�� '
)
��' (
{
�� 	
bool
��  
esSolicitudEnviada
�� #
=
��$ %
false
��& +
;
��+ ,
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
try
�� 
{
��  
esSolicitudEnviada
�� "
=
��# $
gestionAmistades
��% 5
.
��5 6&
EnviarSolicitudDeAmistad
��6 N
(
��N O!
nombreJugadorOrigen
�� '
,
��' ("
nombreJugadorDestino
��) =
)
��= >
;
��> ?
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
if
�� 
(
��  
esSolicitudEnviada
�� "
&&
��# %9
+EsJugadorSuscritoANotififacionesDeAmistades
��& Q
(
��Q R"
nombreJugadorDestino
�� $
)
��$ %
)
��% &
{
�� !
jugadoresConectados
�� #
[
��# $"
nombreJugadorDestino
��$ 8
]
��8 9
.
��9 :!
OperacionesContexto
��: M
.
��M N(
ContextoIServicioAmistades
�� .
.
��. / 
GetCallbackChannel
��/ A
<
��A B(
IServicioAmistadesCallback
��B \
>
��\ ]
(
��] ^
)
��^ _
.
��_ `.
 NotificarSolicitudAmistadEnviada
�� 4
(
��4 5!
jugadoresConectados
��5 H
[
��H I!
nombreJugadorOrigen
��I \
]
��\ ]
)
��] ^
;
��^ _
}
�� 
return
��  
esSolicitudEnviada
�� %
;
��% &
}
�� 	
public
�� 
bool
�� '
AceptarSolicitudDeAmistad
�� -
(
��- .
string
��. 4!
nombreJugadorOrigen
��5 H
,
��H I
string
�� "
nombreJugadorDestino
�� '
)
��' (
{
�� 	
bool
�� !
esSolicitudAceptada
�� $
=
��% &
false
��' ,
;
��, -
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
try
�� 
{
�� !
esSolicitudAceptada
�� #
=
��$ %
gestionAmistades
��& 6
.
��6 7'
AceptarSolicitudDeAmistad
��7 P
(
��P Q!
nombreJugadorOrigen
�� '
,
��' ("
nombreJugadorDestino
��) =
)
��= >
;
��> ?
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
if
�� 
(
�� !
esSolicitudAceptada
�� #
&&
��$ &9
+EsJugadorSuscritoANotififacionesDeAmistades
��' R
(
��R S!
nombreJugadorOrigen
�� #
)
��# $
)
��$ %
{
�� !
jugadoresConectados
�� #
[
��# $!
nombreJugadorOrigen
��$ 7
]
��7 8
.
��8 9!
OperacionesContexto
��9 L
.
��L M(
ContextoIServicioAmistades
�� .
.
��. / 
GetCallbackChannel
��/ A
<
��A B(
IServicioAmistadesCallback
��B \
>
��\ ]
(
��] ^
)
��^ _
.
��_ `/
!NotificarSolicitudAmistadAceptada
�� 5
(
��5 6!
jugadoresConectados
��6 I
[
��I J"
nombreJugadorDestino
��J ^
]
��^ _
)
��_ `
;
��` a
}
�� 
return
�� !
esSolicitudAceptada
�� &
;
��& '
}
�� 	
public
�� 
bool
�� +
EliminarAmistadEntreJugadores
�� 1
(
��1 2
string
��2 8
nombreJugadorA
��9 G
,
��G H
string
�� 
nombreJugadorB
�� !
)
��! "
{
�� 	
bool
��  
esAmistadEliminada
�� #
=
��$ %
false
��& +
;
��+ ,
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
try
�� 
{
��  
esAmistadEliminada
�� "
=
��# $
gestionAmistades
��% 5
.
��5 6+
EliminarAmistadEntreJugadores
��6 S
(
��S T
nombreJugadorA
�� "
,
��" #
nombreJugadorB
��$ 2
)
��2 3
;
��3 4
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
if
�� 
(
��  
esAmistadEliminada
�� "
&&
��# %9
+EsJugadorSuscritoANotififacionesDeAmistades
��& Q
(
��Q R
nombreJugadorB
�� 
)
�� 
)
��  
{
�� !
jugadoresConectados
�� #
[
��# $
nombreJugadorB
��$ 2
]
��2 3
.
��3 4!
OperacionesContexto
��4 G
.
��G H(
ContextoIServicioAmistades
�� .
.
��. / 
GetCallbackChannel
��/ A
<
��A B(
IServicioAmistadesCallback
��B \
>
��\ ]
(
��] ^
)
��^ _
.
��_ `'
NotificarAmistadEliminada
�� -
(
��- .
nombreJugadorA
��. <
)
��< =
;
��= >
}
�� 
return
��  
esAmistadEliminada
�� %
;
��% &
}
�� 	
public
�� 
bool
�� (
RechazarSolicitudDeAmistad
�� .
(
��. /
string
��/ 5!
nombreJugadorOrigen
��6 I
,
��I J
string
�� "
nombreJugadorDestino
�� '
)
��' (
{
�� 	
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
gestionAmistades
�� ,
.
��, -(
EliminarSolicitudDeAmistad
��- G
(
��G H!
nombreJugadorOrigen
�� '
,
��' ("
nombreJugadorDestino
��) =
)
��= >
;
��> ?
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� &
ExisteSolicitudDeAmistad
�� ,
(
��, -
string
��- 3!
nombreJugadorOrigen
��4 G
,
��G H
string
�� "
nombreJugadorDestino
�� '
)
��' (
{
�� 	
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
gestionAmistades
�� ,
.
��, -&
ExisteSolicitudDeAmistad
��- E
(
��E F!
nombreJugadorOrigen
�� '
,
��' ("
nombreJugadorDestino
��) =
)
��= >
;
��> ?
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� %
ExisteAmistadConJugador
�� +
(
��+ ,
string
��, 2
nombreJugadorA
��3 A
,
��A B
string
��C I
nombreJugadorB
��J X
)
��X Y
{
�� 	
GestionAmistades
�� 
gestionAmistades
�� -
=
��. /
new
��0 3
GestionAmistades
��4 D
(
��D E
)
��E F
;
��F G
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
gestionAmistades
�� ,
.
��, -%
ExisteAmistadConJugador
��- D
(
��D E
nombreJugadorA
�� "
,
��" #
nombreJugadorB
��$ 2
)
��2 3
;
��3 4
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� 6
(SuscribirJugadorANotificacionesAmistades
�� <
(
��< =
string
��= C
nombreJugador
��D Q
)
��Q R
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
if
�� 
(
�� 
!
�� 9
+EsJugadorSuscritoANotififacionesDeAmistades
�� <
(
��< =
nombreJugador
��= J
)
��J K
)
��K L
{
�� !
jugadoresConectados
�� #
[
��# $
nombreJugador
��$ 1
]
��1 2
.
��2 3!
OperacionesContexto
��3 F
.
��F G(
ContextoIServicioAmistades
�� .
=
��/ 0
OperationContext
��1 A
.
��A B
Current
��B I
;
��I J
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� 9
+DesuscribirJugadorDeNotificacionesAmistades
�� ?
(
��? @
string
��@ F
nombreJugador
��G T
)
��T U
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
if
�� 
(
�� 9
+EsJugadorSuscritoANotififacionesDeAmistades
�� ;
(
��; <
nombreJugador
��< I
)
��I J
)
��J K
{
�� !
jugadoresConectados
�� #
[
��# $
nombreJugador
��$ 1
]
��1 2
.
��2 3!
OperacionesContexto
��3 F
.
��F G(
ContextoIServicioAmistades
�� .
=
��/ 0
null
��1 5
;
��5 6
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� 9
+EsJugadorSuscritoANotififacionesDeAmistades
�� ?
(
��? @
string
��@ F
nombreJugador
��G T
)
��T U
{
�� 	
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
if
�� 
(
�� !
jugadoresConectados
�� #
.
��# $
ContainsKey
��$ /
(
��/ 0
nombreJugador
��0 =
)
��= >
&&
��? A!
jugadoresConectados
�� #
[
��# $
nombreJugador
��$ 1
]
��1 2
.
��2 3!
OperacionesContexto
��3 F
.
��F G(
ContextoIServicioAmistades
�� *
!=
��+ -
null
��. 2
)
��2 3
{
�� 
	resultado
�� 
=
�� 
true
��  
;
��  !
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
}
�� 
public
�� 

partial
�� 
class
�� %
ServicioRompecabezasFei
�� 0
:
��1 2
IServicioPartida
��3 C
{
�� 
public
�� 
bool
�� 
CrearNuevaPartida
�� %
(
��% &
string
��& ,

codigoSala
��- 7
)
��7 8
{
�� 	
GestionPartida
�� 
gestionPartida
�� )
=
��* +
new
��, /
GestionPartida
��0 >
(
��> ?
)
��? @
;
��@ A
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
gestionPartida
�� *
.
��* +
CrearNuevaPartida
��+ <
(
��< =

codigoSala
��= G
)
��G H
;
��H I
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� 
FinalizarPartida
�� $
(
��$ %
string
��% +

codigoSala
��, 6
,
��6 7
CuentaJugador
�� 
cuentaJugador
�� '
,
��' (
bool
��) -
	esGanador
��. 7
)
��7 8
{
�� 	
GestionPartida
�� 
gestionPartida
�� )
=
��* +
new
��, /
GestionPartida
��0 >
(
��> ?
)
��? @
;
��@ A
bool
�� 
	resultado
�� 
=
�� 
false
�� "
;
��" #
try
�� 
{
�� 
	resultado
�� 
=
�� 
gestionPartida
�� *
.
��* +
FinalizarPartida
��+ ;
(
��; <

codigoSala
�� 
,
�� 
cuentaJugador
��  -
,
��- .
	esGanador
��/ 8
)
��8 9
;
��9 :
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� 
	resultado
�� 
;
�� 
}
�� 	
public
�� 
bool
�� $
ExpulsarJugadorPartida
�� *
(
��* +
string
��+ 1

codigoSala
��2 <
,
��< =
string
��> D
nombreJugador
��E R
)
��R S
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
public
�� 
bool
�� 
GenerarTablero
�� "
(
��" #
string
��# )

codigoSala
��* 4
)
��4 5
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
public
�� 
bool
�� 
IniciarPartida
�� "
(
��" #
string
��# )

codigoSala
��* 4
)
��4 5
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
public
�� 
void
�� !
MoverPiezaPosicionX
�� '
(
��' (
double
��( .
	posicionX
��/ 8
)
��8 9
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
public
�� 
void
�� !
MoverPiezaPosicionY
�� '
(
��' (
bool
��( ,
	posicionY
��- 6
)
��6 7
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
public
�� 
bool
�� '
NotificarJugadorPreparado
�� -
(
��- .
string
��. 4

codigoSala
��5 ?
,
��? @
string
�� 
nombreJugador
��  
)
��  !
{
�� 	
throw
�� 
new
�� %
NotImplementedException
�� -
(
��- .
)
��. /
;
��/ 0
}
�� 	
public
�� 
int
�� *
ObtenerNumeroPartidasJugadas
�� /
(
��/ 0
string
��0 6
nombreJugador
��7 D
)
��D E
{
�� 	
ConsultasJugador
�� 
consultasJugador
�� -
=
��. /
new
��0 3
ConsultasJugador
��4 D
(
��D E
)
��E F
;
��F G
int
�� #
numeroPartidasJugadas
�� %
=
��& '
$num
��( )
;
��) *
try
�� 
{
�� #
numeroPartidasJugadas
�� %
=
��& '
consultasJugador
��( 8
.
��8 93
%ObtenerNumeroPartidasJugadasDeJugador
�� 9
(
��9 :
nombreJugador
��: G
)
��G H
;
��H I
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� #
numeroPartidasJugadas
�� (
;
��( )
}
�� 	
public
�� 
int
�� *
ObtenerNumeroPartidasGanadas
�� /
(
��/ 0
string
��0 6
nombreJugador
��7 D
)
��D E
{
�� 	
ConsultasJugador
�� 
consultasJugador
�� -
=
��. /
new
��0 3
ConsultasJugador
��4 D
(
��D E
)
��E F
;
��F G
int
�� #
numeroPartidasGanadas
�� %
=
��& '
$num
��( )
;
��) *
try
�� 
{
�� #
numeroPartidasGanadas
�� %
=
��& '
consultasJugador
��( 8
.
��8 9*
ObtenerNumeroPartidasGanadas
�� 0
(
��0 1
nombreJugador
��1 >
)
��> ?
;
��? @
}
�� 
catch
�� 
(
�� 
EntityException
�� "
)
��" #
{
�� 
}
�� 
return
�� #
numeroPartidasGanadas
�� (
;
��( )
}
�� 	
}
�� 
}�� 