›
bC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\Autenticacion.cs
	namespace 	
Logica
 
{ 
public 

class 
Autenticacion 
{ 
public 
CuentaJugador 
IniciarSesion *
(* +
string+ 1
nombreJugador2 ?
,? @
stringA G

contrasenaH R
)R S
{		 	
CuentaJugador

 
cuentaJugador

 '
=

( )
null

* .
;

. /
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{ 
var #
cuentaJugadorRecuperada +
=, -
(. /
from/ 3
jugador4 ;
in< >
contexto? G
.G H
JugadorH O
join. 2
cuenta3 9
in: <
contexto= E
.E F
CuentaF L
on. 0
jugador1 8
.8 9
Cuenta9 ?
.? @
Correo@ F
equals. 4
cuenta5 ;
.; <
Correo< B
where. 3
jugador4 ;
.; <
NombreJugador< I
==J L
nombreJugadorM Z
&&[ ]
cuenta. 4
.4 5

Contrasena5 ?
==@ B

contrasenaC M
select. 4
new5 8
CuentaJugador9 F
{. /
	IdJugador2 ;
=< =
jugador> E
.E F
	IdJugadorF O
,O P
NumeroAvatar2 >
=? @
jugadorA H
.H I
NumeroAvatarI U
,U V
NombreJugador2 ?
=@ A
jugadorB I
.I J
NombreJugadorJ W
,W X
Correo2 8
=9 :
cuenta; A
.A B
CorreoB H
,H I

Contrasena2 <
== >
cuenta? E
.E F

ContrasenaF P
}. /
)/ 0
.0 1
FirstOrDefault1 ?
(? @
)@ A
;A B
if 
( #
cuentaJugadorRecuperada +
!=, .
null/ 3
)3 4
{ 
cuentaJugador !
=" #
new$ '
CuentaJugador( 5
{   
NumeroAvatar!! $
=!!% &#
cuentaJugadorRecuperada!!' >
.!!> ?
NumeroAvatar!!? K
,!!K L
NombreJugador"" %
=""& '#
cuentaJugadorRecuperada""( ?
.""? @
NombreJugador""@ M
,""M N
Correo## 
=##  #
cuentaJugadorRecuperada##! 8
.##8 9
Correo##9 ?
,##? @

Contrasena$$ "
=$$# $#
cuentaJugadorRecuperada$$% <
.$$< =

Contrasena$$= G
,$$G H
}%% 
;%% 
}&& 
}'' 
return)) 
cuentaJugador))  
;))  !
}** 	
}++ 
},, å(
eC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\ConsultasJugador.cs
	namespace 	
Logica
 
{ 
public 

class 
ConsultasJugador !
{ 
public 
bool 
ExisteNombreJugador '
(' (
string( .
nombreJugador/ <
)< =
{		 	
bool

 
	resultado

 
=

 
false

 "
;

" #
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{ 
int 
coincidencias !
=" #
($ %
from% )
jugador* 1
in2 4
contexto5 =
.= >
Jugador> E
where$ )
jugador* 1
.1 2
NombreJugador2 ?
==@ B
nombreJugadorC P
select$ *
jugador+ 2
)2 3
.3 4
Count4 9
(9 :
): ;
;; <
if 
( 
coincidencias !
>" #
$num$ %
)% &
{ 
	resultado 
= 
true  $
;$ %
} 
} 
return 
	resultado 
; 
} 	
public 
bool #
ExisteCorreoElectronico +
(+ ,
string, 2
correoElectronico3 D
)D E
{ 	
bool 
	resultado 
= 
false "
;" #
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{   
var!! 
coincidencias!! !
=!!" #
(!!$ %
from!!% )
cuenta!!* 0
in!!1 3
contexto!!4 <
.!!< =
Cuenta!!= C
where""$ )
cuenta""* 0
.""0 1
Correo""1 7
==""8 :
correoElectronico""; L
select##$ *
cuenta##+ 1
)##1 2
.##2 3
Count##3 8
(##8 9
)##9 :
;##: ;
if%% 
(%% 
coincidencias%% !
>%%" #
$num%%$ %
)%%% &
{&& 
	resultado'' 
='' 
true''  $
;''$ %
}(( 
})) 
return++ 
	resultado++ 
;++ 
},, 	
public.. 
int.. 1
%ObtenerNumeroPartidasJugadasDeJugador.. 8
(..8 9
string..9 ?
nombreJugador..@ M
)..M N
{// 	
int00 
partidasJugadas00 
;00  
using22 
(22 
var22 
contexto22 
=22  !
new22" %$
EntidadesRompecabezasFei22& >
(22> ?
)22? @
)22@ A
{33 
partidasJugadas44 
=44  !
(44" #
from44# '
jugador44( /
in440 2
contexto443 ;
.44; <
Jugador44< C
from55# '
partidaJugada55( 5
in556 8
contexto559 A
.55A B
ResultadoPartida55B R
where66# (
partidaJugada66) 6
.666 7
Jugador667 >
.66> ?
Equals66? E
(66E F
jugador66F M
)66M N
&&66O Q
jugador77# *
.77* +
NombreJugador77+ 8
.778 9
Equals779 ?
(77? @
nombreJugador77@ M
)77M N
select88# )
jugador88* 1
)881 2
.882 3
Count883 8
(888 9
)889 :
;88: ;
}99 
return;; 
partidasJugadas;; "
;;;" #
}<< 	
public>> 
int>> (
ObtenerNumeroPartidasGanadas>> /
(>>/ 0
string>>0 6
nombreJugador>>7 D
)>>D E
{?? 	
int@@ 
partidasGanadas@@ 
;@@  
usingBB 
(BB 
varBB 
contextoBB 
=BB  !
newBB" %$
EntidadesRompecabezasFeiBB& >
(BB> ?
)BB? @
)BB@ A
{CC 
partidasGanadasDD 
=DD  !
(DD" #
fromDD# '
partidaJugadaDD( 5
inDD6 8
contextoDD9 A
.DDA B
ResultadoPartidaDDB R
whereEE# (
partidaJugadaEE) 6
.EE6 7
JugadorEE7 >
.EE> ?
NombreJugadorEE? L
.EEL M
EqualsFF# )
(FF) *
nombreJugadorFF* 7
)FF7 8
&&FF9 ;
partidaJugadaFF< I
.FFI J
	EsGanadorFFJ S
selectGG# )
partidaJugadaGG* 7
)GG7 8
.GG8 9
CountGG9 >
(GG> ?
)GG? @
;GG@ A
}HH 
returnJJ 
partidasGanadasJJ "
;JJ" #
}KK 	
}LL 
}MM ˝
bC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\CuentaJugador.cs
	namespace 	
