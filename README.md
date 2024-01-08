DOCUMENTATIE PROIECT
TINCU DIANA-CARLA

	Acest proiect are ca inspiratie "Mario" dar varianta 3D in Unity C# . Scopul este sa ajungi la finish, distrugand inamicii rosii si colectand banutii aurii.
	Functionalitati : 
	*Tasta Z: apropiere camera de caracter
	*Tasta X: rotirea la 360 de grade a camerei in jurul caracterului
  	*Tasta C: indepartarea camerei de caracter
    	* Tasta de sus : a merge inainte
	* Tasta de jos : a merge inapoi
  	*Tasta stanga : a merge in stanga
	*Tasta dreapta : a merge in dreapta
   	*Tasta space : pentru jumping
Cum omori inamicii : caracterul trebuie sa sara pe inamic astfel incat sa il omoare( obiectul inamic este distrus)
Cum iei banutii : cand caracterul si banutul fac coliziune, scorul de banuti va creste iar obiectul banut va fi distrus
Sunet : am adaugat sunete cand caracterul sare, moare si cand colecteaza banuti. Am mai adaugat si o melodie de fundal.
Meniu : exista 3 scene in joc : meniul de start( pentru a porni jocul) , jocul si meniul de sfarsit(butonul de quit are functionalitatea de a iesi de tot din joc)
Iluminare : cea ambientala este folosita la majoritatea obiectelor folosind materiale specifice din Unity
		cea speculara este folosita la banuti pentru efectul metalic
		cea difuza este folosita la podea ( cea pe care o paseste caracterul)

Transformari avansate:
	Oglindirea : este chiar la finish
	Scalare : inamicii din secunda in secunda se transforma
	Rotatie : Am folosit la camera( la functionalitati mai sus am scris cum functioneaza) si la banuti sa se tot invarta
	Translatie : caracterul merge, sare

Algoritmica :
SCRIPTURILE CARACTERULUI:
	PlayerMovement : aici caracterul merge sau sare( am implementat o regula ca sa poata sari doar o data cat timp nu este pe pamant)
	PlayerLife : uciderea caracterului ( daca face coliziune cu un inamic sau cade de pe pamant); cand moare, se asteapta o secunda pentru a se spawna inapoi in baza
	CoinCollecter: Cand caracterul face coliziune cu un banut, banutul va disparea iar scorul va creste

SCRIPTURILE INAMICULUI: 
	WayPointFollower : Am vrut ca inamicul sa se miste stanga dreapta, fixand pozitii de unde pana unde sa se duca. In metoda RandomScale() a specificat ca doar obiectele cu tagul "Enemy" sa se scaleze random din secunda in secunda.

SCRIPTURILE PAMANTULUI:
	WayPointFollower : este folosita doar la podeaua a patra ( singura care se misca) - exact ca la inamic, de aia am specificat in acea metoda ca doar obiectele cu tagul "Enemy" sa se scaleze random.
	StickyFloor: in momentul cand caracaterul calca pe podeaua care se misca, sa fie in aceeasi pozitie cu podeaua cat timp se misca

SCRIPTURILE BANUTULUI:
	Rotate : pentru a roti banutii

SCRIPTURILE PERETELUI:
	Finish : pentru a termina jocul, de a schimba din interfata game in cea de ending.

SCRIPTURILE INTERFETEI DE START:
	StartMenu : de a schimba interfata de start in cea de joc

SCRIPTURILE CAMEREI(DIN INTERFATA DE JOC)
	RotatingTheCamera : pentru a invarti in jurul caracterului, zoom in si zoom out. 
  		
