™
nC:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Servidor\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str #
)# $
]$ %
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
$str %
)% &
]& '
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
]$$) *’
_C:\Users\samue\OneDrive\Escritorio\RompecabezasFEI\ServidorRompecabezasFei\Servidor\Servidor.cs
	namespace 	
Servidor
 
{ 
public 

static 
class 
Servidor  
{ 
public		 
static		 
void		 
Main		 
(		  
string		  &
[		& '
]		' (
args		) -
)		- .
{

 	
using 
( 
ServiceHost #
servidorRompecabezasFei 6
=7 8
new 
ServiceHost 
(  
typeof  &
(& '#
ServicioRompecabezasFei' >
)> ?
)? @
)@ A
{ 
try 
{ #
servidorRompecabezasFei +
.+ ,
Open, 0
(0 1
)1 2
;2 3
Console 
. 
	WriteLine %
(% &
$str& 9
)9 :
;: ;
} 
catch 
( (
AddressAccessDeniedException 3
)3 4
{ 
Console 
. 
	WriteLine %
(% &
$str& <
)< =
;= >
} 
Console 
. 
ReadLine  
(  !
)! "
;" #
} 
} 	
} 
} 