Logica
 
{ 
[ 
DataContract 
] 
public 

class 
CuentaJugador 
{ 
[		 	

DataMember			 
]		 
public

 
int

 
	IdJugador

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
[ 	

DataMember	 
] 
public 
string 
NombreJugador #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	

DataMember	 
] 
public 
int 
NumeroAvatar 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	

DataMember	 
] 
public 
string 
Correo 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	

DataMember	 
] 
public 
string 

Contrasena  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	

DataMember	 
] 
public 
int 
Puntaje 
{ 
get  
;  !
set" %
;% &
}' (
[ 	

DataMember	 
] 
public %
EstadoConectividadJugador (
EstadoConectividad) ;
{< =
get> A
;A B
setC F
;F G
}H I
public 
GestionContexto 
OperacionesContexto 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
public## 
override## 
string## 
ToString## '
(##' (
)##( )
{$$ 	
return%% 
$"%% 
$str%% %
{%%% &
NombreJugador%%& 3
}%%3 4
$str%%4 6
"%%6 7
+%%8 9
$"&& 
$str&& !
{&&! "
NumeroAvatar&&" .
}&&. /
$str&&/ 1
"&&1 2
+&&3 4
$"'' 
$str'' 
{'' 
Correo'' "
}''" #
$str''# %
"''% &
+''' (
$"(( 
$str(( 
{((  

Contrasena((  *
}((* +
"((+ ,
;((, -
})) 	
}++ 
},, Á
nC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\EstadoConectividadJugador.cs
	namespace 	
Logica
 
{ 
public 

enum %
EstadoConectividadJugador )
{ 
Desconectado 
= 
$num 
, 
	Conectado 
= 
$num 
, 
	EnPartida 
= 
$num 
} 
}		 ‚
lC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\GeneradorMensajesCorreo.cs
	namespace		 	
Logica		
 
{

 
public 

class #
GeneradorMensajesCorreo (
{ 
private 
static 
readonly 
ILog  $
Log% (
=) *
Registrador+ 6
.6 7
	GetLogger7 @
(@ A
)A B
;B C
public 
bool 
EnviarMensaje !
(! "
string" (

encabezado) 3
,3 4
string5 ;
correoDestino< I
,I J
string 
asunto 
, 
string !
mensaje" )
)) *
{ 	
bool 
	resultado 
= 
true !
;! "
int 
NumeroPuerto 
= 
$num "
;" #

SmtpClient 
clienteSmtp "
=# $
new% (

SmtpClient) 3
(3 4
$str4 D
,D E
NumeroPuertoF R
)R S
;S T
clienteSmtp 
. 
	EnableSsl !
=" #
true$ (
;( )
try 
{ 
MailMessage 
mensajeCorreo )
=* +
new, /
MailMessage0 ;
(; <
)< =
{ 
From 
= 
new 
MailAddress *
(* +

Properties+ 5
.5 6
Settings6 >
.> ?
Default? F
.F G
EmailG L
,L M

encabezadoN X
)X Y
,Y Z
Subject 
= 
asunto $
,$ %
Body 
= 
mensaje "
," #
BodyEncoding  
=! "
Encoding# +
.+ ,
UTF8, 0
,0 1

IsBodyHtml 
=  
true! %
}   
;   
mensajeCorreo!! 
.!! 
To!!  
.!!  !
Add!!! $
(!!$ %
correoDestino!!% 2
)!!2 3
;!!3 4
clienteSmtp## 
.## 
Credentials## '
=##( )
new##* -
NetworkCredential##. ?
(##? @

Properties##@ J
.##J K
Settings##K S
.##S T
Default##T [
.##[ \
Email##\ a
,##a b

Properties##c m
.##m n
Settings##n v
.##v w
Default##w ~
.##~ 
EmailPassword	## å
)
##å ç
;
##ç é
clienteSmtp$$ 
.$$ 
	EnableSsl$$ %
=$$& '
true$$( ,
;$$, -
clienteSmtp%% 
.%% 
Send%%  
(%%  !
mensajeCorreo%%! .
)%%. /
;%%/ 0
}&& 
catch'' 
('' 
ArgumentException'' $
ex''% '
)''' (
{(( 
Log)) 
.)) 
Error)) 
()) 
$")) 
{)) 
ex)) 
.))  
Message))  '
}))' (
"))( )
)))) *
;))* +
	resultado** 
