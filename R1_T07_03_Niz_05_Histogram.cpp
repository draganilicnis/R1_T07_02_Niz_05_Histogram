#include <iostream>
#include <iomanip>
#include <vector>
#include <cmath>

using namespace std;

int main() {
  // ucitavamo granice intervala
  double a, b;
  cin >> a >> b;
  // ucitavamo broj podeoka
  int n;
  cin >> n;

  // izracunavamo sirinu jednog podeoka
  double d = (b - a) / n;

  // histogram cuva broj tacaka u svakom podeoku
  vector<int> histogram(n, 0);

  // ucitavamo ukupan broj tacaka
  int k;
  cin >> k;
  for (int i = 0; i < k; i++) {
    // ucitavamo sledecu tacku
    double x;
    cin >> x;
    // odredjujemo podeok kojem ona pripada
    int podeok = (int)floor((x - a) / d);
    // uvecavamo broj tacaka u tom podeoku histograma
    histogram[podeok]++;
  }

  // ispisujemo histogram
  double x = a;
  for (int h : histogram) {
    // ispisujemo granice tekuceg podeoka (zaokruzene na tri decimale)
    cout << fixed << showpoint << setprecision(3)
	 << "[" << x << ", " << x + d << "): ";
    // ispisujemo broj tacaka u tekucem podeoku
    cout << h << '\t';
    // ispisujemo zvezdice
    double procenat = (double)h / (double)k;
    int brojZvezdica = (int)round(100 * procenat);
    for (int i = 0; i < brojZvezdica; i++)
      cout << "*";
    cout << endl;
    // prelazimo na naredni podeok
    x += d;
  }
  return 0;
}