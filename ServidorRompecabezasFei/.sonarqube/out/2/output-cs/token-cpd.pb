Á
lC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\Autenticacion.cs
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
},, ñ(
oC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\ConsultasJugador.cs
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
}MM ‘$
lC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\CuentaJugador.cs
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
{ 
private		 
int		 
	idJugador		 
;		 
private

 
string

 
nombreJugador

 $
;

$ %
private 
int 
numeroAvatar  
;  !
private 
string 
correo 
; 
private 
string 

contrasena !
;! "
private 
int 
puntaje 
; 
private %
EstadoConectividadJugador )
estadoConectividad* <
;< =
private 
GestionContexto 
operacionesContexto  3
;3 4
[ 	

DataMember	 
] 
public 
int 
	IdJugador 
{ 	
get 
{ 
return 
	idJugador "
;" #
}$ %
set 
{ 
	idJugador 
= 
value #
;# $
}% &
} 	
[ 	

DataMember	 
] 
public 
string 
NombreJugador #
{ 	
get 
{ 
return 
nombreJugador &
;& '
}( )
set 
{ 
nombreJugador 
=  !
value" '
;' (
}) *
}   	
["" 	

DataMember""	 
]"" 
public## 
int## 
NumeroAvatar## 
{$$ 	
get%% 
{%% 
return%% 
numeroAvatar%% %
;%%% &
}%%' (
set&& 
{&& 
numeroAvatar&& 
=&&  
value&&! &
;&&& '
}&&( )
}'' 	
[)) 	

DataMember))	 
])) 
public** 
string** 
Correo** 
{++ 	
get,, 
{,, 
return,, 
correo,, 
;,,  
},,! "
set-- 
{-- 
correo-- 
=-- 
value--  
;--  !
}--" #
}.. 	
[00 	

DataMember00	 
]00 
public11 
string11 

Contrasena11  
{22 	
get33 
{33 
return33 

contrasena33 #
;33# $
}33% &
set44 
{44 

contrasena44 
=44 
value44 $
;44$ %
}44& '
}55 	
[77 	

DataMember77	 
]77 
public88 
int88 
Puntaje88 
{99 	
get:: 
{:: 
return:: 
puntaje::  
;::  !
}::" #
set;; 
{;; 
puntaje;; 
=;; 
value;; !
;;;! "
};;# $
}<< 	
[>> 	

DataMember>>	 
]>> 
public?? %
EstadoConectividadJugador?? (
EstadoConectividad??) ;
{@@ 	
getAA 
{AA 
returnAA 
estadoConectividadAA +
;AA+ ,
}AA- .
setBB 
{BB 
estadoConectividadBB $
=BB% &
valueBB' ,
;BB, -
}BB. /
}CC 	
publicFF 
GestionContextoFF 
OperacionesContextoFF 2
{GG 	
getHH 
{HH 
returnHH 
operacionesContextoHH ,
;HH, -
}HH. /
setII 
{II 
operacionesContextoII %
=II& '
valueII( -
;II- .
}II/ 0
}JJ 	
publicNN 
overrideNN 
stringNN 
ToStringNN '
(NN' (
)NN( )
{OO 	
returnPP 
$"PP 
$strPP %
{PP% &
nombreJugadorPP& 3
}PP3 4
$strPP4 6
"PP6 7
+PP8 9
$"QQ 
$strQQ !
{QQ! "
numeroAvatarQQ" .
}QQ. /
$strQQ/ 1
"QQ1 2
+QQ3 4
$"RR 
$strRR 
{RR 
correoRR "
}RR" #
$strRR# %
"RR% &
+RR' (
$"SS 
$strSS 
{SS  

contrasenaSS  *
}SS* +
"SS+ ,
;SS, -
}TT 	
}VV 
}WW ë
xC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\EstadoConectividadJugador.cs
	namespace 	
Logica
 
{ 
public 

enum %
EstadoConectividadJugador )
:* +
int, /
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
}		 £
vC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\GeneradorMensajesCorreo.cs
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
=) *
	Registros+ 4
.4 5
Registrador5 @
.@ A
	GetLoggerA J