=** 
false** !
;**! "
}++ 
catch,, 
(,, 
SmtpException,,  
ex,,! #
),,# $
{-- 
Log.. 
... 
Error.. 
(.. 
$".. 
{.. 
ex.. 
...  
Message..  '
}..' (
"..( )
)..) *
;..* +
	resultado// 
=// 
false// !
;//! "
}00 
finally11 
{22 
clienteSmtp33 
.33 
Dispose33 #
(33# $
)33$ %
;33% &
}44 
return55 
	resultado55 
;55 
}66 	
}77 
}88 é
dC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionContexto.cs
	namespace 	
Logica
 
{ 
public 

class 
GestionContexto  
{ 
public 
OperationContext !
ContextoIServicioSala  5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
public		 
OperationContext		 &
ContextoIServicioAmistades		  :
{		; <
get		= @
;		@ A
set		B E
;		E F
}		G H
public 
GestionContexto 
( 
)  
{ 	!
ContextoIServicioSala !
=" #
null$ (
;( )&
ContextoIServicioAmistades &
=' (
null) -
;- .
} 	
} 
} ’ù
eC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionAmistades.cs
	namespace 	
Logica
 
{ 
public 

class 
GestionAmistades !
{ 
public		 
List		 
<		 
CuentaJugador		 !
>		! ""
ObtenerAmigosDeJugador		# 9
(		9 :
string		: @
nombreJugador		A N
)		N O
{

 	
List 
< 
CuentaJugador 
> 
amigos  &
=' (
new) ,
List- 1
<1 2
CuentaJugador2 ?
>? @
(@ A
)A B
;B C
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{ 
var 
amigosObtenidos #
=$ %
(& '
from' +
jugador, 3
in4 6
contexto7 ?
.? @
Jugador@ G
from& *
amistad+ 2
in3 5
contexto6 >
.> ?
Amistad? F
where& +
amistad, 3
.3 4
JugadorA4 <
.< =
NombreJugador= J
.J K
Equals& ,
(, -
jugador- 4
.4 5
NombreJugador5 B
)B C
&&D F
jugador& -
.- .
NombreJugador. ;
.; <
Equals< B
(B C
nombreJugadorC P
)P Q
select& ,
amistad- 4
.4 5
JugadorB5 =
)= >
.> ?
Concat? E
(E F
from& *
jugador+ 2
in3 5
contexto6 >
.> ?
Jugador? F
from& *
amistad+ 2
in3 5
contexto6 >
.> ?
Amistad? F
where& +
amistad, 3
.3 4
JugadorB4 <
.< =
NombreJugador= J
.J K
Equals& ,
(, -
jugador- 4
.4 5
NombreJugador5 B
)B C
&&D F
jugador& -
.- .
NombreJugador. ;
.; <
Equals< B
(B C
nombreJugadorC P
)P Q
select& ,
amistad- 4
.4 5
JugadorA5 =
)= >
.> ?
ToList? E
(E F
)F G
;G H
foreach 
( 
Jugador  
amigo! &
in' )
amigosObtenidos* 9
)9 :
{ 
amigos 
. 
Add 
( 
new "
CuentaJugador# 0
{ 
NombreJugador   %
=  & '
amigo  ( -
.  - .
NombreJugador  . ;
,  ; <
NumeroAvatar!! $
=!!% &
amigo!!' ,
.!!, -
NumeroAvatar!!- 9
,!!9 :
}"" 
)"" 
;"" 
}## 
}$$ 
return&& 
amigos&& 
;&& 
}'' 	
public)) 
List)) 
<)) 
CuentaJugador)) !
>))! "1
%ObtenerJugadoresConSolicitudPendiente))# H
())H I
string** 
nombreJugador**  
)**  !
{++ 	
List,, 
<,, 
CuentaJugador,, 
>,, *
jugadoresConSolicitudPendiente,,  >
=,,? @
new,,A D
List,,E I
<,,I J
CuentaJugador,,J W
>,,W X
(,,X Y
),,Y Z
;,,Z [
using.. 
(.. 
var.. 
contexto.. 
=..  !
new.." %$
EntidadesRompecabezasFei..& >
(..> ?
)..? @
)..@ A
{// 
var00 
	jugadores00 
=00 
(00  !
from00! %
	solicitud00& /
in000 2
contexto003 ;
.00; <
SolicitudAmistad00< L
where11! &
	solicitud11' 0
.110 1
JugadorDestino111 ?
.11? @
NombreJugador11@ M
.11M N
Equals22! '
(22' (
nombreJugador22( 5
)225 6
select33! '
	solicitud33( 1
.331 2
JugadorOrigen332 ?
)33? @
.33@ A
ToList33A G
(33G H
)33H I
;33I J
foreach55 
(55 
Jugador55  
jugador55! (
in55) +
	jugadores55, 5
)555 6
{66 *
jugadoresConSolicitudPendiente77 2
.772 3
Add773 6
(776 7
new777 :
CuentaJugador77; H
{88 
NombreJugador99 %
=99& '
jugador99( /
.99/ 0
NombreJugador990 =
,99= >
NumeroAvatar:: $
=::% &
jugador::' .
.::. /
NumeroAvatar::/ ;
};; 
);; 
;;; 
}<< 
}== 
return?? *
jugadoresConSolicitudPendiente?? 1
;??1 2
}@@ 	
publicBB 
boolBB $
EnviarSolicitudDeAmistadBB ,
(BB, -
stringBB- 3
nombreJugadorOrigenBB4 G
,BBG H
stringCC  
nombreJugadorDestinoCC '
)CC' (
{DD 	
boolEE 
	resultadoEE 
=EE 
falseEE "
;EE" #
usingGG 
(GG 
varGG 
contextoGG 
=GG  !
newGG" %$
EntidadesRompecabezasFeiGG& >
(GG> ?
)GG? @
)GG@ A
{HH 
varII 
jugadorOrigenII !
=II" #
contextoII$ ,
.II, -
JugadorII- 4
.II4 5
WhereII5 :
(II: ;
jugadorII; B
=>IIC E
jugadorJJ 
.JJ 
NombreJugadorJJ )
==JJ* ,
nombreJugadorOrigenJJ- @
)JJ@ A
.JJA B
FirstOrDefaultJJB P
(JJP Q
)JJQ R
;JJR S
varKK 
jugadorDestinoKK "
=KK# $
contextoKK% -
.KK- .
JugadorKK. 5
.KK5 6
WhereKK6 ;
(KK; <
jugadorKK< C
=>KKD F
jugadorLL 
.LL 
NombreJugadorLL )
==LL* , 
nombreJugadorDestinoLL- A
)LLA B
.LLB C
FirstOrDefaultLLC Q
(LLQ R
)LLR S
;LLS T
ifNN 
(NN 
jugadorOrigenNN !
!=NN" $
nullNN% )
&&NN* ,
jugadorDestinoNN- ;
!=NN< >
nullNN? C
)NNC D
{OO 
SolicitudAmistadPP $
	solicitudPP% .
=PP/ 0
newPP1 4
SolicitudAmistadPP5 E
{QQ 
IdJugadorOrigenRR '
=RR( )
jugadorOrigenRR* 7
.RR7 8
	IdJugadorRR8 A
,RRA B
IdJugadorDestinoSS (
=SS) *
jugadorDestinoSS+ 9
.SS9 :
	IdJugadorSS: C
,SSC D
}TT 
;TT 
contextoUU 
.UU 
SolicitudAmistadUU -
.UU- .
AddUU. 1
(UU1 2
	solicitudUU2 ;
)UU; <
;UU< =
	resultadoVV 
=VV 
contextoVV  (
.VV( )
SaveChangesVV) 4
(VV4 5
)VV5 6
>VV7 8
$numVV9 :
;VV: ;
}WW 
}XX 
returnZZ 
	resultadoZZ 
;ZZ 
}[[ 	
public]] 
bool]] %
AceptarSolicitudDeAmistad]] -
(]]- .
string]]. 4
nombreJugadorOrigen]]5 H
,]]H I
string^^  
nombreJugadorDestino^^ '
)^^' (
{__ 	
bool`` 
	resultado`` 
=`` 
false`` "
;``" #
ifbb 
(bb $
ExisteSolicitudDeAmistadbb (
(bb( )
nombreJugadorOrigenbb) <
,bb< = 
nombreJugadorDestinobb> R
)bbR S
)bbS T
{cc &
EliminarSolicitudDeAmistaddd *
(dd* +
nombreJugadorOrigendd+ >
,dd> ? 
nombreJugadorDestinodd@ T
)ddT U
;ddU V
}ee 
ifgg 
(gg $
ExisteSolicitudDeAmistadgg (
(gg( ) 
nombreJugadorDestinogg) =
,gg= >
nombreJugadorOrigengg? R
)ggR S
)ggS T
{hh &
EliminarSolicitudDeAmistadii *
(ii* + 
nombreJugadorDestinoii+ ?
,ii? @
nombreJugadorOrigeniiA T
)iiT U
;iiU V
}jj 
ifll 
(ll 
!ll #
ExisteAmistadConJugadorll (
(ll( )
nombreJugadorOrigenll) <
,ll< = 
nombreJugadorDestinoll> R
)llR S
)llS T
{mm 
	resultadonn 
=nn /
#RegistrarNuevaAmistadEntreJugadoresnn ?
(nn? @
nombreJugadorOrigennn@ S
,nnS T 
nombreJugadorDestinooo (
)oo( )
;oo) *
}pp 
returnrr 
	resultadorr 
;rr 
}ss 	
privateuu 
booluu /
#RegistrarNuevaAmistadEntreJugadoresuu 8
(uu8 9
stringuu9 ?
nombreJugadorAuu@ N
,uuN O
stringvv 
nombreJugadorBvv !
)vv! "
{ww 	
boolxx 
	resultadoxx 
=xx 
falsexx "
;xx" #
usingzz 
(zz 
varzz 
contextozz 
=zz  !
newzz" %$
EntidadesRompecabezasFeizz& >
(zz> ?
)zz? @
)zz@ A
{{{ 
var|| 
jugadorA|| 
=|| 
contexto|| '
.||' (
Jugador||( /
.||/ 0
Where||0 5
(||5 6
jugador||6 =
=>||> @
jugador}} 
.}} 
NombreJugador}} )
==}}* ,
nombreJugadorA}}- ;
)}}; <
.}}< =
FirstOrDefault}}= K
(}}K L
)}}L M
;}}M N
var~~ 
jugadorB~~ 
=~~ 
contexto~~ '
.~~' (
Jugador~~( /
.~~/ 0
Where~~0 5
(~~5 6
jugador~~6 =
=>~~> @
jugador 
. 
NombreJugador )
==* ,
nombreJugadorB- ;
); <
.< =
FirstOrDefault= K
(K L
)L M
;M N
if
ÅÅ 
(
ÅÅ 
jugadorA
ÅÅ 
!=
ÅÅ 
null
ÅÅ  $
&&
ÅÅ% '
jugadorB
ÅÅ( 0
!=
ÅÅ1 3
null
ÅÅ4 8
)
ÅÅ8 9
{
ÇÇ 
Amistad
ÉÉ 
amistad
ÉÉ #
=
ÉÉ$ %
new
ÉÉ& )
Amistad
ÉÉ* 1
{
ÑÑ 

IdJugadorA
ÖÖ "
=
ÖÖ# $
jugadorA
ÖÖ% -
.
ÖÖ- .
	IdJugador
ÖÖ. 7
,
ÖÖ7 8

IdJugadorB
ÜÜ "
=
ÜÜ# $
jugadorB
ÜÜ% -
.
ÜÜ- .
	IdJugador
ÜÜ. 7
}
áá 
;
áá 
contexto
àà 
.
àà 
Amistad
àà $
.
àà$ %
Add
àà% (
(
àà( )
amistad
àà) 0
)
àà0 1
;
àà1 2
	resultado
ââ 
=
ââ 
contexto
ââ  (
.
ââ( )
SaveChanges
ââ) 4
(
ââ4 5
)
ââ5 6
>
ââ7 8
$num
ââ9 :
;
ââ: ;
}
ää 
}
ãã 
return
çç 
	resultado
