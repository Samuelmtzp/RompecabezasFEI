

dC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Celda.cs
	namespace 	
Dominio
 
{ 
public 

class 
Celda 
{ 
private 
	Rectangle 
area 
; 
private 
int 
fila 
; 
private		 
int		 
columna		 
;		 
public 
	Rectangle 
Area 
{ 	
get 
{ 
return 
area 
; 
}  
set 
{ 
area 
= 
value 
; 
}  !
} 	
public 
int 
Fila 
{ 	
get 
{ 
return 
fila 
; 
}  
set 
{ 
fila 
= 
value 
; 
}  !
} 	
public 
int 
Columna 
{ 	
get 
{ 
return 
columna  
;  !
}" #
set 
{ 
columna 
= 
value !
;! "
}# $
} 	
} 
} «
lC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\CuentaJugador.cs
	namespace 	
Dominio
 
{ 
public 

class 
CuentaJugador 
{ 
private		 
string		 
nombreJugador		 $
;		$ %
private

 
int

 
numeroAvatar

  
;

  !
private 
string 
correo 
; 
private 
string 

contrasena !
;! "
private 
bool 

esInvitado 
;  
private 
SolidColorBrush #
colorEstadoConectividad  7
;7 8
private 
BitmapImage 
fuenteImagenAvatar .
;. /
private 
int 
puntaje 
; 
private 
static 
CuentaJugador $
cuentaJugadorActual% 8
;8 9
public 
string 
NombreJugador #
{ 	
get 
{ 
return 
nombreJugador &
;& '
}( )
set 
{ 
nombreJugador 
=  !
value" '
;' (
}) *
} 	
public 
int 
NumeroAvatar 
{ 	
get 
{ 
return 
numeroAvatar %
;% &
}' (
set 
{ 
numeroAvatar 
=  
value! &
;& '
}( )
}   	
public"" 
string"" 
Correo"" 
{## 	
get$$ 
{$$ 
return$$ 
correo$$ 
;$$  
}$$! "
set%% 
{%% 
correo%% 
=%% 
value%%  
;%%  !
}%%" #
}&& 	
public(( 
string(( 

Contrasena((  
{)) 	
get** 
{** 
return** 

contrasena** #
;**# $
}**% &
set++ 
{++ 

contrasena++ 
=++ 
value++ $
;++$ %
}++& '
},, 	
public.. 
bool.. 

EsInvitado.. 
{// 	
get00 
{00 
return00 

esInvitado00 #
;00# $
}00% &
set11 
{11 

esInvitado11 
=11 
value11 $
;11$ %
}11& '
}22 	
public44 
int44 
Puntaje44 
{55 	
get66 
{66 
return66 
puntaje66  
;66  !
}66" #
set77 
{77 
puntaje77 
=77 
value77 !
;77! "
}77# $
}88 	
public:: 
SolidColorBrush:: #
ColorEstadoConectividad:: 6
{;; 	
get<< 
{<< 
return<< #
colorEstadoConectividad<< 0
;<<0 1
}<<2 3
set== 
{== #
colorEstadoConectividad== )
===* +
value==, 1
;==1 2
}==3 4
}>> 	
public@@ 
BitmapImage@@ 
FuenteImagenAvatar@@ -
{AA 	
getBB 
{BB 
returnBB 
fuenteImagenAvatarBB +
;BB+ ,
}BB- .
setCC 
{CC 
fuenteImagenAvatarCC $
=CC% &
valueCC' ,
;CC, -
}CC. /
}DD 	
publicFF 
staticFF 
CuentaJugadorFF #
ActualFF$ *
{GG 	
getHH 
{HH 
returnHH 
cuentaJugadorActualHH ,
;HH, -
}HH. /
setII 
{II 
cuentaJugadorActualII %
=II& '
valueII( -
;II- .
}II/ 0
}JJ 	
}LL 
}MM Á
iC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Dificultad.cs
	namespace 	
Dominio
 
{ 
public 

enum 

Dificultad 
: 
int  
{ 
Facil 
= 
$num 
, 
Medio 
= 
$num 
, 
Dificil 
= 
$num 
} 
}		 ¨
eC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Idioma.cs
	namespace 	
Dominio
 
{ 
public 

enum 
Idioma 
: 
int 
{ 
Ingles 
= 
$num 
, 
Espanol 
= 
$num 
, 
} 
} º
qC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\ImagenRompecabezas.cs
	namespace 	
Dominio
 
{ 
public 

class 
ImagenRompecabezas #
{ 
private 
string 
ruta 
; 
private 
Color 
colorDeBorde "
;" #
private		 
int		 
numeroImagen		  
;		  !
public 
string 
Ruta 
{ 	
get 
{ 
return 
ruta 
; 
}  
set 
{ 
ruta 
= 
value 
; 
}  !
} 	
public 
Color 
ColorDeBorde !
{ 	
get 
{ 
return 
colorDeBorde %
;% &
}' (
set 
{ 
colorDeBorde 
=  
value! &
;& '
}( )
} 	
public 
int 
NumeroImagen 
{ 	
get 
{ 
return 
numeroImagen %
;% &
}' (
set 
{ 
numeroImagen 
=  
value! &
;& '
}( )
} 	
} 
} ù1
dC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Pieza.cs
	namespace 	
Dominio
 
{ 
public 

class 
Pieza 
: 
	UIElement "
{		 
private

 
Image

 
imagen

 
;

 
private 
Border 
borde 
; 
private 
double 
ancho 
; 
private 
double 
alto 
; 
private 
bool 
estaDentroDeCelda &
;& '
private 
int 
filaCorrecta  
;  !
private 
int 
columnaCorrecta #
;# $
CroppedBitmap !
fuenteImagenRecortada +
;+ ,
public 
Image 
Imagen 
{ 	
get 
{ 
return 
imagen 
;  
}! "
set 
{ 
imagen 
= 
value  
;  !
}" #
} 	
public 
Border 
Borde 
{ 	
get 
{ 
return 
borde 
; 
}  !
set 
{ 
borde 
= 
value 
; 
borde 
. 
Child 
= 
imagen $
;$ %
}   
}!! 	
public## 
double## 
Ancho## 
{$$ 	
get%% 
{%% 
return%% 
ancho%% 
;%% 
}%%  !
set&& 
{&& 
ancho&& 
=&& 
value&& 
;&&  
}&&! "
}'' 	
public)) 
double)) 
Alto)) 
{** 	
get++ 
{++ 
return++ 
alto++ 
;++ 
}++  
set,, 
{,, 
alto,, 
=,, 
value,, 
;,, 
},,  !
}-- 	
public// 
bool// 
EstaDentroDeCelda// %
{00 	
get11 
{11 
return11 
estaDentroDeCelda11 *
;11* +
}11, -
set22 
{33 
estaDentroDeCelda44 !
=44" #
value44$ )
;44) *
if55 
(55 
estaDentroDeCelda55 %
)55% &
{66 0
$EstablecerEstiloDePiezaDentroDeCelda77 8
(778 9
)779 :
;77: ;
}88 
}99 
}:: 	
public<< 
int<< 
FilaCorrecta<< 
{== 	
get>> 
{>> 
return>> 
filaCorrecta>> %
;>>% &
}>>' (
set?? 
{?? 
filaCorrecta?? 
=??  
value??! &
;??& '
}??( )
}@@ 	
publicBB 
intBB 
ColumnaCorrectaBB "
{CC 	
getDD 
{DD 
returnDD 
columnaCorrectaDD (
;DD( )
}DD* +
setEE 
{EE 
columnaCorrectaEE !
=EE" #
valueEE$ )
;EE) *
}EE+ ,
}FF 	
publicHH 
voidHH "
EstablecerFuenteImagenHH *
(HH* +
BitmapImageHH+ 6 
fuenteImagenOriginalHH7 K
,HHK L
	Int32RectII 
areaRecorteII !
)II! "
{JJ 	!
fuenteImagenRecortadaKK !
=KK" #
newKK$ '
CroppedBitmapKK( 5
(KK5 6 
fuenteImagenOriginalKK6 J
,KKJ K
areaRecorteKKL W
)KKW X
;KKX Y
imagenLL 
=LL 
newLL 
ImageLL 
{MM 
SourceNN 
=NN !
fuenteImagenRecortadaNN .
,NN. /
WidthOO 
=OO 
anchoOO 
,OO 
HeightPP 
=PP 
altoPP 
,PP 
}QQ 
;QQ 
}RR 	
publicTT 
doubleTT 3
'ObtenerDiferenciaAnchoEntreImagenYBordeTT =
(TT= >
)TT> ?
{UU 	
returnVV 
BordeVV 
.VV 
ActualWidthVV $
-VV% &
ImagenVV' -
.VV- .
WidthVV. 3
;VV3 4
}WW 	
publicYY 
doubleYY 4
(ObtenerDiferenciaAlturaEntreImagenYBordeYY >
(YY> ?
)YY? @
{ZZ 	
return[[ 
Borde[[ 
.[[ 
ActualHeight[[ %
-[[& '
Imagen[[( .
.[[. /
Height[[/ 5
;[[5 6
}\\ 	
public^^ 
void^^ /
#EstablecerEstiloDePiezaSeleccionada^^ 7
(^^7 8
)^^8 9
{__ 	
borde`` 
.`` 
BorderBrush`` 
=`` 
Brushes``  '
.``' (
Red``( +
;``+ ,
bordeaa 
.aa 
BorderThicknessaa !
=aa" #
newaa$ '
	Thicknessaa( 1
(aa1 2
$numaa2 3
)aa3 4
;aa4 5
}bb 	
publicdd 
voiddd 1
%EstablecerEstiloDePiezaSinSeleccionardd 9
(dd9 :
)dd: ;
{ee 	
bordeff 
.ff 
BorderBrushff 
=ff 
Brushesff  '
.ff' (
Whiteff( -
;ff- .
bordegg 
.gg 
BorderThicknessgg !
=gg" #
newgg$ '
	Thicknessgg( 1
(gg1 2
$numgg2 3
)gg3 4
;gg4 5
}hh 	
privatejj 
voidjj 0
$EstablecerEstiloDePiezaDentroDeCeldajj 9
(jj9 :
)jj: ;
{kk 	
bordell 
.ll 
BorderBrushll 
=ll 
Brushesll  '
.ll' (
Transparentll( 3
;ll3 4
bordemm 
.mm 
BorderThicknessmm !
=mm" #
newmm$ '
	Thicknessmm( 1
(mm1 2
$nummm2 3
)mm3 4
;mm4 5
}nn 	
}oo 
}pp °
vC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str "
)" #
]# $
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
$str $
)$ %
]% &
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
]$$) *á+
fC:\Users\king_\Documents\ProyectoTecnologias\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Tablero.cs
	namespace 	
Dominio
 
{ 
public 

class 
Tablero 
{ 
private 
double 
anchoDeCelda #
;# $
private		 
double		 
alturaDeCelda		 $
;		$ %
private

 
int

 

totalFilas

 
;

 
private 
int 
totalColumnas !
;! "
private 
int $
numeroImagenRompecabezas ,
;, -
private 

Dificultad 

dificultad %
;% &
private 
List 
< 
Pieza 
> 
piezas "
;" #
private 
List 
< 
Celda 
> 
celdas "
;" #
public 
double 
AnchoDeCelda "
{ 	
get 
{ 
return 
anchoDeCelda %
;% &
}' (
set 
{ 
anchoDeCelda 
=  
value! &
;& '
}( )
} 	
public 
double 
AlturaDeCelda #
{ 	
get 
{ 
return 
alturaDeCelda &
;& '
}( )
set 
{ 
alturaDeCelda 
=  !
value" '
;' (
}) *
} 	
public 
int 

TotalFilas 
{ 	
get 
{ 
return 

totalFilas #
;# $
}% &
set   
{   

totalFilas   
=   
value   $
;  $ %
}  & '
}!! 	
public## 
int## 
TotalColumnas##  
{$$ 	
get%% 
{%% 
return%% 
totalColumnas%% &
;%%& '
}%%( )
set&& 
{&& 
totalColumnas&& 
=&&  !
value&&" '
;&&' (
}&&) *
}'' 	
public)) 
int)) $
NumeroImagenRompecabezas)) +
{** 	
get++ 
{++ 
return++ $
numeroImagenRompecabezas++ 1
;++1 2
}++3 4
set,, 
{,, $
numeroImagenRompecabezas,, *
=,,+ ,
value,,- 2
;,,2 3
},,4 5
}-- 	
public// 

Dificultad// 

Dificultad// $
{00 	
get11 
{11 
return11 

dificultad11 #
;11# $
}11% &
set22 
{33 

dificultad44 
=44 
value44 "
;44" #
switch66 
(66 

dificultad66 "
)66" #
{77 
case88 

Dificultad88 #
.88# $
Facil88$ )
:88) *

totalFilas99 "
=99# $
$num99% &
;99& '
totalColumnas:: %
=::& '
$num::( *
;::* +
break;; 
;;; 
case<< 

Dificultad<< #
.<<# $
Medio<<$ )
:<<) *

totalFilas== "
===# $
$num==% &
;==& '
totalColumnas>> %
=>>& '
$num>>( *
;>>* +
break?? 
;?? 
case@@ 

Dificultad@@ #
.@@# $
Dificil@@$ +
:@@+ ,

totalFilasAA "
=AA# $
$numAA% '
;AA' (
totalColumnasBB %
=BB& '
$numBB( *
;BB* +
breakCC 
;CC 
}DD 
}EE 
}FF 	
publicHH 
ListHH 
<HH 
PiezaHH 
>HH 
PiezasHH !
{II 	
getJJ 
{JJ 
returnJJ 
piezasJJ 
;JJ  
}JJ! "
setKK 
{KK 
piezasKK 
=KK 
valueKK  
;KK  !
}KK" #
}LL 	
publicNN 
ListNN 
<NN 
CeldaNN 
>NN 
CeldasNN !
{OO 	
getPP 
{PP 
returnPP 
celdasPP 
;PP  
}PP! "
setQQ 
{QQ 
celdasQQ 
=QQ 
valueQQ  
;QQ  !
}QQ" #
}RR 	
publicTT 
boolTT $
EsRompecabezasCompletadoTT ,
(TT, -
)TT- .
{UU 	
boolVV 
esJuegoCompletadoVV "
=VV# $
falseVV% *
;VV* +
varWW 
piezasSinAcomodarWW !
=WW" #
fromWW$ (
piezaWW) .
inWW/ 1
piezasWW2 8
whereXX$ )
piezaXX* /
.XX/ 0
EstaDentroDeCeldaXX0 A
==XXB D
falseXXE J
selectYY$ *
piezaYY+ 0
;YY0 1
if[[ 
([[ 
piezasSinAcomodar[[ !
.[[! "
Count[[" '
([[' (
)[[( )
==[[* ,
$num[[- .
)[[. /
{\\ 
esJuegoCompletado]] !
=]]" #
true]]$ (
;]]( )
}^^ 
return`` 
esJuegoCompletado`` $
;``$ %
}aa 	
}bb 
}cc 