(J K
)K L
;L M
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
;S T
try 
{ 
MailMessage 
mensajeCorreo )
=* +
new, /
MailMessage0 ;
(; <
)< =
{ 
From 
= 
new 
MailAddress *
(* +

Properties+ 5
.5 6
Settings6 >
.> ?
Default? F
.F G
EmailG L
,L M

encabezadoN X
)X Y
,Y Z
Subject 
= 
asunto $
,$ %
Body 
= 
mensaje "
," #
BodyEncoding  
=! "
Encoding# +
.+ ,
UTF8, 0
,0 1

IsBodyHtml 
=  
true! %
} 
; 
mensajeCorreo 
. 
To  
.  !
Add! $
($ %
correoDestino% 2
)2 3
;3 4
clienteSmtp!! 
.!! 
Credentials!! '
=!!( )
new!!* -
NetworkCredential!!. ?
(!!? @

Properties!!@ J
.!!J K
Settings!!K S
.!!S T
Default!!T [
.!![ \
Email!!\ a
,!!a b

Properties!!c m
.!!m n
Settings!!n v
.!!v w
Default!!w ~
.!!~ 
EmailPassword	!! å
)
!!å ç
;
!!ç é
clienteSmtp"" 
."" 
	EnableSsl"" %
=""& '
true""( ,
;"", -
clienteSmtp## 
.## 
Send##  
(##  !
mensajeCorreo##! .
)##. /
;##/ 0
}$$ 
catch%% 
(%% 
ArgumentException%% $
ex%%% '
)%%' (
{&& 
Log'' 
.'' 
Error'' 
('' 
$"'' 
{'' 
ex'' 
.''  
Message''  '
}''' (
"''( )
)'') *
;''* +
	resultado(( 
=(( 
false(( !
;((! "
})) 
catch** 
(** 
SmtpException**  
ex**! #
)**# $
{++ 
Log,, 
.,, 
Error,, 
(,, 
$",, 
{,, 
ex,, 
.,,  
Message,,  '
},,' (
",,( )
),,) *
;,,* +
	resultado-- 
=-- 
false-- !
;--! "
}.. 
finally// 
{00 
clienteSmtp11 
.11 
Dispose11 #
(11# $
)11$ %
;11% &
}22 
return33 
	resultado33 
;33 
}44 	
}55 
}66 Â
nC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionContexto.cs
	namespace 	
Logica
 
{ 
public 

class 
GestionContexto  
{ 
private 
OperationContext  "
contextoIServicioJuego! 7
;7 8
private 
OperationContext  &
contextoIServicioAmistades! ;
;; <
public

 
GestionContexto

 
(

 
)

  
{ 	"
contextoIServicioJuego "
=# $
null% )
;) *&
contextoIServicioAmistades &
=' (
null) -
;- .
} 	
public 
OperationContext !
ContextoIServicioSala  5
{ 	
get 
{ 
return "
contextoIServicioJuego /
;/ 0
}1 2
set 
{ "
contextoIServicioJuego (
=) *
value+ 0
;0 1
}2 3
} 	
public 
OperationContext &
ContextoIServicioAmistades  :
{ 	
get 
{ 
return &
contextoIServicioAmistades 3
;3 4
}5 6
set 
{ &
contextoIServicioAmistades ,
=- .
value/ 4
;4 5
}6 7
} 	
} 
} Ÿ†
oC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionAmistades.cs
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
{HH 
ConsultasJugadorII  
consultasJugadorII! 1
=II2 3
newII4 7
ConsultasJugadorII8 H
(IIH I
)III J
;IIJ K
varJJ 
jugadorOrigenJJ !
=JJ" #
contextoJJ$ ,
.JJ, -
JugadorJJ- 4
.JJ4 5
WhereJJ5 :
(JJ: ;
jugadorJJ; B
=>JJC E
jugadorKK 
.KK 
NombreJugadorKK )
==KK* ,
nombreJugadorOrigenKK- @
)KK@ A
.KKA B
FirstOrDefaultKKB P
(KKP Q
)KKQ R
;KKR S
varLL 
jugadorDestinoLL "
=LL# $
contextoLL% -
.LL- .
JugadorLL. 5
.LL5 6
WhereLL6 ;
(LL; <
jugadorLL< C
=>LLD F
jugadorMM 
.MM 
NombreJugadorMM )
==MM* , 
nombreJugadorDestinoMM- A
)MMA B
.MMB C
FirstOrDefaultMMC Q
(MMQ R
)MMR S
;MMS T
ifOO 
(OO 
jugadorOrigenOO !
!=OO" $
nullOO% )
&&OO* ,
jugadorDestinoOO- ;
!=OO< >
nullOO? C
)OOC D
{PP 
SolicitudAmistadQQ $
	solicitudQQ% .
=QQ/ 0
newQQ1 4
SolicitudAmistadQQ5 E
{RR 
IdJugadorOrigenSS '
=SS( )
jugadorOrigenSS* 7
.SS7 8
	IdJugadorSS8 A
,SSA B
IdJugadorDestinoTT (
=TT) *
jugadorDestinoTT+ 9
.TT9 :
	IdJugadorTT: C
,TTC D
}UU 
;UU 
contextoVV 
.VV 
SolicitudAmistadVV -
.VV- .
AddVV. 1
(VV1 2
	solicitudVV2 ;
)VV; <
;VV< =
	resultadoWW 
=WW 
contextoWW  (
.WW( )
SaveChangesWW) 4
(WW4 5
)WW5 6
>WW7 8
$numWW9 :
;WW: ;
}XX 
}YY 
return[[ 
	resultado[[ 
;[[ 
}\\ 	
public^^ 
bool^^ %
AceptarSolicitudDeAmistad^^ -
(^^- .
string^^. 4
nombreJugadorOrigen^^5 H
,^^H I
string__  
nombreJugadorDestino__ '
)__' (
{`` 	
boolaa 
	resultadoaa 
=aa 
falseaa "
;aa" #
ifcc 
(cc $
ExisteSolicitudDeAmistadcc (
(cc( )
nombreJugadorOrigencc) <
,cc< = 
nombreJugadorDestinocc> R
)ccR S
)ccS T
{dd &
EliminarSolicitudDeAmistadee *
(ee* +
nombreJugadorOrigenee+ >
,ee> ? 
nombreJugadorDestinoee@ T
)eeT U
;eeU V
}ff 
ifhh 
(hh $
ExisteSolicitudDeAmistadhh (
(hh( ) 
nombreJugadorDestinohh) =
,hh= >
nombreJugadorOrigenhh? R
)hhR S
)hhS T
{ii &
EliminarSolicitudDeAmistadjj *
(jj* + 
nombreJugadorDestinojj+ ?
,jj? @
nombreJugadorOrigenjjA T
)jjT U
;jjU V
}kk 
ifmm 
(mm 
!mm #
ExisteAmistadConJugadormm (
(mm( )
nombreJugadorOrigenmm) <
,mm< = 
nombreJugadorDestinomm> R
)mmR S
)mmS T
{nn 
	resultadooo 
=oo /
#RegistrarNuevaAmistadEntreJugadoresoo ?
(oo? @
nombreJugadorOrigenoo@ S
,ooS T 
nombreJugadorDestinopp (
)pp( )
;pp) *
}qq 
returnss 
	resultadoss 
;ss 
}tt 	
privatevv 
boolvv /
#RegistrarNuevaAmistadEntreJugadoresvv 8
(vv8 9
stringvv9 ?
nombreJugadorAvv@ N
,vvN O
stringww 
nombreJugadorBww !
)ww! "
{xx 	
boolyy 
	resultadoyy 
=yy 
falseyy "
;yy" #
using{{ 
({{ 
var{{ 
contexto{{ 
={{  !
new{{" %$
EntidadesRompecabezasFei{{& >
({{> ?
){{? @
){{@ A
{|| 
ConsultasJugador}}  
consultasJugador}}! 1
=}}2 3
new}}4 7
ConsultasJugador}}8 H
(}}H I
)}}I J
;}}J K
var~~ 
jugadorA~~ 
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
nombreJugadorA- ;
); <
.< =
FirstOrDefault= K
(K L
)L M
;M N
var
ÄÄ 
jugadorB
ÄÄ 
=
ÄÄ 
contexto
ÄÄ '
.
ÄÄ' (
Jugador
ÄÄ( /
.
ÄÄ/ 0
Where
ÄÄ0 5
(
ÄÄ5 6
jugador
ÄÄ6 =
=>
ÄÄ> @
jugador
ÅÅ 
.
ÅÅ 
NombreJugador
ÅÅ )
==
ÅÅ* ,
nombreJugadorB
ÅÅ- ;
)
ÅÅ; <
.
ÅÅ< =
FirstOrDefault
ÅÅ= K
(
ÅÅK L
)
ÅÅL M
;
ÅÅM N
if
ÉÉ 
(
ÉÉ 
jugadorA
ÉÉ 
!=
ÉÉ 
null
ÉÉ  $
&&
ÉÉ% '
jugadorB
ÉÉ( 0
!=
ÉÉ1 3
null
ÉÉ4 8
)
ÉÉ8 9
{
ÑÑ 
Amistad
ÖÖ 
amistad
ÖÖ #
=
ÖÖ$ %
new
ÖÖ& )
Amistad
ÖÖ* 1
{
ÜÜ 

IdJugadorA
áá "
=
áá# $
jugadorA
áá% -
.
áá- .
	IdJugador
áá. 7
,
áá7 8

IdJugadorB
àà "
=
àà# $
jugadorB
àà% -
.
àà- .
	IdJugador
àà. 7
}
ââ 
;
ââ 
contexto
ää 
.
ää 
Amistad
ää $
.
ää$ %
Add
ää% (
(
ää( )
amistad
ää) 0
)
ää0 1
;
ää1 2
	resultado
ãã 
=
ãã 
contexto
ãã  (
.
ãã( )
SaveChanges
ãã) 4
(
ãã4 5
)
ãã5 6
>
ãã7 8
$num
ãã9 :
;
ãã: ;
}
åå 
}
çç 
return
èè 
	resultado
èè 
;
èè 
}
êê 	
public
íí 
bool
íí +
EliminarAmistadEntreJugadores
íí 1
(
íí1 2
string
íí2 8
nombreJugadorA
íí9 G
,
ííG H
string
ííI O
nombreJugadorB
ííP ^
)
íí^ _
{
ìì 	
bool
îî 
	resultado
îî 
=
îî 
false
îî "
;
îî" #
using
ññ 
(
ññ 
var
ññ 
contexto
ññ 
=
ññ  !
new
ññ" %&
EntidadesRompecabezasFei
ññ& >
(
ññ> ?
)
ññ? @
)
ññ@ A
{
óó 
var
òò 
amistadObtenida
òò #
=
òò$ %
contexto
òò& .
.
òò. /
Amistad
òò/ 6
.
òò6 7
FirstOrDefault
òò7 E
(
òòE F
amistad
òòF M
=>
òòN P
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
nombreJugadorA
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
nombreJugadorB
öö: H
)
ööH I
||
ööJ L
amistad
õõ 
.
õõ 
JugadorA
õõ $
.
õõ$ %
NombreJugador
õõ% 2
.
õõ2 3
Equals
õõ3 9
(
õõ9 :
nombreJugadorB
õõ: H
)
õõH I
&&
õõJ L
amistad
úú 
.
úú 
JugadorB
úú $
.
úú$ %
NombreJugador
úú% 2
.
úú2 3
Equals
úú3 9
(
úú9 :
nombreJugadorA
úú: H
)
úúH I
)
úúI J
;
úúJ K
if
ûû 
(
ûû 
amistadObtenida
ûû #
!=
ûû$ &
null
ûû' +
)
ûû+ ,
{
üü 
contexto
†† 
.
†† 
Amistad
†† $
.
††$ %
Remove
††% +
(
††+ ,
amistadObtenida
††, ;
)
††; <
;
††< =
	resultado
°° 
=
°° 
contexto
°°  (
.
°°( )
SaveChanges
°°) 4
(
°°4 5
)
°°5 6
>
°°7 8
$num
°°9 :
;
°°: ;
}
¢¢ 
}
££ 
return
•• 
	resultado
•• 
;
•• 
}
¶¶ 	
public
®® 
bool
®® (
EliminarSolicitudDeAmistad
®® .
(
®®. /
string
®®/ 5!
nombreJugadorOrigen
®®6 I
,
®®I J
string
©© "
nombreJugadorDestino
©© '
)
©©' (
{
™™ 	
bool
´´ 
	resultado
´´ 
=
´´ 
false
´´ "
;
´´" #
using
≠≠ 
(
≠≠ 
var
≠≠ 
contexto
≠≠ 
=
≠≠  !
new
≠≠" %&
EntidadesRompecabezasFei
≠≠& >
(
≠≠> ?
)
≠≠? @
)
≠≠@ A
{
ÆÆ 
var
ØØ &
solicitudAmistadObtenida
ØØ ,
=
ØØ- .
contexto
ØØ/ 7
.
ØØ7 8
SolicitudAmistad
ØØ8 H
.
ØØH I
FirstOrDefault
∞∞ "
(
∞∞" #
	solicitud
∞∞# ,
=>
∞∞- /
	solicitud
±± 
.
±± 
JugadorOrigen
±± +
.
±±+ ,
NombreJugador
±±, 9
.
±±9 :
Equals
±±: @
(
±±@ A!
nombreJugadorOrigen
±±A T
)
±±T U
&&
±±V X
	solicitud
≤≤ 
.
≤≤ 
JugadorDestino
≤≤ ,
.
≤≤, -
NombreJugador
≤≤- :
.
≤≤: ;
Equals
≤≤; A
(
≤≤A B"
nombreJugadorDestino
≤≤B V
)
≤≤V W
)
≤≤W X
;
≤≤X Y
if
¥¥ 
(
¥¥ &
solicitudAmistadObtenida
¥¥ ,
!=
¥¥- /
null
¥¥0 4
)
¥¥4 5
{
µµ 
contexto
∂∂ 
.
∂∂ 
SolicitudAmistad
∂∂ -
.
∂∂- .
Remove
∂∂. 4
(
∂∂4 5&
solicitudAmistadObtenida
∂∂5 M
)
∂∂M N
;
∂∂N O
	resultado
∑∑ 
=
∑∑ 
contexto
∑∑  (
.
∑∑( )
SaveChanges
∑∑) 4
(
∑∑4 5
)
∑∑5 6
>
∑∑7 8
$num
∑∑9 :
;
∑∑: ;
}
∏∏ 
}
ππ 
return
ªª 
	resultado
ªª 
;
ªª 
}
ºº 	
public
ææ 
bool
ææ &
ExisteSolicitudDeAmistad
ææ ,
(
ææ, -
string
ææ- 3!
nombreJugadorOrigen
ææ4 G
,
ææG H
string
øø "
nombreJugadorDestino
øø '
)
øø' (
{
¿¿ 	
bool
¡¡ 
	resultado
¡¡ 
=
¡¡ 
false
¡¡ "
;
¡¡" #
using
√√ 
(
√√ 
var
√√ 
contexto
√√ 
=
√√  !
new
√√" %&
EntidadesRompecabezasFei
√√& >
(
√√> ?
)
√√? @
)
√√@ A
{
ƒƒ 
int
≈≈ 
coincidencias
≈≈ !
=
≈≈" #
(
≈≈$ %
from
≈≈% )
	solicitud
≈≈* 3
in
≈≈4 6
contexto
≈≈7 ?
.
≈≈? @
SolicitudAmistad
≈≈@ P
where
∆∆% *
	solicitud
∆∆+ 4
.
∆∆4 5
JugadorOrigen
∆∆5 B
.
∆∆B C
NombreJugador
∆∆C P
.
∆∆P Q
Equals
««% +
(
««+ ,!
nombreJugadorOrigen
««, ?
)
««? @
&&
««A C
	solicitud
»»% .
.
»». /
JugadorDestino
»»/ =
.
»»= >
NombreJugador
»»> K
.
»»K L
Equals
……% +
(
……+ ,"
nombreJugadorDestino
……, @
)
……@ A
select
  % +
	solicitud
  , 5
)
  5 6
.
  6 7
Count
  7 <
(
  < =
)
  = >
;
  > ?
if
ÃÃ 
(
ÃÃ 
coincidencias
ÃÃ !
>
ÃÃ" #
$num
ÃÃ$ %
)
ÃÃ% &
{
ÕÕ 
	resultado
ŒŒ 
=
ŒŒ 
true
ŒŒ  $
;
ŒŒ$ %
}
œœ 
}
–– 
return
““ 
	resultado
““ 
;
““ 
}
”” 	
public
’’ 
bool
’’ %
ExisteAmistadConJugador
’’ +
(
’’+ ,
string
’’, 2
nombreJugadorA
’’3 A
,
’’A B
string
’’C I
nombreJugadorB
’’J X
)
’’X Y
{
÷÷ 	
bool
◊◊ 
	resultado
◊◊ 
=
◊◊ 
false
◊◊ "
;
◊◊" #
using
ŸŸ 
(
ŸŸ 
var
ŸŸ 
contexto
ŸŸ 
=
ŸŸ  !
new
ŸŸ" %&
EntidadesRompecabezasFei
ŸŸ& >
(
ŸŸ> ?
)
ŸŸ? @
)
ŸŸ@ A
{
⁄⁄ 
int
€€ 
coincidencias
€€ !
=
€€" #
(
€€$ %
from
€€% )
amistad
€€* 1
in
€€2 4
contexto
€€5 =
.
€€= >
Amistad
€€> E
where
‹‹$ )
amistad
‹‹* 1
.
‹‹1 2
JugadorA
‹‹2 :
.
‹‹: ;
NombreJugador
‹‹; H
.
‹‹H I
Equals
››$ *
(
››* +
nombreJugadorA
››+ 9
)
››9 :
&&
››; =
amistad
ﬁﬁ$ +
.
ﬁﬁ+ ,
JugadorB
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
||
ﬂﬂ; =
amistad
‡‡$ +
.
‡‡+ ,
JugadorA
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
nombreJugadorB
··+ 9
)
··9 :
&&
··; =
amistad
‚‚$ +
.
‚‚+ ,
JugadorB
‚‚, 4
.
‚‚4 5
NombreJugador
‚‚5 B
.
‚‚B C
Equals
„„$ *
(
„„* +
nombreJugadorA
„„+ 9
)
„„9 :
select
‰‰$ *
amistad
‰‰+ 2
)
‰‰2 3
.
‰‰3 4
Count
‰‰4 9
(
‰‰9 :
)
‰‰: ;
;
‰‰; <
if
ÊÊ 
(
ÊÊ 
coincidencias
ÊÊ !
>
ÊÊ" #
$num
ÊÊ$ %
)
ÊÊ% &
{
ÁÁ 
	resultado
ËË 
=
ËË 
true
ËË  $
;
ËË$ %
}
ÈÈ 
}
ÍÍ 
return
ÏÏ 
	resultado
ÏÏ 
;
ÏÏ 
}
ÌÌ 	
}
ÓÓ 
}ÔÔ ‚"
mC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionPartida.cs
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
}@@ Ê
jC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\GestionSala.cs
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
}&& °
vC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\Properties\AssemblyInfo.cs
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
]$$) *≠*
gC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\Registro.cs
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
}KK å
cC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ServidorRompecabezasFei\Logica\Sala.cs
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
{ 
private

 
string

 

codigoSala

 !
;

! "
private 
string 
nombreAnfitrion &
;& '
private 
int %
contadorJugadoresActuales -
=. /
$num0 1
;1 2
public 
const 
int 
MaximoJugadores (
=) *
$num+ ,
;, -
public 
const 
int 
MinimoJugadores (
=) *
$num+ ,
;, -
private 
List 
< 
CuentaJugador "
>" #
	jugadores$ -
;- .
[ 	

DataMember	 
] 
public 
string 

CodigoSala  
{ 	
get 
{ 
return 

codigoSala #
;# $
}% &
set 
{ 

codigoSala 
= 
value $
;$ %
}& '
} 	
[ 	

DataMember	 
] 
public 
string 
NombreAnfitrion %
{ 	
get 
{ 
return 
nombreAnfitrion (
;( )
}* +
set 
{ 
nombreAnfitrion !
=" #
value$ )
;) *
}+ ,
} 	
[!! 	

DataMember!!	 
]!! 
public"" 
int"" %
ContadorJugadoresActuales"" ,
{## 	
get$$ 
{$$ 
return$$ %
contadorJugadoresActuales$$ 2
;$$2 3
}$$4 5
set%% 
{%% %
contadorJugadoresActuales%% +
=%%, -
value%%. 3
;%%3 4
}%%5 6
}&& 	
[(( 	

DataMember((	 
](( 
public)) 
List)) 
<)) 
CuentaJugador)) !
>))! "
	Jugadores))# ,
{** 	
get++ 
{++ 
return++ 
	jugadores++ "
;++" #
}++$ %
set,, 
{,, 
	jugadores,, 
=,, 
value,, #
;,,# $
},,% &
}-- 	
public11 
bool11 
ExisteCupoJugadores11 '
(11' (
)11( )
{22 	
return33 %
contadorJugadoresActuales33 ,
<33- .
MaximoJugadores33/ >
;33> ?
}44 	
public66 
bool66 
	EstaVacia66 
(66 
)66 
{77 	
return88 %
contadorJugadoresActuales88 ,
==88- /
$num880 1
;881 2
}99 	
};; 
}<< 