çç 
;
çç 
}
éé 	
public
êê 
bool
êê +
EliminarAmistadEntreJugadores
êê 1
(
êê1 2
string
êê2 8
nombreJugadorA
êê9 G
,
êêG H
string
êêI O
nombreJugadorB
êêP ^
)
êê^ _
{
ëë 	
bool
íí 
	resultado
íí 
=
íí 
false
íí "
;
íí" #
using
îî 
(
îî 
var
îî 
contexto
îî 
=
îî  !
new
îî" %&
EntidadesRompecabezasFei
îî& >
(
îî> ?
)
îî? @
)
îî@ A
{
ïï 
var
ññ 
amistadObtenida
ññ #
=
ññ$ %
contexto
ññ& .
.
ññ. /
Amistad
ññ/ 6
.
ññ6 7
FirstOrDefault
ññ7 E
(
ññE F
amistad
ññF M
=>
ññN P
amistad
óó 
.
óó 
JugadorA
óó $
.
óó$ %
NombreJugador
óó% 2
.
óó2 3
Equals
óó3 9
(
óó9 :
nombreJugadorA
óó: H
)
óóH I
&&
óóJ L
amistad
òò 
.
òò 
JugadorB
òò $
.
òò$ %
NombreJugador
òò% 2
.
òò2 3
Equals
òò3 9
(
òò9 :
nombreJugadorB
òò: H
)
òòH I
||
òòJ L
amistad
ôô 
.
ôô 
JugadorA
ôô $
.
ôô$ %
NombreJugador
ôô% 2
.
ôô2 3
Equals
ôô3 9
(
ôô9 :
nombreJugadorB
ôô: H
)
ôôH I
&&
ôôJ L
amistad
öö 
.
öö 
JugadorB
öö $
.
öö$ %
NombreJugador
öö% 2
.
öö2 3
Equals
öö3 9
(
öö9 :
nombreJugadorA
öö: H
)
ööH I
)
ööI J
;
ööJ K
if
úú 
(
úú 
amistadObtenida
úú #
!=
úú$ &
null
úú' +
)
úú+ ,
{
ùù 
contexto
ûû 
.
ûû 
Amistad
ûû $
.
ûû$ %
Remove
ûû% +
(
ûû+ ,
amistadObtenida
ûû, ;
)
ûû; <
;
ûû< =
	resultado
üü 
=
üü 
contexto
üü  (
.
üü( )
SaveChanges
üü) 4
(
üü4 5
)
üü5 6
>
üü7 8
$num
üü9 :
;
üü: ;
}
†† 
}
°° 
return
££ 
	resultado
££ 
;
££ 
}
§§ 	
public
¶¶ 
bool
¶¶ (
EliminarSolicitudDeAmistad
¶¶ .
(
¶¶. /
string
¶¶/ 5!
nombreJugadorOrigen
¶¶6 I
,
¶¶I J
string
ßß "
nombreJugadorDestino
ßß '
)
ßß' (
{
®® 	
bool
©© 
	resultado
©© 
=
©© 
false
©© "
;
©©" #
using
´´ 
(
´´ 
var
´´ 
contexto
´´ 
=
´´  !
new
´´" %&
EntidadesRompecabezasFei
´´& >
(
´´> ?
)
´´? @
)
´´@ A
{
¨¨ 
var
≠≠ &
solicitudAmistadObtenida
≠≠ ,
=
≠≠- .
contexto
≠≠/ 7
.
≠≠7 8
SolicitudAmistad
≠≠8 H
.
≠≠H I
FirstOrDefault
ÆÆ "
(
ÆÆ" #
	solicitud
ÆÆ# ,
=>
ÆÆ- /
	solicitud
ØØ 
.
ØØ 
JugadorOrigen
ØØ +
.
ØØ+ ,
NombreJugador
ØØ, 9
.
ØØ9 :
Equals
ØØ: @
(
ØØ@ A!
nombreJugadorOrigen
ØØA T
)
ØØT U
&&
ØØV X
	solicitud
∞∞ 
.
∞∞ 
JugadorDestino
∞∞ ,
.
∞∞, -
NombreJugador
∞∞- :
.
∞∞: ;
Equals
∞∞; A
(
∞∞A B"
nombreJugadorDestino
∞∞B V
)
∞∞V W
)
∞∞W X
;
∞∞X Y
if
≤≤ 
(
≤≤ &
solicitudAmistadObtenida
≤≤ ,
!=
≤≤- /
null
≤≤0 4
)
≤≤4 5
{
≥≥ 
contexto
¥¥ 
.
¥¥ 
SolicitudAmistad
¥¥ -
.
¥¥- .
Remove
¥¥. 4
(
¥¥4 5&
solicitudAmistadObtenida
¥¥5 M
)
¥¥M N
;
¥¥N O
	resultado
µµ 
=
µµ 
contexto
µµ  (
.
µµ( )
SaveChanges
µµ) 4
(
µµ4 5
)
µµ5 6
>
µµ7 8
$num
µµ9 :
;
µµ: ;
}
∂∂ 
}
∑∑ 
return
ππ 
	resultado
ππ 
;
ππ 
}
∫∫ 	
public
ºº 
bool
ºº &
ExisteSolicitudDeAmistad
ºº ,
(
ºº, -
string
ºº- 3!
nombreJugadorOrigen
ºº4 G
,
ººG H
string
ΩΩ "
nombreJugadorDestino
ΩΩ '
)
ΩΩ' (
{
ææ 	
bool
øø 
	resultado
øø 
=
øø 
false
øø "
;
øø" #
using
¡¡ 
(
¡¡ 
var
¡¡ 
contexto
¡¡ 
=
¡¡  !
new
¡¡" %&
EntidadesRompecabezasFei
¡¡& >
(
¡¡> ?
)
¡¡? @
)
¡¡@ A
{
¬¬ 
int
√√ 
coincidencias
√√ !
=
√√" #
(
√√$ %
from
√√% )
	solicitud
√√* 3
in
√√4 6
contexto
√√7 ?
.
√√? @
SolicitudAmistad
√√@ P
where
ƒƒ% *
	solicitud
ƒƒ+ 4
.
ƒƒ4 5
JugadorOrigen
ƒƒ5 B
.
ƒƒB C
NombreJugador
ƒƒC P
.
ƒƒP Q
Equals
≈≈% +
(
≈≈+ ,!
nombreJugadorOrigen
≈≈, ?
)
≈≈? @
&&
≈≈A C
	solicitud
∆∆% .
.
∆∆. /
JugadorDestino
∆∆/ =
.
∆∆= >
NombreJugador
∆∆> K
.
∆∆K L
Equals
««% +
(
««+ ,"
nombreJugadorDestino
««, @
)
««@ A
select
»»% +
	solicitud
»», 5
)
»»5 6
.
»»6 7
Count
»»7 <
(
»»< =
)
»»= >
;
»»> ?
if
   
(
   
coincidencias
   !
>
  " #
$num
  $ %
)
  % &
{
ÀÀ 
	resultado
ÃÃ 
=
ÃÃ 
true
ÃÃ  $
;
ÃÃ$ %
}
ÕÕ 
}
ŒŒ 
return
–– 
	resultado
–– 
;
–– 
}
—— 	
public
”” 
bool
”” %
ExisteAmistadConJugador
”” +
(
””+ ,
string
””, 2
nombreJugadorA
””3 A
,
””A B
string
””C I
nombreJugadorB
””J X
)
””X Y
{
‘‘ 	
bool
’’ 
	resultado
’’ 
=
’’ 
false
’’ "
;
’’" #
using
◊◊ 
(
◊◊ 
var
◊◊ 
contexto
◊◊ 
=
◊◊  !
new
◊◊" %&
EntidadesRompecabezasFei
◊◊& >
(
◊◊> ?
)
◊◊? @
)
◊◊@ A
{
ÿÿ 
int
ŸŸ 
coincidencias
ŸŸ !
=
ŸŸ" #
(
ŸŸ$ %
from
ŸŸ% )
amistad
ŸŸ* 1
in
ŸŸ2 4
contexto
ŸŸ5 =
.
ŸŸ= >
Amistad
ŸŸ> E
where
⁄⁄$ )
amistad
⁄⁄* 1
.
⁄⁄1 2
JugadorA
⁄⁄2 :
.
⁄⁄: ;
NombreJugador
⁄⁄; H
.
⁄⁄H I
Equals
€€$ *
(
€€* +
nombreJugadorA
€€+ 9
)
€€9 :
&&
€€; =
amistad
‹‹$ +
.
‹‹+ ,
JugadorB
‹‹, 4
.
‹‹4 5
NombreJugador
‹‹5 B
.
‹‹B C
Equals
››$ *
(
››* +
nombreJugadorB
››+ 9
)
››9 :
||
››; =
amistad
ﬁﬁ$ +
.
ﬁﬁ+ ,
JugadorA
ﬁﬁ, 4
.
ﬁﬁ4 5
NombreJugador
ﬁﬁ5 B
.
ﬁﬁB C
Equals
ﬂﬂ$ *
(
ﬂﬂ* +
nombreJugadorB
ﬂﬂ+ 9
)
ﬂﬂ9 :
&&
ﬂﬂ; =
amistad
‡‡$ +
.
‡‡+ ,
JugadorB
‡‡, 4
.
‡‡4 5
NombreJugador
‡‡5 B
.
‡‡B C
Equals
··$ *
(
··* +
nombreJugadorA
··+ 9
)
··9 :
select
‚‚$ *
amistad
‚‚+ 2
)
‚‚2 3
.
‚‚3 4
Count
‚‚4 9
(
‚‚9 :
)
‚‚: ;
;
‚‚; <
if
‰‰ 
(
‰‰ 
coincidencias
‰‰ !
>
‰‰" #
$num
‰‰$ %
)
‰‰% &
{
ÂÂ 
	resultado
ÊÊ 
=
ÊÊ 
true
ÊÊ  $
;
ÊÊ$ %
}
ÁÁ 
}
ËË 
return
ÍÍ 
	resultado
