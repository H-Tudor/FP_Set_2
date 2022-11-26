using FP_Set_2;

internal class Program {
	private static void Main(string[] args) {
		Console.WriteLine("Optiuni:\n" +
			"\t1.Numarul de numere pare\n" +
			"\t2.Numarul de numere negative, nule si pozitive\n" +
			"\t3.Suma si produsul numerelor de la 1 la n\n" +
			"\t4.Pozitia din secventa a numarului a\n" +
			"\t5.Numarul de elemente egale cu pozitia lor\n" +
			"\t6.Verificare ordine crescatoare\n" +
			"\t7.Minimul si Maximul dintr-o secventa\n" +
			"\t8.Al n numar din sirul lui Fibonaci\n" +
			"\t9.Secventa monotona\n" +
			"\t10.Maximul de numere consecutive egale din secventa\n" +
			"\t11.Suma inverselor acestora\n" +
			"\t12.Numarul de grupuri de numere consecutive egale nenule din secventa\n" +
			"\t13.Secventa crescatoare rotita\n" +
			"\t14.Secventa monotona rotita\n" +
			"\t15.Secventa bitonica\n" +
			"\t16.Secventa bitonica rotita\n" +
			"\t17.Secventa de paranteze(1/0)\n");
		bool ok = true;
		while(ok) {
			int opt = Helpers.IntInput("Problema selectata: ");
			switch(opt) {
				case 1: P1(); break;
				case 2: P2(); break;
				case 3: P3(); break;
				case 4: P4(); break;
				case 5: P5(); break;
				case 6: P6(); break;
				case 7: P7(); break;
				case 8: P8(); break;
				case 9: P9(); break;
				case 10: P10(); break;
				case 11: P11(); break;
				case 12: P12(); break;
				case 13: P13(); break;
				case 14: P14(); break;
				case 15: P15(); break;
				case 16: P16(); break;
				case 17: P17(); break;
				case int.MinValue: Console.WriteLine("Invalid Problem number, exiting program..."); ok = false; break;
			}
		}
	}

	private static void P1() {
		Console.WriteLine("Enter Seqence:");
		int x = Helpers.IntInput("");
		int c = 0;
		while(x != int.MinValue) {
			if(x % 2 == 0) c++;
			x = Helpers.IntInput("");
		}

		Console.WriteLine($"{c} numere pare");
	}

	private static void P2() {
		Console.WriteLine("Enter Seqence:");
		int x = Helpers.IntInput("");
		int n = 0, z = 0, p = 0;
		while(x != int.MinValue) {
			if(x < 0) n++;
			else if(x == 0) z++;
			else p++;
			x = Helpers.IntInput("");
		}

		Console.WriteLine($"{n} numere negative; {z} de 0; {p} numere pozitive");
	}

	private static void P3() {
		int n = Helpers.IntInput("Dati n: ");
		uint s = 0;
		ulong p = 1;

		for(uint i = 1; i <= n; i++) {
			s += i;
			//S-ar putea sa crape fiindca n! ii enorm...
			p *= i;
		}

		Console.WriteLine($"Suma numerelor de la 1 la {n}: {s}\nProdusul numerelor de la 1 la {n}: {p}");
	}

	private static void P4() {
		int a = 0, k = -1, i = 0;
		a = Helpers.IntInput("Dati a: ");
		Console.WriteLine("Dati secventa:");
		int x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(x == a) { k = i; break; }
			i++;
			x = Helpers.IntInput("");
		}

