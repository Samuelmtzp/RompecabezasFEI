¿
ZC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Celda.cs
	namespace 	
Dominio
 
{ 
public 

class 
Celda 
{ 
public 
	Rectangle 
Area 
{ 
get  #
;# $
set% (
;( )
}* +
public		 
int		 
Fila		 
{		 
get		 
;		 
set		 "
;		" #
}		$ %
public 
int 
Columna 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ∆
bC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\CuentaJugador.cs
	namespace 	
Dominio
 
{ 
public 

class 
CuentaJugador 
{ 
public 
string 
NombreJugador #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public

 
int

 
NumeroAvatar

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
string 
Correo 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 

Contrasena  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 

EsInvitado 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int 
Puntaje 
{ 
get  
;  !
set" %
;% &
}' (
public 
SolidColorBrush #
ColorEstadoConectividad 6
{7 8
get9 <
;< =
set> A
;A B
}C D
public 
BitmapImage 
FuenteImagenAvatar -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
public 
static 
CuentaJugador #
Actual$ *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
} 
} Ω
_C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Dificultad.cs
	namespace 	
Dominio
 
{ 
public 

enum 

Dificultad 
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
}		 Ç
[C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Idioma.cs
	namespace 	
Dominio
 
{ 
public 

enum 
Idioma 
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
} Ê
gC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\ImagenRompecabezas.cs
	namespace 	
Dominio
 
{ 
public 

class 
ImagenRompecabezas #
{ 
public 
string 
Ruta 
{ 
get  
;  !
set" %
;% &
}' (
public		 
Color		 
ColorDeBorde		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public 
int 
NumeroImagen 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} €(
ZC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Pieza.cs
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
 
Border

 
borde

 
;

 
private 
bool 
estaDentroDeCelda &
;& '
public 
double 
Ancho 
{ 
get !
;! "
set# &
;& '
}( )
public 
double 
Alto 
{ 
get  
;  !
set" %
;% &
}' (
public 
Image 
Imagen 
{ 
get !
;! "
set# &
;& '
}( )
public 
Border 
Borde 
{ 	
get 
{ 
return 
borde 
; 
}  !
set 
{ 
borde 
= 
value 
; 
borde 
. 
Child 
= 
Imagen $
;$ %
} 
} 	
public 
bool 
EstaDentroDeCelda %
{ 	
get 
{ 
return 
estaDentroDeCelda *
;* +
}, -
set   
{!! 
estaDentroDeCelda"" !
=""" #
value""$ )
;"") *
if$$ 
($$ 
estaDentroDeCelda$$ %
)$$% &
{%% 0
$EstablecerEstiloDePiezaDentroDeCelda&& 8
(&&8 9
)&&9 :
;&&: ;
}'' 
}(( 
})) 	
public++ 
int++ 
FilaCorrecta++ 
{++  !
get++" %
;++% &
set++' *
;++* +
}++, -
public-- 
int-- 
ColumnaCorrecta-- "
{--# $
get--% (
;--( )
set--* -
;--- .
}--/ 0
public// 
CroppedBitmap// !
FuenteImagenRecortada// 2
{//3 4
get//5 8
;//8 9
set//: =
;//= >
}//? @
public11 
void11 "
EstablecerFuenteImagen11 *
(11* +
BitmapImage11+ 6 
fuenteImagenOriginal117 K
,11K L
	Int32Rect22 
areaRecorte22 !
)22! "
{33 	!
FuenteImagenRecortada44 !
=44" #
new44$ '
CroppedBitmap44( 5
(445 6 
fuenteImagenOriginal446 J
,44J K
areaRecorte44L W
)44W X
;44X Y
Imagen55 
=55 
new55 
Image55 
{66 
Source77 
=77 !
FuenteImagenRecortada77 .
,77. /
Width88 
=88 
Ancho88 
,88 
Height99 
=99 
Alto99 
,99 
}:: 
;:: 
};; 	
public== 
double== 3
'ObtenerDiferenciaAnchoEntreImagenYBorde== =
(=== >
)==> ?
{>> 	
return?? 
borde?? 
.?? 
ActualWidth?? $
-??% &
Imagen??' -
.??- .
Width??. 3
;??3 4
}@@ 	
publicBB 
doubleBB 4
(ObtenerDiferenciaAlturaEntreImagenYBordeBB >
(BB> ?
)BB? @
{CC 	
returnDD 
bordeDD 
.DD 
ActualHeightDD %
-DD& '
ImagenDD( .
.DD. /
HeightDD/ 5
;DD5 6
}EE 	
publicGG 
voidGG /
#EstablecerEstiloDePiezaSeleccionadaGG 7
(GG7 8
)GG8 9
{HH 	
bordeII 
.II 
BorderBrushII 
=II 
BrushesII  '
.II' (
RedII( +
;II+ ,
bordeJJ 
.JJ 
BorderThicknessJJ !
=JJ" #
newJJ$ '
	ThicknessJJ( 1
(JJ1 2
$numJJ2 3
)JJ3 4
;JJ4 5
}KK 	
publicMM 
voidMM 1
%EstablecerEstiloDePiezaSinSeleccionarMM 9
(MM9 :
)MM: ;
{NN 	
bordeOO 
.OO 
BorderBrushOO 
=OO 
BrushesOO  '
.OO' (
WhiteOO( -
;OO- .
bordePP 
.PP 
BorderThicknessPP !
=PP" #
newPP$ '
	ThicknessPP( 1
(PP1 2
$numPP2 3
)PP3 4
;PP4 5
}QQ 	
privateSS 
voidSS 0
$EstablecerEstiloDePiezaDentroDeCeldaSS 9
(SS9 :
)SS: ;
{TT 	
bordeUU 
.UU 
BorderBrushUU 
=UU 
BrushesUU  '
.UU' (
TransparentUU( 3
;UU3 4
bordeVV 
.VV 
BorderThicknessVV !
=VV" #
newVV$ '
	ThicknessVV( 1
(VV1 2
$numVV2 3
)VV3 4
;VV4 5
}WW 	
}XX 
}YY ó
lC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Properties\AssemblyInfo.cs
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
]$$) *ê
\C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ClienteRompecabezasFei\Dominio\Tablero.cs
	namespace 	
Dominio
 
{ 
public 

class 
Tablero 
{ 
private 

Dificultad 

dificultad %
;% &
public

 
double

 
AnchoDeCelda

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
public 
double 
AlturaDeCelda #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 

TotalFilas 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
TotalColumnas  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
int $
NumeroImagenRompecabezas +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
List 
< 
Pieza 
> 
Piezas !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
List 
< 
Celda 
> 
Celdas !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 

Dificultad 

Dificultad $
{ 	
get 
{ 
return 

dificultad #
;# $
}% &
set 
{ 

dificultad 
= 
value "
;" #
switch 
( 

dificultad "
)" #
{   
case!! 

Dificultad!! #
.!!# $
Facil!!$ )
:!!) *

TotalFilas"" "
=""# $
$num""% &
;""& '
TotalColumnas## %
=##& '
$num##( *
;##* +
break$$ 
;$$ 
case%% 

Dificultad%% #
.%%# $
Medio%%$ )
:%%) *

TotalFilas&& "
=&&# $
$num&&% &
;&&& '
TotalColumnas'' %
=''& '
$num''( *
;''* +
break(( 
;(( 
case)) 

Dificultad)) #
.))# $
Dificil))$ +
:))+ ,

TotalFilas** "
=**# $
$num**% '
;**' (
TotalColumnas++ %
=++& '
$num++( *
;++* +
break,, 
;,, 
}-- 
}.. 
}// 	
public11 
bool11 $
EsRompecabezasCompletado11 ,
(11, -
)11- .
{22 	
bool33 
	resultado33 
=33 
false33 "
;33" #
var44 
piezasSinAcomodar44 !
=44" #
from44$ (
pieza44) .
in44/ 1
Piezas442 8
where55$ )
!55* +
pieza55+ 0
.550 1
EstaDentroDeCelda551 B
select66$ *
pieza66+ 0
;660 1
if88 
(88 
piezasSinAcomodar88 !
.88! "
Any88" %
(88% &
)88& '
)88' (
{99 
	resultado:: 
=:: 
true::  
;::  !
};; 
return== 
	resultado== 
;== 
}>> 	
}?? 
}@@ 