ÍÍ 
;
ÍÍ 
}
ÎÎ 	
}
ÏÏ 
}ÌÌ ÿ"
cC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionPartida.cs
	namespace 	
Logica
 
{		 
public

 

class

 
GestionPartida

 
{ 
public 
bool 
CrearNuevaPartida %
(% &
string& ,

codigoSala- 7
)7 8
{ 	
bool 
	resultado 
= 
false "
;" #
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{ 
Datos 
. 
Sala 
salaEncontrada )
=* +
contexto, 4
.4 5
Sala5 9
.9 :
FirstOrDefault: H
(H I
sala 
=> 
sala  
.  !
Codigo! '
.' (
Equals( .
(. /

codigoSala/ 9
)9 :
): ;
;; <
if 
( 
salaEncontrada "
!=# %
null& *
)* +
{ 
Partida 
nuevaPartida (
=) *
new+ .
Partida/ 6
{ 

Dificultad "
=# $
DificultadPartida% 6
.6 7
Facil7 <
,< =
IdSala 
=  
salaEncontrada! /
./ 0
IdSala0 6
,6 7
} 
; 
contexto 
. 
Partida $
.$ %
Add% (
(( )
nuevaPartida) 5
)5 6
;6 7
	resultado 
= 
contexto  (
.( )
SaveChanges) 4
(4 5
)5 6
>7 8
$num9 :
;: ;
} 
} 
return!! 
	resultado!! 
;!! 
}"" 	
public$$ 
bool$$ 
FinalizarPartida$$ $
($$$ %
string$$% +

codigoSala$$, 6
,$$6 7
CuentaJugador%% 
cuentaJugador%% '
,%%' (
bool%%) -
	esGanador%%. 7
)%%7 8
{&& 	
bool'' 
	resultado'' 
='' 
false'' "
;''" #
using)) 
()) 
var)) 
contexto)) 
=))  !
new))" %$
EntidadesRompecabezasFei))& >
())> ?
)))? @
)))@ A
{** 
Partida++ 
partidaEncontrada++ )
=++* +
contexto++, 4
.++4 5
Partida++5 <
.++< =
OrderByDescending++= N
(++N O
partida,, 
=>,, 
partida,, &
.,,& '
	IdPartida,,' 0
),,0 1
.,,1 2
Where,,2 7
(,,7 8
partida,,8 ?
=>,,@ B
partida-- 
.-- 
Sala--  
.--  !
Codigo--! '
==--( *

codigoSala--+ 5
)--5 6
.--6 7
FirstOrDefault--7 E
(--E F
)--F G
;--G H
if// 
(// 
partidaEncontrada// %
!=//& (
null//) -
)//- .
{00 
ResultadoPartida11 $
resultadoPartida11% 5
=116 7
new118 ;
ResultadoPartida11< L
{22 
	IdPartida33 !
=33" #
partidaEncontrada33$ 5
.335 6
	IdPartida336 ?
,33? @
	IdJugador44 !
=44" #
cuentaJugador44$ 1
.441 2
	IdJugador442 ;
,44; <
	EsGanador55 !
=55" #
	esGanador55$ -
,55- .
Puntaje66 
=66  !
cuentaJugador66" /
.66/ 0
Puntaje660 7
,667 8
}77 
;77 
contexto88 
.88 
ResultadoPartida88 -
.88- .
Add88. 1
(881 2
resultadoPartida882 B
)88B C
;88C D
	resultado99 
=99 
contexto99  (
.99( )
SaveChanges99) 4
(994 5
)995 6
>997 8
$num999 :
;99: ;
}:: 
};; 
return== 
	resultado== 