		Console.WriteLine($"Numarul {a} se afla pe pozitia {k}");
	}

	private static void P5() {
		int x, i = 0, c = 0;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(x == i) c++;
			i++;
			x = Helpers.IntInput("");
		}

		Console.WriteLine($"{c} numere sunt egale cu pozitia lor");
	}

	private static void P6() {
		int x, i = 0, l = 0;
		bool ok = true;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(i >= 1 && l > x) ok = false;
			i++;
			l = x;
			x = Helpers.IntInput("");
		}

		if(ok) Console.WriteLine("Numerele sunt in ordne crescatoare");
		else Console.WriteLine("Numerele nu sunt in ordne crescatoare");
	}

	private static void P7() {
		int x, max = int.MinValue, min = int.MaxValue;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(x < min) min = x;
			else if(x > max) max = x;
			x = Helpers.IntInput("");
		}

		Console.WriteLine($"Max value: {max}; Min value: {min}");
	}

	private static void P8() {
		int n = Helpers.IntInput("Enter n: ");
		ulong f1 = 0, f2 = 1, fc = 0;
		if(n < 1) { fc = 0; } else if(n == 1) { fc = f1; } else if(n == 2) { fc = f2; } else {
			for(int i = 1; i <= n - 2; i++) {
				fc = f1 + f2;
				f1 = f2;
				f2 = fc;
			}
		}
		Console.WriteLine($"Numarul {n} din sirul lui Fibonacci este {fc}");
	}

	private static void P9() {
		int x, i = 0, l = 0;
		bool ok1 = true, ok2 = true;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(i >= 1 && l >= x) ok1 = false;
			if(i >= 1 && l <= x) ok2 = false;
			i++;
			l = x;
			x = Helpers.IntInput("");
		}
		if(ok1 || ok2) Console.WriteLine("Secventa este monotona");
		else Console.WriteLine("Secventa nu este monotona");
	}

	private static void P10() {
		int x, i = 1, l = 0, c = 0;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			while(x == l) {
				i++;
				l = x;
				x = Helpers.IntInput("");
			}
			if(i > c) c = i;
			i = 1;
			l = x;
			x = Helpers.IntInput("");
		}
		Console.WriteLine($"Numarul maxim de numere consecutive din secventa este {c}");
	}

	private static void P11() {
		int x, invX = 0, s = 0;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			while(x != 0) {
				invX = invX * 10 + x % 10;
				x /= 10;
			}

			s += invX;
			x = Helpers.IntInput("");
		}
		Console.WriteLine($"Suma inverselor numerelor din secventa este {s}");
	}

	private static void P12() {
		int x, i = 1, l = 0, c = 1;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(x == 0 && l != 0) { c++; i = 1; }
			if(x != 1 && x == l) i++;
			l = x;
			x = Helpers.IntInput("");
		}
		Console.WriteLine($"Numarul de grupuri de numere consecutive nenule din secventa de {c}");
	}

	private static void P13() {
		int x, i = 0, l = 0, max = int.MinValue, min;
		bool ok1 = true, ok2 = true;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		min = x;
		while(x != int.MinValue) {
			if(i >= 1 && l > x && ok1 == true) {
				ok1 = false;
				max = l; min = x;
			} else if(ok1 == false && (x > max || x < min)) {
				ok2 = false;
			}

			i++;
			l = x;
			x = Helpers.IntInput("");
		}

		if(ok2) Console.WriteLine("Secventa rotita este crescatoare");
		else Console.WriteLine("Secventa rotita nu este crescatoare");
	}

	private static void P14() {
		int x, i = 0, l = 0, max1 = int.MinValue, min1, max2, min2 = int.MaxValue;
		bool ok1 = true, ok2 = true, ok3 = true, ok4 = true;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		min1 = max2 = x;
		while(x != int.MinValue) {
			if(i >= 1 && l > x && ok1 == true) {
				ok1 = false;
				max1 = l; min1 = x;
			} else if(ok1 == false && (x > max1 || x < min1)) {
				ok2 = false;
			}

			if(i >= 1 && l < x && ok3 == true) {
				ok3 = false;
				min2 = l; max2 = x;
			} else if(ok3 == false && (x < min2 || x > max2)) {
				ok4 = false;
			}

			i++;
			l = x;
			x = Helpers.IntInput("");
		}

		if(ok2) Console.WriteLine("Secventa rotita este crescatoare");
		else if(ok4) Console.WriteLine("Secventa rotita este descrescatoare");
		else Console.WriteLine("Secventa rotita nu este monotona");
	}

	private static void P15() {
		int x, i = 0, l = 0;
		bool ok1 = true, ok2 = false;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		while(x != int.MinValue) {
			if(ok1) if(i >= 1 && l >= x) { ok1 = false; ok2 = true; } else if(i >= 1 && l <= x) ok2 = false;
			i++;
			l = x;
			x = Helpers.IntInput("");
		}
		if(ok2) Console.WriteLine("Secventa este bitonica");
		else Console.WriteLine("Secventa nu este bitonica");
	}

	private static void P16() {
		int x, i = 0, l = 0, max1 = int.MinValue, min1, max2, min2 = int.MaxValue;
		bool ok1 = true, ok2 = true, ok3 = true, ok4 = false;
		Console.WriteLine("Dati secventa:");
		x = Helpers.IntInput("");
		min1 = max2 = x;
		while(x != int.MinValue) {
			if(ok2 == true) {
				if(i >= 1 && l > x && ok1 == true) {
					ok1 = false;
					max1 = l; min1 = x;
				} else if(ok1 == false && (x > max1 || x < min1)) {
					ok2 = false; ok4 = true;
				}
			} else {
				if(i >= 1 && l < x && ok3 == true) {
					ok3 = false;
					min2 = l; max2 = x;
				} else if(ok3 == false && (x < min2 || x > max2)) {
					ok4 = false;
				}
			}

			i++;
			l = x;
			x = Helpers.IntInput("");
		}

		if(ok4) Console.WriteLine("Secventa rotita este bitonica");
		else Console.WriteLine("Secventa rotita nu este bitonica");
	}

	private static void P17() {
		Console.WriteLine("Enter Seqence:");
		int x = Helpers.IntInput("");
		int c1 = 0, c2 = 0;
		bool ok = false;
		while(x != int.MinValue) {
			if(x == 1) c1++;
			x = Helpers.IntInput("");
		}
		if(c1 % 2 == 0) {
			ok = true; c2 = c1 / 2;
		}
		if(ok) Console.WriteLine($"Secventa valida, grad de incuibare: {c2}");
		else Console.WriteLine("Secventa invalida");
	}
}

/*
Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
Calculati suma si produsul numerelor de la 1 la n. 
Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
 
 
 
 
 */