;== 
}>> 	
}?? 
}@@ ‹
`C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionSala.cs
	namespace 	
Logica
 
{		 
public

 

class

 
GestionSala

 
{ 
public 
bool 
CrearNuevaSala "
(" #
string# )
nombreAnfitrion* 9
,9 :
string; A

codigoSalaB L
)L M
{ 	
bool 
	resultado 
= 
false "
;" #
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{ 
Jugador 
jugadorAnfitrion (
=) *
contexto+ 3
.3 4
Jugador4 ;
.; <
Where< A
(A B
jugadorB I
=>J L
jugador 
. 
NombreJugador )
==* ,
nombreAnfitrion- <
)< =
.= >
FirstOrDefault> L
(L M
)M N
;N O
if 
( 
jugadorAnfitrion $
!=% '
null( ,
), -
{ 
Datos 
. 
Sala 
	nuevaSala (
=) *
new+ .
Datos/ 4
.4 5
Sala5 9
{ 
Codigo 
=  

codigoSala! +
,+ ,
IdAnfitrion #
=$ %
jugadorAnfitrion& 6
.6 7
	IdJugador7 @
,@ A
MaximoJugadores '
=( )
Sala* .
.. /
MaximoJugadores/ >
,> ?
MinimoJugadores '
=( )
Sala* .
.. /
MinimoJugadores/ >
,> ?
} 
; 
contexto 
. 
Sala !
.! "
Add" %
(% &
	nuevaSala& /
)/ 0
;0 1
	resultado 
= 
contexto  (
.( )
SaveChanges) 4
(4 5
)5 6
>7 8
$num9 :
;: ;
}   
}!! 
return## 
	resultado## 
;## 
}$$ 	
}%% 
}&& ó
lC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str !
)! "
]" #
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
$str #
)# $
]$ %
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
]$$) *£*
]C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\Registro.cs
	namespace 	
Logica
 
{ 
public 

class 
Registro 
{ 
public 
bool 
	Registrar 
( 
CuentaJugador +!
cuentaJugadorRegistro, A
)A B
{		 	
bool

 
	resultado

 
=

 
false

 "
;

" #
using 
( 
var 
contexto 
=  !
new" %$
EntidadesRompecabezasFei& >
(> ?
)? @
)@ A
{ 
Cuenta 
nuevaCuenta "
=# $
new% (
Cuenta) /
(/ 0
)0 1
{ 
Correo 
= !
cuentaJugadorRegistro 2
.2 3
Correo3 9
,9 :

Contrasena 
=  !
cuentaJugadorRegistro! 6
.6 7

Contrasena7 A
,A B
} 
; 
Jugador 
nuevoJugador $
=% &
new' *
Jugador+ 2
(2 3
)3 4
{ 
NombreJugador !
=" #!
cuentaJugadorRegistro$ 9
.9 :
NombreJugador: G
,G H
NumeroAvatar  
=! "!
cuentaJugadorRegistro# 8
.8 9
NumeroAvatar9 E
,E F
} 
; 
contexto 
. 
Jugador  
.  !
Add! $
($ %
nuevoJugador% 1
)1 2
;2 3
contexto 
. 
Cuenta 
.  
Add  #
(# $
nuevaCuenta$ /
)/ 0
;0 1
nuevoJugador 
. 
Cuenta #
=$ %
nuevaCuenta& 1
;1 2
nuevaCuenta 
. 
Jugador #
=$ %
nuevoJugador& 2
;2 3
	resultado 
= 
contexto $
.$ %
SaveChanges% 0
(0 1
)1 2
>3 4
$num5 6
;6 7
} 
return 
	resultado 
; 
}   	
public"" 
bool"" !
ActualizarInformacion"" )
("") *
string""* 0
nombreAnterior""1 ?
,""? @
string## 
nuevoNombre## 
,## 
int##  #
nuevoNumeroAvatar##$ 5
)##5 6
{$$ 	
bool%% 
	resultado%% 
=%% 
false%% "
;%%" #
using'' 
('' 
var'' 
contexto'' 
=''  !
new''" %$
EntidadesRompecabezasFei''& >
(''> ?
)''? @
)''@ A
{(( 
var)) 
jugadorActual)) !
=))" #
contexto))$ ,
.)), -
Jugador))- 4
.))4 5
Where))5 :
()): ;
jugador)); B
=>))C E
jugador** 
.** 
NombreJugador** )
==*** ,
nombreAnterior**- ;
)**; <
.**< =
FirstOrDefault**= K
(**K L
)**L M
;**M N
if,, 
(,, 
jugadorActual,, !
!=,," $
null,,% )
),,) *
{-- 
jugadorActual.. !
...! "
NombreJugador.." /
=..0 1
nuevoNombre..2 =
;..= >
jugadorActual// !
.//! "
NumeroAvatar//" .
=/// 0
nuevoNumeroAvatar//1 B
;//B C
	resultado00 
=00 
contexto00  (
.00( )
SaveChanges00) 4
(004 5
)005 6
>007 8
$num009 :
;00: ;
}11 
}22 
return44 
	resultado44 
;44 
}55 	
public77 
bool77  
ActualizarContrasena77 (
(77( )
string77) /
correo770 6
,776 7
string778 >

contrasena77? I
)77I J
{88 	
bool99 
	resultado99 
=99 
false99 "
;99" #
using;; 
(;; 
var;; 
contexto;; 
=;;  !
new;;" %$
EntidadesRompecabezasFei;;& >
(;;> ?
);;? @
);;@ A
{<< 
var== 
cuentaObtenida== "
===# $
contexto==% -
.==- .
Cuenta==. 4
.==4 5
FirstOrDefault==5 C
(==C D
cuenta==D J
=>==K M
cuenta>> 
.>> 
Correo>> !
==>>" $
correo>>% +
)>>+ ,
;>>, -
if@@ 
(@@ 
cuentaObtenida@@ "
!=@@# %
null@@& *
)@@* +
{AA 
cuentaObtenidaBB "
.BB" #

ContrasenaBB# -
=BB. /

contrasenaBB0 :
;BB: ;
}CC 
	resultadoEE 
=EE 
contextoEE $
.EE$ %
SaveChangesEE% 0
(EE0 1
)EE1 2
>EE3 4
$numEE5 6
;EE6 7
}FF 
returnHH 
	resultadoHH 
;HH 
}II 	
}JJ 
}KK ¨
YC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Logica\Sala.cs
	namespace 	
Logica
 
{ 
[ 
DataContract 
] 
public 

class 
Sala 
{ 
public		 
const		 
int		 
MaximoJugadores		 (
=		) *
$num		+ ,
;		, -
public

 
const

 
int

 
MinimoJugadores

 (
=

) *
$num

+ ,
;

, -
[ 	

DataMember	 
] 
public 
string 

CodigoSala  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	

DataMember	 
] 
public 
string 
NombreAnfitrion %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	

DataMember	 
] 
public 
int %
ContadorJugadoresActuales ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
[ 	

DataMember	 
] 
public 
List 
< 
CuentaJugador !
>! "
	Jugadores# ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
bool 
ExisteCupoJugadores '
(' (
)( )
{ 	
return %
ContadorJugadoresActuales ,
<- .
MaximoJugadores/ >
;> ?
} 	
public 
bool 
	EstaVacia 
( 
) 
{ 	
return %
ContadorJugadoresActuales ,
==- /
$num0 1
;1 2
}   	
}!! 
}"" 